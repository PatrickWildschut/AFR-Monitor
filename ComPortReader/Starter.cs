using Microsoft.Win32;
using System;
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
    public partial class Starter : Form
    {
        OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, InitialDirectory = Application.StartupPath, Filter = "Text Documents Only|*.txt" };
        public Starter()
        {
            InitializeComponent();
            if(!Helper.IsActivated())
            {
                VCont.Enabled = false;
                RFFBut.Enabled = false;
                LongScanCheck.Enabled = false;
                FreeLab.Visible = true;
                ActBut.Visible = true;
                FreeDays.Visible = true;
                FreeDays.Text = "Trial times left to use: " + Helper.GetTrialDaysLeft();
                if (Convert.ToInt32(Helper.GetTrialDaysLeft()) != Convert.ToInt32(Helper.GetSaveTrialDaysLeft()))
                {
                    Helper.SetTrialDaysLeft(0);
                    FreeDays.Text = "Out of trial times...";
                    BCont.Enabled = false;
                    CDCheck.Enabled = false;
                }
                else if(Convert.ToInt32(Helper.GetTrialDaysLeft()) > 0)
                {
                    Helper.SubtractTrialDays(1);
                }
                else
                {
                    FreeDays.Text = "Out of trial times...";
                    BCont.Enabled = false;
                    CDCheck.Enabled = false;
                }
            }
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
                try { new ReadFFile().ShowDialog(); } catch { }
            }
        }

        private void InstagramConnect_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/patrick_wildschut/");
        }

        private void ActBut_Click(object sender, EventArgs e)
        {
            new ActivateBox().ShowDialog();
        }
    }
}
