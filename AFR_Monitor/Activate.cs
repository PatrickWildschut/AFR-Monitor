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
    public partial class Activate : Form
    {
        public Activate()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "ptr99234qnw" || textBox1.Text == "pdz27273urw" ||
                textBox1.Text == "pnh58983ftw" || textBox1.Text == "pqe98043nnw" || textBox1.Text == "pio69270mow")
            {
                // Activate
                Helper.UpdateActivation(true);

                MessageBox.Show("Successfully activated AFR Monitor!", "AFR Monitor Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Invalid activation code!", "AFR Monitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
