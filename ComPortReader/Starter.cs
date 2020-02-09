using Microsoft.Win32;
using System.PW.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFRMonitor
{
    public partial class Starter : Form
    {
        EasyXML xml = new EasyXML(Helper.XmlLocation);

        OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, InitialDirectory = Application.StartupPath, Filter = "AFR File (*.afr)|*.afr" };
        public bool ActivatedIt = false;
        public Starter()
        {
            InitializeComponent();
            if (!Helper.IsActivated())
            {
                VCont.Enabled = false;
                ActivatedIt = false;
                RFFBut.Enabled = false;
                LongScanCheck.Enabled = false;
                ActBut.Visible = true;
                FreeDays.Visible = true;
                if (Helper.Restart)
                {
                    this.Close();
                }
                else if (Convert.ToInt32(xml.Elements.GetInnerText("/Root/TrialDays")) > 0)
                {
                    File.SetAttributes(Helper.XmlLocation, FileAttributes.Normal);
                    xml.Elements.SetInnerText("/Root/TrialDays", (Convert.ToInt32(xml.Elements.GetInnerText("/Root/TrialDays")) - 1).ToString());
                    File.SetAttributes(Helper.XmlLocation, FileAttributes.Hidden);
                    FreeDays.Text = "Trial times left to use: " + Convert.ToInt32(xml.Elements.GetInnerText("/Root/TrialDays"));
                }
                else
                {
                    FreeDays.Text = "Out of trial times...";
                    BCont.Enabled = false;
                    CDCheck.Enabled = false;
                }
            }
            else
            {
                ActivatedIt = true;
                FreeLab.Location = new Point(FreeLab.Location.X, FreeLab.Location.Y + 32);
                FreeLab.Font = new Font("Arial", 9, FontStyle.Regular);
                FreeLab.Text = "If Voice Control doesn't work, \ndouble click me";
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
                Helper.CruisingMode = true;
            }
            else
            {
                Helper.CruisingMode = false;
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

        private void FreeLab_DoubleClick(object sender, EventArgs e)
        {
            if(ActivatedIt)
            {
                MessageBox.Show(Helper.VoiceControlManual(), "Voice Control Manual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
