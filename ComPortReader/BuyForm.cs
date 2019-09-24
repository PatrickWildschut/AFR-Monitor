using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace AFRMonitor
{
    public partial class BuyForm : Form
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void BBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AFKBut_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                if(textBox1.Text.Contains("@") && textBox1.Text.Contains("."))
                {
                    MailMessage msg = new MailMessage("pwwork04@gmail.com", "patrick.wildschut@hotmail.com", "Buying AFRMonitor", "Hi Patrick,\n\n" + FirstN.Text + " " + MidASur.Text + " requested a license key for AFR Monitor.\nTheir e-mail address is: " + textBox1.Text + ". Remember to check if they paid first.\n\nRegards, Coded Patrick");
                    SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                    sc.UseDefaultCredentials = false;
                    NetworkCredential cre = new NetworkCredential("pwwork04@gmail.com", Helper.Pass);
                    sc.Credentials = cre;
                    sc.EnableSsl = true;
                    sc.Send(msg);
                    MessageBox.Show("License key requested! Be patient please.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid e-mail address.", "No email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Input your e-mail address before sending.", "No email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
