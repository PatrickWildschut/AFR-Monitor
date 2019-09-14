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

namespace AFRMonitor
{
    public partial class ReadFFile : Form
    {
        public string OutText = "";
        public string[] OutSepText;
        public string[] ToChart;
        public ReadFFile()
        {
            InitializeComponent();
            ChartReadView.ChartAreas[0].AxisY.Minimum = 10;
            ChartReadView.ChartAreas[0].AxisY.Maximum = 20;
            OutSepText = File.ReadAllText(Helper.ReadFileLocation).Split('s');
            OutText = OutSepText[3];
            ToChart = OutText.Split('\n');
            foreach(string d in ToChart)
            {
                if(!string.IsNullOrEmpty(d))
                ChartReadView.Series[0].Points.AddY(Convert.ToDouble(d));
            }
        }

        private void ChartReadView_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Helper.ReadFileLocation);
        }
    }
}
