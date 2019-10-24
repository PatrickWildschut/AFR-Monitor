﻿namespace AFRMonitor
{
    partial class Starter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starter));
            this.VCont = new System.Windows.Forms.Button();
            this.BCont = new System.Windows.Forms.Button();
            this.CDCheck = new System.Windows.Forms.CheckBox();
            this.LongScanCheck = new System.Windows.Forms.CheckBox();
            this.RFFBut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.FreeDays = new System.Windows.Forms.Label();
            this.ActBut = new System.Windows.Forms.Button();
            this.FreeLab = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InfoPage = new System.Windows.Forms.TabPage();
            this.InstagramConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.StartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.InfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VCont
            // 
            this.VCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCont.Location = new System.Drawing.Point(6, 66);
            this.VCont.Name = "VCont";
            this.VCont.Size = new System.Drawing.Size(166, 54);
            this.VCont.TabIndex = 0;
            this.VCont.Text = "Voice Control";
            this.VCont.UseVisualStyleBackColor = true;
            this.VCont.Click += new System.EventHandler(this.VCont_Click);
            // 
            // BCont
            // 
            this.BCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCont.Location = new System.Drawing.Point(388, 66);
            this.BCont.Name = "BCont";
            this.BCont.Size = new System.Drawing.Size(166, 54);
            this.BCont.TabIndex = 1;
            this.BCont.Text = "Button Control";
            this.BCont.UseVisualStyleBackColor = true;
            this.BCont.Click += new System.EventHandler(this.BCont_Click);
            // 
            // CDCheck
            // 
            this.CDCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CDCheck.AutoSize = true;
            this.CDCheck.Location = new System.Drawing.Point(231, 55);
            this.CDCheck.Name = "CDCheck";
            this.CDCheck.Size = new System.Drawing.Size(104, 17);
            this.CDCheck.TabIndex = 2;
            this.CDCheck.Text = "Use CountDown";
            this.CDCheck.UseVisualStyleBackColor = true;
            this.CDCheck.CheckedChanged += new System.EventHandler(this.CDCheck_CheckedChanged);
            // 
            // LongScanCheck
            // 
            this.LongScanCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LongScanCheck.AutoSize = true;
            this.LongScanCheck.Location = new System.Drawing.Point(231, 32);
            this.LongScanCheck.Name = "LongScanCheck";
            this.LongScanCheck.Size = new System.Drawing.Size(108, 17);
            this.LongScanCheck.TabIndex = 3;
            this.LongScanCheck.Text = "Long Scan Mode";
            this.LongScanCheck.UseVisualStyleBackColor = true;
            this.LongScanCheck.CheckedChanged += new System.EventHandler(this.LongScanCheck_CheckedChanged);
            // 
            // RFFBut
            // 
            this.RFFBut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RFFBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFFBut.Location = new System.Drawing.Point(220, 131);
            this.RFFBut.Name = "RFFBut";
            this.RFFBut.Size = new System.Drawing.Size(127, 47);
            this.RFFBut.TabIndex = 4;
            this.RFFBut.Text = "Read From File";
            this.RFFBut.UseVisualStyleBackColor = true;
            this.RFFBut.Click += new System.EventHandler(this.RFFBut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.StartPage);
            this.tabControl1.Controls.Add(this.InfoPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 212);
            this.tabControl1.TabIndex = 5;
            // 
            // StartPage
            // 
            this.StartPage.Controls.Add(this.FreeDays);
            this.StartPage.Controls.Add(this.ActBut);
            this.StartPage.Controls.Add(this.FreeLab);
            this.StartPage.Controls.Add(this.pictureBox2);
            this.StartPage.Controls.Add(this.VCont);
            this.StartPage.Controls.Add(this.CDCheck);
            this.StartPage.Controls.Add(this.LongScanCheck);
            this.StartPage.Controls.Add(this.BCont);
            this.StartPage.Controls.Add(this.RFFBut);
            this.StartPage.Location = new System.Drawing.Point(4, 22);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(3);
            this.StartPage.Size = new System.Drawing.Size(560, 186);
            this.StartPage.TabIndex = 0;
            this.StartPage.Text = "Start";
            this.StartPage.UseVisualStyleBackColor = true;
            // 
            // FreeDays
            // 
            this.FreeDays.AutoSize = true;
            this.FreeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeDays.Location = new System.Drawing.Point(353, 163);
            this.FreeDays.Name = "FreeDays";
            this.FreeDays.Size = new System.Drawing.Size(91, 20);
            this.FreeDays.TabIndex = 8;
            this.FreeDays.Text = "Trial Open";
            this.FreeDays.Visible = false;
            // 
            // ActBut
            // 
            this.ActBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActBut.Location = new System.Drawing.Point(464, 6);
            this.ActBut.Name = "ActBut";
            this.ActBut.Size = new System.Drawing.Size(90, 29);
            this.ActBut.TabIndex = 7;
            this.ActBut.Text = "Activate";
            this.ActBut.UseVisualStyleBackColor = true;
            this.ActBut.Visible = false;
            this.ActBut.Click += new System.EventHandler(this.ActBut_Click);
            // 
            // FreeLab
            // 
            this.FreeLab.AutoSize = true;
            this.FreeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeLab.Location = new System.Drawing.Point(3, 3);
            this.FreeLab.Name = "FreeLab";
            this.FreeLab.Size = new System.Drawing.Size(197, 20);
            this.FreeLab.TabIndex = 6;
            this.FreeLab.Text = "Trial/Restricted Version";
            this.FreeLab.DoubleClick += new System.EventHandler(this.FreeLab_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(231, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // InfoPage
            // 
            this.InfoPage.Controls.Add(this.InstagramConnect);
            this.InfoPage.Controls.Add(this.pictureBox1);
            this.InfoPage.Controls.Add(this.label4);
            this.InfoPage.Controls.Add(this.label3);
            this.InfoPage.Controls.Add(this.label2);
            this.InfoPage.Controls.Add(this.label1);
            this.InfoPage.Location = new System.Drawing.Point(4, 22);
            this.InfoPage.Name = "InfoPage";
            this.InfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.InfoPage.Size = new System.Drawing.Size(560, 186);
            this.InfoPage.TabIndex = 1;
            this.InfoPage.Text = "Info";
            this.InfoPage.UseVisualStyleBackColor = true;
            // 
            // InstagramConnect
            // 
            this.InstagramConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstagramConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstagramConnect.Location = new System.Drawing.Point(447, 31);
            this.InstagramConnect.Name = "InstagramConnect";
            this.InstagramConnect.Size = new System.Drawing.Size(91, 53);
            this.InstagramConnect.TabIndex = 5;
            this.InstagramConnect.Text = "Connect to me on Instagram";
            this.InstagramConnect.UseVisualStyleBackColor = true;
            this.InstagramConnect.Click += new System.EventHandler(this.InstagramConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Build Release Date: 24 October 2019";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "By: Patrick Wildschut";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Air Fuel Ratio Monitor";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version: 1.0.11";
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 215);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Starter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Starter";
            this.tabControl1.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            this.StartPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.InfoPage.ResumeLayout(false);
            this.InfoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VCont;
        private System.Windows.Forms.Button BCont;
        private System.Windows.Forms.CheckBox CDCheck;
        private System.Windows.Forms.CheckBox LongScanCheck;
        private System.Windows.Forms.Button RFFBut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.TabPage InfoPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button InstagramConnect;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label FreeLab;
        private System.Windows.Forms.Button ActBut;
        private System.Windows.Forms.Label FreeDays;
    }
}