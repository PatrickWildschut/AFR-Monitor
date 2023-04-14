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

namespace AFRMonitor
{
    public partial class Login : Form
    {
        private static EasyXML xml = new EasyXML(Helper.ActivationXmlLocation);

        public Login()
        {
            InitializeComponent();
        }
        private async void LogBut_Click(object sender, EventArgs e)
        {
            //Helper.
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
