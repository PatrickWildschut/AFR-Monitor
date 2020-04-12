﻿using System.PW.Xml;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;

namespace AFRMonitor
{
    public partial class Starter : Form
    {
        EasyXML Activation = new EasyXML(Helper.ActivationXmlLocation);
        EasyXML Settings = new EasyXML(Helper.SettingsXmlLocation);

        ColorDialog cd = new ColorDialog();
        OpenFileDialog ofd;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public bool ActivatedIt = false;
        public Starter()
        {
            InitializeComponent();

            SetupUI();

            if (!Helper.IsActivated())
            {
                MessageBox.Show("Not activated, login before opening this.", "AFR Monitor Not Activated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                ActivatedIt = true;
            }
        }

        public async Task SetupUI()
        {
            await Task.Run(() => 
            {
                Helper.Version = this.ProductVersion;
                VersionLab.Invoke(new Action(() => VersionLab.Text = "Version: " + this.ProductVersion));

                // Setup License plate
                LicenseLAB.Invoke(new Action(() => LicenseLAB.Text = Activation.Elements.GetInnerText("/Root/BrandType")));

                // Setup BHP setters
                LowBSTNUM.Invoke(new Action(() => LowBSTNUM.Value = Convert.ToInt32(Settings.Elements.GetInnerText("/Root/LowBoostBHP"))));
                HighBSTNUM.Invoke(new Action(() => HighBSTNUM.Value = Convert.ToInt32(Settings.Elements.GetInnerText("/Root/HighBoostBHP"))));

                ofd = new OpenFileDialog() { Multiselect = false, InitialDirectory = Settings.Elements.GetInnerText("/Root/SaveLocation"), Filter = "Air Fuel Ratio File (*.afr)|*.afr" };

                // Setup line color view in settings
                ChartLinePicBox.Invoke(new Action(() => ChartLinePicBox.BackColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/LineColor"))));
                WarChartLinePicBox.Invoke(new Action(() => WarChartLinePicBox.BackColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/WarningLineColor"))));

                // Slider
                WarningTrack.Invoke(new Action(() => WarningTrack.Value = Convert.ToInt32(Settings.Elements.GetInnerText("/Root/Difference"))));
            });
        }

        // Button control button clicked
        private void BCont_Click(object sender, EventArgs e)
        {
            SaveValues();

            Helper.UsageVariable = 2;
            new AFRMonitor().ShowDialog();
        }

        // Voice control button clicked
        private void VCont_Click(object sender, EventArgs e)
        {
            SaveValues();

            Helper.UsageVariable = 1;
            new AFRMonitor().ShowDialog();
        }

        // Read from file button clicked
        private void RFFBut_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SaveValues();

                Helper.ReadFileLocation = ofd.FileName;
                try { new ReadFFile().ShowDialog(); } catch { }
            }
        }

        private void SaveValues()
        {
            Helper.WarningSlider = WarningTrack.Value;
            Helper.LowBoostBHP = Decimal.ToInt32(LowBSTNUM.Value);
            Helper.HighBoostBHP = Decimal.ToInt32(HighBSTNUM.Value);

            // Save values to the settings xml
            Settings.Elements.SetInnerText("/Root/Difference", Helper.WarningSlider.ToString());
            Settings.Elements.SetInnerText("/Root/LowBoostBHP", Helper.LowBoostBHP.ToString());
            Settings.Elements.SetInnerText("/Root/HighBoostBHP", Helper.HighBoostBHP.ToString());
        }

        private void CDCheck_CheckedChanged(object sender, EventArgs e)
        {
            Helper.CountDown = CDCheck.Checked;
        }

        private void LongScanCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(UnlimitedCheck.Checked)
            {
                Helper.UnlimitedMode = true;
            }
            else
            {
                Helper.UnlimitedMode = false;
            }
        }

        private void InstagramConnect_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/patrick_wildschut/");
        }

        private void FreeLab_DoubleClick(object sender, EventArgs e)
        {
            if(ActivatedIt)
            {
                MessageBox.Show(Helper.VoiceControlManual(), "Voice Control Manual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CLColor_Click(object sender, EventArgs e)
        {
            if(cd.ShowDialog() == DialogResult.OK)
            {
                Settings.Elements.SetInnerText("/Root/LineColor", "#" + cd.Color.R.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.B.ToString("X2"));

                // Update view
                ChartLinePicBox.BackColor = cd.Color;
            }
        }

        private void CLWarColor_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Settings.Elements.SetInnerText("/Root/WarningLineColor", "#" + cd.Color.R.ToString("X2") + cd.Color.G.ToString("X2") + cd.Color.B.ToString("X2"));

                // Update view
                WarChartLinePicBox.BackColor = cd.Color;
            }
        }

        private void FileSaveBut_Click(object sender, EventArgs e)
        {
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                Settings.Elements.SetInnerText("/Root/SaveLocation", fbd.SelectedPath);
            }
        }

        bool IsBrand = true;

        private async void LicenseLAB_Click(object sender, EventArgs e)
        {
            await Task.Run(() => 
            {
                if(!IsBrand)
                {
                    LicenseLAB.Invoke(new Action(() => LicenseLAB.Text = Activation.Elements.GetInnerText("/Root/BrandType")));
                    IsBrand = true;
                }
                else
                {
                    LicenseLAB.Invoke(new Action(() => LicenseLAB.Text = Activation.Elements.GetInnerText("/Root/LicensePlate")));
                    IsBrand = false;
                }
                
            });
        }

        private void LogOutBut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout? You'll have to login again to use this program.\nThis program will restart.", "AFR Monitor Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Normal);
                Helper.UpdateActivation(false);
                File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Hidden);
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }
    }
}
