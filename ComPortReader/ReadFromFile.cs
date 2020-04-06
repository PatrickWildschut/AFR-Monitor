using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.PW.Encryption;
using System.Threading.Tasks;
using System.Drawing;
using System.PW.Xml;
using System.Threading;

namespace AFRMonitor
{
    public partial class ReadFFile : Form
    {
        // XML
        static EasyXML Settings = new EasyXML(Helper.SettingsXmlLocation);
        Color LineColor;
        Color WarningLineColor;

        public string OutText = "";
        public string[] OutSepText;
        public string[] OutLabText;
        public string InputInterval;
        public int PointCount = 0;
        public List<CustomLabel> clSave = new List<CustomLabel>();
        public ReadFFile()
        {
            InitializeComponent();
            LineColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/LineColor"));
            WarningLineColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/WarningLineColor"));
            ChartReadView.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ChartReadView.ChartAreas[0].CursorX.AutoScroll = true;
            ChartReadView.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            ChartReadView.ChartAreas[0].AxisY.Minimum = 10;
            ChartReadView.ChartAreas[0].AxisY.Maximum = 20;
            ChartReadView.ChartAreas[0].AxisY.Interval = 1;
            ChartReadView.Series[0].Color = LineColor;

            LoadUI();
        }

        private async void LoadUI()
        {
            string Decrypted = string.Empty;
            #region Chart
            try
            {
                #region Labels
                Decrypted = await EasyEncryption.Async.DecryptStringAsync(File.ReadAllText(Helper.ReadFileLocation));
                OutLabText = Decrypted.Split(':');
                TTRTValue.Text = OutLabText[3].Split('\n')[0].Trim(' ');
                LowValValue.Text = OutLabText[1].Split('\n')[0].Trim(' ');

                if (OutLabText[2].Split('\n')[0].Trim(' ') == "True")
                {
                    BoostLAB.Text = "High Boost (" + Settings.Elements.GetInnerText("/Root/HighBoostBHP") + " BHP)";
                }
                else
                {
                    BoostLAB.Text = "Low Boost (" + Settings.Elements.GetInnerText("/Root/LowBoostBHP") + " BHP)";
                }

                #endregion

                int i = 0;
                int Times = 0;
                double LastValue = 0.0;
                Decrypted = await EasyEncryption.Async.DecryptStringAsync(File.ReadAllText(Helper.ReadFileLocation));
                OutSepText = Decrypted.Split('s');
                OutText = OutSepText[OutSepText.Length - 1];
                OutSepText = OutText.Split('\n');
                InputInterval = OutLabText[OutLabText.Length - 1].Split('\n')[0].Trim(' ');
                foreach (string d in OutSepText)
                {
                    if (!string.IsNullOrEmpty(d))
                    {
                        // Add to chart
                        ChartReadView.Series[0].Points.AddY(Convert.ToDouble(d));

                        if (Convert.ToDouble(d) - LastValue < -(Helper.WarningSlider / 10) || Convert.ToDouble(d) - LastValue > (Helper.WarningSlider / 10))
                        {
                            ChartReadView.Series[0].Points[ChartReadView.Series[0].Points.Count - 1].Color = WarningLineColor;
                        }

                        LastValue = Convert.ToDouble(d);

                        i++;
                        if (i >= 5 && OutSepText.Length <= 40)
                        {
                            Times++;
                            i = 0;
                            clSave.Add(new CustomLabel(5 * Times - 5, 5 * Times + 5, Convert.ToDouble((Convert.ToDouble(InputInterval) / 1000 * 5 * Times)).ToString("0.0"), 0, LabelMarkStyle.None, GridTickTypes.All));
                        }
                        else
                        {
                            if (i >= 20 && OutSepText.Length <= 150)
                            {
                                Times++;
                                i = 0;
                                //clSave.Add(new CustomLabel(20.7 * Times - 5, 20.7 * Times + 5, (3.5 * Times).ToString(), 0, LabelMarkStyle.None, GridTickTypes.All));
                                clSave.Add(new CustomLabel(20 * Times - 5, 20 * Times + 5, Convert.ToDouble((Convert.ToDouble(InputInterval) / 1000 * 20 * Times)).ToString("0.0"), 0, LabelMarkStyle.None, GridTickTypes.All));
                            }
                            else if (i >= 50)
                            {
                                Times++;
                                i = 0;
                                //clSave.Add(new CustomLabel(50.5 * Times - 10, 50.5 * Times + 10, (8.5 * Times).ToString(), 0, LabelMarkStyle.None, GridTickTypes.All));
                                clSave.Add(new CustomLabel(50 * Times - 10, 50 * Times + 10, Convert.ToDouble((Convert.ToDouble(InputInterval) / 1000 * 50 * Times)).ToString("0.0"), 0, LabelMarkStyle.None, GridTickTypes.All));
                            }
                        }
                    }

                }
                PointCount = ChartReadView.Series[0].Points.Count;

            
                #endregion
            }
            catch { MessageBox.Show("Corrupted .afr file.", "Corrupted", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        }

        private async Task PlaybackChart()
        {
            await Task.Run(() =>
            {
                //Process.Start("explorer.exe", Helper.ReadFileLocation);
                double LastValue = 0.0;
                ChartReadView.Invoke(new Action(() => ChartReadView.ChartAreas[0].AxisX.Maximum = PointCount));
                ChartReadView.Invoke(new Action(() => ChartReadView.Series[0].Points.Clear()));

                foreach (string d in OutSepText)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(d))
                        {
                            // Add to chart
                            Thread.Sleep(Convert.ToInt32(Convert.ToDouble(InputInterval)));
                            ChartReadView.Invoke(new Action(() => ChartReadView.Series[0].Points.AddY(Convert.ToDouble(d))));

                            if (Convert.ToDouble(d) - LastValue < -(Helper.WarningSlider / 10) || Convert.ToDouble(d) - LastValue > (Helper.WarningSlider / 10))
                            {
                                ChartReadView.Invoke(new Action(() => ChartReadView.Series[0].Points[ChartReadView.Series[0].Points.Count - 1].Color = WarningLineColor));
                            }

                            LastValue = Convert.ToDouble(d);
                        }
                    }
                    catch { }
                }
            });
        }
        Task RunningPlaybackChart;
        private void ChartReadView_DoubleClick(object sender, MouseEventArgs e)
        {
            if (RunningPlaybackChart == null || RunningPlaybackChart.IsCompleted)
            {
                RunningPlaybackChart = PlaybackChart();
            }
            //MessageBox.Show(ChartReadView.ChartAreas[0].AxisX.PixelPositionToValue(e.X).ToString());

        }

        private void ChartReadView_DragDrop(object sender, DragEventArgs e)
        {
            string[] saver = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string[] ToHelper = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            saver = saver[0].Split('.');
            if(saver[saver.Length - 1] == "afr")
            {
                Helper.ReadFileLocation = ToHelper[0];
                new ReadFFile().Show();
            }
            else
            {
                MessageBox.Show("Only .afr files created by this program and not modified can be used.", "Wrong file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChartReadView_DragEnter(object sender, DragEventArgs e)
        {
            //MessageBox.Show("Hovering");
            e.Effect = DragDropEffects.Copy;
        }

        private void TCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(tCheck.Checked)
            {
                SamplesLab.Text = "Time in sec";
                foreach (CustomLabel cl in clSave)
                {
                    ChartReadView.ChartAreas[0].AxisX.CustomLabels.Add(cl);
                }
            }
            else
            {
                ChartReadView.ChartAreas[0].AxisX.CustomLabels.Clear();
                GC.Collect();
                SamplesLab.Text = "Samples";
            }
        }
    }
}
