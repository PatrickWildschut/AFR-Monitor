﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFRMonitor
{
    public partial class ActivateBox : Form
    {
        public ActivateBox()
        {
            InitializeComponent();
        }
        bool activationkeydiscovered = false;
        private void Button2_Click(object sender, EventArgs e)
        {
            foreach(string key in Helper.ValidActivationKeys)
            {
                if (key.ToLower() == InputKey.Text.ToLower()) //if key is valid
                {
                    Helper.UpdateActivation(true);
                    MessageBox.Show("Successfully activated!", "Activation complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Restart the application to apply changes", "Restart required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    activationkeydiscovered = true;
                    this.Close();
                    break;
                }
            }
            if(!activationkeydiscovered)
            MessageBox.Show("Invalid Key. To buy a key, click on the buy button.", "Bad key", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
