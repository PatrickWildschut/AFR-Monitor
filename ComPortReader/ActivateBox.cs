﻿using System.PW.Xml;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AFRMonitor
{
    public partial class ActivateBox : Form
    {
        EasyXML xml = new EasyXML(Helper.ActivationXmlLocation);

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
                    File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Normal);
                    xml.Elements.SetInnerText("/Root/Activated", "50470916");
                    File.SetAttributes(Helper.ActivationXmlLocation, FileAttributes.Hidden);
                    MessageBox.Show("Successfully activated!", "Activation complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    activationkeydiscovered = true;
                    Process.Start(Application.ExecutablePath);
                    Application.Exit();
                    break;
                }
            }
            if(!activationkeydiscovered)
            MessageBox.Show("Invalid Key. To buy a key, click on the buy button.", "Bad key", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Process.Start("https://www.instagram.com/patrick_wildschut/");
            //MessageBox.Show("Send me a DM", "DM Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new BuyForm().ShowDialog();
        }

        private void PSTBut_Click(object sender, EventArgs e)
        {
            InputKey.Text = Clipboard.GetText();
        }
    }
}
