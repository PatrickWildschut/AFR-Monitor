using System.PW.Xml;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
            Helper.Version = this.ProductVersion;
            VersionLab.Text = "Version: " + this.ProductVersion;

            // Setup BHP setters
            LowBSTNUM.Value = Convert.ToInt32(Settings.Elements.GetInnerText("/Root/LowBoostBHP"));
            HighBSTNUM.Value = Convert.ToInt32(Settings.Elements.GetInnerText("/Root/HighBoostBHP"));

            ofd = new OpenFileDialog() { Multiselect = false, InitialDirectory = Settings.Elements.GetInnerText("/Root/SaveLocation"), Filter = "Air Fuel Ratio File (*.afr)|*.afr" };

            // Setup line color view in settings
            ChartLinePicBox.BackColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/LineColor"));
            WarChartLinePicBox.BackColor = ColorTranslator.FromHtml(Settings.Elements.GetInnerText("/Root/WarningLineColor"));

            if (!Helper.IsActivated())
            {
                VCont.Enabled = false;
                ActivatedIt = false;
                CDCheck.Enabled = false;
                ActBut.Visible = true;
                FreeDays.Visible = true;
                if (Helper.Restart)
                {
                    this.Close();
                }
                else if (Convert.ToInt32(Activation.Elements.GetInnerText("/Root/TrialDays")) > 0)
                {
                    File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Normal);
                    Activation.Elements.SetInnerText("/Root/TrialDays", (Convert.ToInt32(Activation.Elements.GetInnerText("/Root/TrialDays")) - 1).ToString());
                    File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Hidden);
                    FreeDays.Text = "Trial times left to use: " + Convert.ToInt32(Activation.Elements.GetInnerText("/Root/TrialDays"));
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

            // Slider
            WarningTrack.Value = Convert.ToInt32(Settings.Elements.GetInnerText("/Root/Difference"));
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

        private void Starter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Helper.IsActivated())
            {
                MessageBox.Show("Thank you for using my software. To buy the full version, DM me at https://www.instagram.com/patrick_wildschut \nTrial times left: " + (Convert.ToInt32(Activation.Elements.GetInnerText("/Root/TrialDays")) - 1).ToString(), "Thanks!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
