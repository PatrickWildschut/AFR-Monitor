using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPortReader
{
    public partial class Starter : Form
    {
        public Starter()
        {
            InitializeComponent();
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
    }
}
