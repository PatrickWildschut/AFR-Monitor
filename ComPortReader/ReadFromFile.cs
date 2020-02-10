using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.PW.Encryption;
using System.Threading.Tasks;
using System.Drawing;
using System.PW.Xml;

namespace AFRMonitor
{
    public partial class ReadFFile : Form
    {
        // XML
        static EasyXML Settings = new EasyXML(Helper.SettingsXmlLocation);
        Color LineColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/LineColor"));
        Color WarningLineColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/WarningLineColor"));

        public string OutText = "";
        public string[] OutSepText;
        public List<CustomLabel> clSave = new List<CustomLabel>();
        public ReadFFile()
        {
            InitializeComponent();
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
                int i = 0;
                int Times = 0;
                double LastValue = 0.0;
                Decrypted = await EasyEncryption.DecryptStringAsync(File.ReadAllText(Helper.ReadFileLocation));
                OutSepText = Decrypted.Split('s');
                OutText = OutSepText[OutSepText.Length - 1];
                OutSepText = OutText.Split('\n');
                foreach (string d in OutSepText)
                {
                    if (!string.IsNullOrEmpty(d))
                    {
                        // Add to chart
                        ChartReadView.Series[0].Points.AddY(Convert.ToDouble(d));

                        if(Convert.ToDouble(d) - LastValue < -0.5 || Convert.ToDouble(d) - LastValue > 0.5)
                        {
                            ChartReadView.Series[0].Points[ChartReadView.Series[0].Points.Count - 1].Color = WarningLineColor;
                        }

                        LastValue = Convert.ToDouble(d);

                        i++;
                        if (i >= 20 && OutSepText.Length < 149)
                        {
                            Times++;
                            i = 0;
                            clSave.Add(new CustomLabel(20.7 * Times - 5, 20.7 * Times + 5, (3.5 * Times).ToString(), 0, LabelMarkStyle.None, GridTickTypes.All));
                        }
                        else if (i >= 50)
                        {
                            Times++;
                            i = 0;
                            clSave.Add(new CustomLabel(50.5 * Times - 10, 50.5 * Times + 10, (8.5 * Times).ToString(), 0, LabelMarkStyle.None, GridTickTypes.All));
                        }
                    }

                }

            }
            catch { MessageBox.Show("Corrupted afr file.", "Corrupted", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            #endregion
            #region Label
            Decrypted = await EasyEncryption.DecryptStringAsync(File.ReadAllText(Helper.ReadFileLocation));
            OutSepText = Decrypted.Split(':');
            TTRTValue.Text = OutSepText[OutSepText.Length - 1];
            OutSepText = OutSepText[1].Split('\n');
            LowValValue.Text = OutSepText[0].Trim(' ');
            #endregion
        }

        private void ChartReadView_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Helper.ReadFileLocation);
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
