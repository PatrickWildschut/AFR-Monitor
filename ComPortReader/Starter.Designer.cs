namespace AFRMonitor
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
            this.UnlimitedCheck = new System.Windows.Forms.CheckBox();
            this.RFFBut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.LicenseLAB = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.LBSTLAB = new System.Windows.Forms.Label();
            this.HBSTLAB = new System.Windows.Forms.Label();
            this.LowBSTNUM = new System.Windows.Forms.NumericUpDown();
            this.HighBSTNUM = new System.Windows.Forms.NumericUpDown();
            this.FileSaveBut = new System.Windows.Forms.Button();
            this.WarChartLinePicBox = new System.Windows.Forms.PictureBox();
            this.ChartLinePicBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WarningTrack = new System.Windows.Forms.TrackBar();
            this.CLWarColor = new System.Windows.Forms.Button();
            this.CLColor = new System.Windows.Forms.Button();
            this.AboutPage = new System.Windows.Forms.TabPage();
            this.InstagramConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReleaseDateLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VersionLab = new System.Windows.Forms.Label();
            this.LogOutBut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.StartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SettingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowBSTNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighBSTNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarChartLinePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartLinePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningTrack)).BeginInit();
            this.AboutPage.SuspendLayout();
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
            // UnlimitedCheck
            // 
            this.UnlimitedCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnlimitedCheck.AutoSize = true;
            this.UnlimitedCheck.Location = new System.Drawing.Point(231, 32);
            this.UnlimitedCheck.Name = "UnlimitedCheck";
            this.UnlimitedCheck.Size = new System.Drawing.Size(99, 17);
            this.UnlimitedCheck.TabIndex = 3;
            this.UnlimitedCheck.Text = "Unlimited Mode";
            this.UnlimitedCheck.UseVisualStyleBackColor = true;
            this.UnlimitedCheck.CheckedChanged += new System.EventHandler(this.LongScanCheck_CheckedChanged);
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
            this.tabControl1.Controls.Add(this.SettingsPage);
            this.tabControl1.Controls.Add(this.AboutPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 212);
            this.tabControl1.TabIndex = 5;
            // 
            // StartPage
            // 
            this.StartPage.Controls.Add(this.LicenseLAB);
            this.StartPage.Controls.Add(this.pictureBox2);
            this.StartPage.Controls.Add(this.VCont);
            this.StartPage.Controls.Add(this.CDCheck);
            this.StartPage.Controls.Add(this.UnlimitedCheck);
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
            // LicenseLAB
            // 
            this.LicenseLAB.AutoSize = true;
            this.LicenseLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseLAB.Location = new System.Drawing.Point(6, 3);
            this.LicenseLAB.Name = "LicenseLAB";
            this.LicenseLAB.Size = new System.Drawing.Size(92, 24);
            this.LicenseLAB.TabIndex = 6;
            this.LicenseLAB.Text = "44-RS-RP";
            this.LicenseLAB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LicenseLAB.Click += new System.EventHandler(this.LicenseLAB_Click);
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
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.LBSTLAB);
            this.SettingsPage.Controls.Add(this.HBSTLAB);
            this.SettingsPage.Controls.Add(this.LowBSTNUM);
            this.SettingsPage.Controls.Add(this.HighBSTNUM);
            this.SettingsPage.Controls.Add(this.FileSaveBut);
            this.SettingsPage.Controls.Add(this.WarChartLinePicBox);
            this.SettingsPage.Controls.Add(this.ChartLinePicBox);
            this.SettingsPage.Controls.Add(this.label7);
            this.SettingsPage.Controls.Add(this.label6);
            this.SettingsPage.Controls.Add(this.label5);
            this.SettingsPage.Controls.Add(this.WarningTrack);
            this.SettingsPage.Controls.Add(this.CLWarColor);
            this.SettingsPage.Controls.Add(this.CLColor);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Size = new System.Drawing.Size(560, 186);
            this.SettingsPage.TabIndex = 2;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // LBSTLAB
            // 
            this.LBSTLAB.AutoSize = true;
            this.LBSTLAB.Location = new System.Drawing.Point(316, 133);
            this.LBSTLAB.Name = "LBSTLAB";
            this.LBSTLAB.Size = new System.Drawing.Size(82, 13);
            this.LBSTLAB.TabIndex = 13;
            this.LBSTLAB.Text = "Low Boost BHP";
            // 
            // HBSTLAB
            // 
            this.HBSTLAB.AutoSize = true;
            this.HBSTLAB.Location = new System.Drawing.Point(315, 41);
            this.HBSTLAB.Name = "HBSTLAB";
            this.HBSTLAB.Size = new System.Drawing.Size(84, 13);
            this.HBSTLAB.TabIndex = 12;
            this.HBSTLAB.Text = "High Boost BHP";
            // 
            // LowBSTNUM
            // 
            this.LowBSTNUM.Location = new System.Drawing.Point(323, 149);
            this.LowBSTNUM.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.LowBSTNUM.Name = "LowBSTNUM";
            this.LowBSTNUM.Size = new System.Drawing.Size(67, 20);
            this.LowBSTNUM.TabIndex = 11;
            // 
            // HighBSTNUM
            // 
            this.HighBSTNUM.Location = new System.Drawing.Point(323, 57);
            this.HighBSTNUM.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.HighBSTNUM.Name = "HighBSTNUM";
            this.HighBSTNUM.Size = new System.Drawing.Size(67, 20);
            this.HighBSTNUM.TabIndex = 10;
            // 
            // FileSaveBut
            // 
            this.FileSaveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileSaveBut.Location = new System.Drawing.Point(428, 110);
            this.FileSaveBut.Name = "FileSaveBut";
            this.FileSaveBut.Size = new System.Drawing.Size(104, 59);
            this.FileSaveBut.TabIndex = 9;
            this.FileSaveBut.Text = "AFR file save location";
            this.FileSaveBut.UseVisualStyleBackColor = true;
            this.FileSaveBut.Click += new System.EventHandler(this.FileSaveBut_Click);
            // 
            // WarChartLinePicBox
            // 
            this.WarChartLinePicBox.BackColor = System.Drawing.Color.Black;
            this.WarChartLinePicBox.Location = new System.Drawing.Point(178, 110);
            this.WarChartLinePicBox.Name = "WarChartLinePicBox";
            this.WarChartLinePicBox.Size = new System.Drawing.Size(100, 59);
            this.WarChartLinePicBox.TabIndex = 8;
            this.WarChartLinePicBox.TabStop = false;
            // 
            // ChartLinePicBox
            // 
            this.ChartLinePicBox.BackColor = System.Drawing.Color.Black;
            this.ChartLinePicBox.Location = new System.Drawing.Point(178, 18);
            this.ChartLinePicBox.Name = "ChartLinePicBox";
            this.ChartLinePicBox.Size = new System.Drawing.Size(100, 59);
            this.ChartLinePicBox.TabIndex = 7;
            this.ChartLinePicBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(512, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 9);
            this.label7.TabIndex = 6;
            this.label7.Text = "1.0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 9);
            this.label6.TabIndex = 5;
            this.label6.Text = "0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Warning Difference:";
            // 
            // WarningTrack
            // 
            this.WarningTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningTrack.Location = new System.Drawing.Point(428, 32);
            this.WarningTrack.Name = "WarningTrack";
            this.WarningTrack.Size = new System.Drawing.Size(104, 45);
            this.WarningTrack.TabIndex = 3;
            this.WarningTrack.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.WarningTrack.Value = 5;
            // 
            // CLWarColor
            // 
            this.CLWarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLWarColor.Location = new System.Drawing.Point(24, 110);
            this.CLWarColor.Name = "CLWarColor";
            this.CLWarColor.Size = new System.Drawing.Size(147, 59);
            this.CLWarColor.TabIndex = 2;
            this.CLWarColor.Text = "Set Chart Line Warning Color";
            this.CLWarColor.UseVisualStyleBackColor = true;
            this.CLWarColor.Click += new System.EventHandler(this.CLWarColor_Click);
            // 
            // CLColor
            // 
            this.CLColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLColor.Location = new System.Drawing.Point(24, 18);
            this.CLColor.Name = "CLColor";
            this.CLColor.Size = new System.Drawing.Size(147, 59);
            this.CLColor.TabIndex = 0;
            this.CLColor.Text = "Set Chart Line Color";
            this.CLColor.UseVisualStyleBackColor = true;
            this.CLColor.Click += new System.EventHandler(this.CLColor_Click);
            // 
            // AboutPage
            // 
            this.AboutPage.Controls.Add(this.LogOutBut);
            this.AboutPage.Controls.Add(this.InstagramConnect);
            this.AboutPage.Controls.Add(this.pictureBox1);
            this.AboutPage.Controls.Add(this.ReleaseDateLab);
            this.AboutPage.Controls.Add(this.label3);
            this.AboutPage.Controls.Add(this.label2);
            this.AboutPage.Controls.Add(this.VersionLab);
            this.AboutPage.Location = new System.Drawing.Point(4, 22);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.AboutPage.Size = new System.Drawing.Size(560, 186);
            this.AboutPage.TabIndex = 1;
            this.AboutPage.Text = "About";
            this.AboutPage.UseVisualStyleBackColor = true;
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
            // ReleaseDateLab
            // 
            this.ReleaseDateLab.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReleaseDateLab.AutoSize = true;
            this.ReleaseDateLab.Location = new System.Drawing.Point(177, 168);
            this.ReleaseDateLab.Name = "ReleaseDateLab";
            this.ReleaseDateLab.Size = new System.Drawing.Size(203, 13);
            this.ReleaseDateLab.TabIndex = 3;
            this.ReleaseDateLab.Text = "Current Build Release Date: 12 April 2020";
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
            // VersionLab
            // 
            this.VersionLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLab.AutoSize = true;
            this.VersionLab.Location = new System.Drawing.Point(476, 168);
            this.VersionLab.Name = "VersionLab";
            this.VersionLab.Size = new System.Drawing.Size(66, 13);
            this.VersionLab.TabIndex = 0;
            this.VersionLab.Text = "Version: ------";
            // 
            // LogOutBut
            // 
            this.LogOutBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBut.Location = new System.Drawing.Point(20, 31);
            this.LogOutBut.Name = "LogOutBut";
            this.LogOutBut.Size = new System.Drawing.Size(91, 53);
            this.LogOutBut.TabIndex = 6;
            this.LogOutBut.Text = "Logout";
            this.LogOutBut.UseVisualStyleBackColor = true;
            this.LogOutBut.Click += new System.EventHandler(this.LogOutBut_Click);
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
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LowBSTNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighBSTNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarChartLinePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartLinePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningTrack)).EndInit();
            this.AboutPage.ResumeLayout(false);
            this.AboutPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VCont;
        private System.Windows.Forms.Button BCont;
        private System.Windows.Forms.CheckBox CDCheck;
        private System.Windows.Forms.CheckBox UnlimitedCheck;
        private System.Windows.Forms.Button RFFBut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.TabPage AboutPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VersionLab;
        private System.Windows.Forms.Label ReleaseDateLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button InstagramConnect;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Button CLColor;
        private System.Windows.Forms.Button CLWarColor;
        private System.Windows.Forms.TrackBar WarningTrack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox WarChartLinePicBox;
        private System.Windows.Forms.PictureBox ChartLinePicBox;
        private System.Windows.Forms.Button FileSaveBut;
        private System.Windows.Forms.Label LBSTLAB;
        private System.Windows.Forms.Label HBSTLAB;
        private System.Windows.Forms.NumericUpDown LowBSTNUM;
        private System.Windows.Forms.NumericUpDown HighBSTNUM;
        private System.Windows.Forms.Label LicenseLAB;
        private System.Windows.Forms.Button LogOutBut;
    }
}