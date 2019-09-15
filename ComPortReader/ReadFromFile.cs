﻿using System;
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
        public ReadFFile()
        {
            InitializeComponent();
            ChartReadView.ChartAreas[0].AxisY.Minimum = 10;
            ChartReadView.ChartAreas[0].AxisY.Maximum = 20;
            #region Chart
            OutSepText = File.ReadAllText(Helper.ReadFileLocation).Split('s');
            OutText = OutSepText[3];
            OutSepText = OutText.Split('\n');
            foreach(string d in OutSepText)
            {
                if(!string.IsNullOrEmpty(d))
                ChartReadView.Series[0].Points.AddY(Convert.ToDouble(d));
            }
            #endregion
            #region Label
            OutSepText = File.ReadAllText(Helper.ReadFileLocation).Split(':');
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
            Helper.ReadFileLocation = saver[0];
            new ReadFFile().Show();
        }

        private void ChartReadView_DragEnter(object sender, DragEventArgs e)
        {
            //MessageBox.Show("Hovering");
            e.Effect = DragDropEffects.Copy;
        }
    }
}
