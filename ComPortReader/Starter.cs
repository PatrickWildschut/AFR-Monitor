﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFRMonitor
{
    public partial class Starter : Form
    {
        OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false };
        public Starter()
        {
            InitializeComponent();
        }

        private void BCont_Click(object sender, EventArgs e)
        {
            Helper.UsageVariable = 2;
            new AFRMonitor().ShowDialog();
        }

        private void VCont_Click(object sender, EventArgs e)
        {
            Helper.UsageVariable = 1;
            new AFRMonitor().ShowDialog();
        }

        private void CDCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(CDCheck.Checked)
            {
                Helper.CountDown = true;
            }
            else
            {
                Helper.CountDown = false;
            }
        }

        private void LongScanCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(LongScanCheck.Checked)
            {
                Helper.LongScanMode = true;
            }
            else
            {
                Helper.LongScanMode = false;
            }
        }

        private void RFFBut_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Helper.ReadFileLocation = ofd.FileName;
                // stuff to helper
                //
                //
                new ReadFFile().ShowDialog();
            }
        }
    }
}