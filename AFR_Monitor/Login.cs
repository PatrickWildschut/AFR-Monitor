using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.PW.Encryption;
using System.PW.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AFRMonitor
{
    public partial class Login : Form
    {
        private static EasyXML xml = new EasyXML(Helper.ActivationXmlLocation);

        public Login()
        {
            InitializeComponent();
        }
        // "INSERT INTO UJWcEHlQGQ.RegisteredCars(Mail_Address,Password,License_Plate) VALUES('" + MailTB.Text + "','" + PassTB.Text + "','" + LicenseTB.Text + "')"
        private async void LogBut_Click(object sender, EventArgs e)
        {
            if(LogBut.Text == "Login")
            {
                bool Found = false;
                // Login
                if (!string.IsNullOrEmpty(MailTB.Text) && !string.IsNullOrEmpty(PassTB.Text) && !string.IsNullOrEmpty(LicenseTB.Text))
                {
                    await Task.Run(() =>
                    {
                        DataSet Response = Helper.GetDatabase();

                        foreach (DataRow r in Response.Tables[0].Rows)
                        {
                            if (EasyEncryption.OneLine.DecryptString(r[2].ToString()) == MailTB.Text && EasyEncryption.OneLine.DecryptString(r[3].ToString()) == PassTB.Text &&
                                EasyEncryption.OneLine.DecryptString(r[6].ToString()) == LicenseTB.Text)
                            {
                                // Logged in
                                // Activate program through xml
                                if (r[7].ToString() == "50470916")
                                {
                                    File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Normal);

                                    Helper.UpdateActivation(true);
                                    xml.Elements.SetInnerText("/Root/LicenseFullName", r[1].ToString());
                                    xml.Elements.SetInnerText("/Root/BrandType", r[4].ToString() + " " + r[5].ToString());
                                    xml.Elements.SetInnerText("/Root/LicensePlate", EasyEncryption.OneLine.DecryptString(r[6].ToString()));

                                    File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Hidden);

                                    LogBut.Invoke(new Action(() => LogBut.Text = "Start"));
                                }
                                else
                                {
                                    LogBut.Invoke(new Action(() => LogBut.Text = "Activate Account"));
                                }

                                // Show user that we're logged in
                                LoggedInLAB.Invoke(new Action(() => LoggedInLAB.Visible = true));
                                Found = true;
                                break;
                            }
                        }
                    });

                    if(!Found)
                    {
                        MessageBox.Show("Could not find your account, make sure your information is correct.", "AFR Monitor Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Make sure all textboxes are filled in.", "AFR Monitor Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(LogBut.Text == "Start")
            {
                // Logged in and activated, start main application
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else if(LogBut.Text == "Activate Account")
            {
                // Logged in not activated
                
            }
        }

        private void RegBut_Click(object sender, EventArgs e)
        {
            new Register().ShowDialog();
        }

        private void ShowPassBUT_Click(object sender, EventArgs e)
        {
            if (ShowPassBUT.Text == "Show")
            {
                PassTB.PasswordChar = '\0';

                ShowPassBUT.Text = "Hide";
            }
            else
            {
                PassTB.PasswordChar = '*';

                ShowPassBUT.Text = "Show";
            }
        }
    }
}
