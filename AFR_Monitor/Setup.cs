using System;
using System.Diagnostics;
using System.IO;
using System.PW.Encryption;
using System.PW.Xml;
using System.Windows.Forms;

namespace AFRMonitor
{
    public partial class Setup : Form
    {
        private static EasyXML xml = new EasyXML(Helper.ActivationXmlLocation);

        public Setup()
        {
            InitializeComponent();
        }

        private void ReqBut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FullNameTB.Text) && !string.IsNullOrEmpty(CarNameTB.Text) && !string.IsNullOrEmpty(LicenseTB.Text))
            {
                // Complete setup

                if (!ReqLicenseCB.Checked)
                {
                    if(MessageBox.Show("Are you sure you don't want to request a full access license?", "AFR Monitor Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        // Ask if they really don't want a license, if they do, then just close this and let them check the license checkbox :)
                        return;
                    }
                }

                // Check if license plate has "-"
                if (!LicenseTB.Text.Contains("-"))
                {
                    MessageBox.Show("License plate requires '-', example: 01-AAA-01", "AFR Monitor Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Setup
                File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Normal);

                //Helper.UpdateActivation(true);
                xml.Elements.SetInnerText("/Root/LicenseFullName", FullNameTB.Text);
                xml.Elements.SetInnerText("/Root/CarName", CarNameTB.Text);
                xml.Elements.SetInnerText("/Root/LicensePlate", LicenseTB.Text.ToUpper());
                Helper.UpdateLoggedIn(true);

                File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Hidden);

                MessageBox.Show("Successfully setup AFR Monitor!", "AFR Monitor Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                // Not all textboxes have values
                MessageBox.Show("Fill in all textboxes correctly to complete this setup!", "AFR Monitor Setup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
