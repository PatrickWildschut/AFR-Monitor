using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AFRMonitor
{
    public partial class ReadFFile : Form
    {
        public string OutText = "";
        public string[] OutSepText;
        public List<CustomLabel> clSave = new List<CustomLabel>();
        public ReadFFile()
        {
            InitializeComponent();
            ChartReadView.ChartAreas[0].AxisY.Minimum = 10;
            ChartReadView.ChartAreas[0].AxisY.Maximum = 20;
            ChartReadView.ChartAreas[0].AxisY.Interval = 1;
            #region Chart
            try
            {
                int i = 0;
                int Times = 0;
                OutSepText = File.ReadAllText(Helper.ReadFileLocation).Split('s');
                OutText = OutSepText[OutSepText.Length - 1];
                OutSepText = OutText.Split('\n');
                foreach (string d in OutSepText)
                {
                    if (!string.IsNullOrEmpty(d))
                    {
                        ChartReadView.Series[0].Points.AddY(Convert.ToDouble(d));
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
            catch { MessageBox.Show("Corrupted txt file.", "Corrupted", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            #endregion
            #region Label
            OutSepText = File.ReadAllText(Helper.ReadFileLocation).Split(':');
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
            if(saver[saver.Length - 1] == "txt")
            {
                Helper.ReadFileLocation = ToHelper[0];
                new ReadFFile().Show();
            }
            else
            {
                MessageBox.Show("Only .txt files created by this program and not modified can be used.", "Wrong file", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
