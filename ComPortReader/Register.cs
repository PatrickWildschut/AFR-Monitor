using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.PW.Encryption;

namespace AFRMonitor
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void ReqBut_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(FullNameTB.Text) && !string.IsNullOrEmpty(MailTB.Text) && !string.IsNullOrEmpty(PassTB.Text) && !string.IsNullOrEmpty(BrandTB.Text)
                && !string.IsNullOrEmpty(TypeTB.Text) && !string.IsNullOrEmpty(LicenseTB.Text))
            {
                // All textboxes have been filled in
                // Check if the given license plate contains a dash
                if(LicenseTB.Text.Contains('-'))
                {
                    // Check if given email isn't in use already, and if given License plate isn't in use
                    bool MailInUse = false;
                    bool LicenseInUse = false;
                    foreach (DataRow row in Helper.GetDatabase().Tables[0].Rows)
                    {
                        if (EasyEncryption.OneLine.DecryptString(row[2].ToString()).ToLower() == MailTB.Text.ToLower())
                        {
                            MailInUse = true;
                            break;
                        }
                        else if (EasyEncryption.OneLine.DecryptString(row[6].ToString()).ToLower() == LicenseTB.Text.ToLower())
                        {
                            LicenseInUse = true;
                            break;
                        }
                    }

                    // If not in use, create account
                    if (!MailInUse && !LicenseInUse)
                    {
                        // Encrypt
                        string EncMail = EasyEncryption.OneLine.EncryptString(MailTB.Text);
                        string EncPass = EasyEncryption.OneLine.EncryptString(PassTB.Text);
                        string EncLice = EasyEncryption.OneLine.EncryptString(LicenseTB.Text);

                        Helper.SetDatabase("INSERT INTO UJWcEHlQGQ.RegisteredCars(FullName,Mail_Address,Password,Brand,Type,License_Plate) VALUES('" + FullNameTB.Text + "','" + EncMail + "','" + EncPass + "','" + BrandTB.Text + "','" + TypeTB.Text + "','" + EncLice + "')");

                        MessageBox.Show("Successfully requested! Keep an eye on your mail address.", "AFR Monitor Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (MailInUse)
                    {
                        MessageBox.Show("Given mail address is in use already.", "AFR Monitor Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (LicenseInUse)
                    {
                        MessageBox.Show("Give license is in use already.", "AFR Monitor Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } // Doesn't contain a dash
                else
                {
                    MessageBox.Show("The license plate needs to have at least 1 dash (-)", "AFR Monitor Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                

            }
            else
            {
                // Not all textboxes have values
                MessageBox.Show("Fill in all textboxes to request your license.", "AFR Monitor Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
