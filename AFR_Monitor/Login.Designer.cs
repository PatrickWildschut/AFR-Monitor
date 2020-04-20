namespace AFRMonitor
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.RegBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LicenseTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LogBut = new System.Windows.Forms.Button();
            this.LoggedInLAB = new System.Windows.Forms.Label();
            this.ShowPassBUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegBut
            // 
            this.RegBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBut.Location = new System.Drawing.Point(427, 48);
            this.RegBut.Name = "RegBut";
            this.RegBut.Size = new System.Drawing.Size(115, 42);
            this.RegBut.TabIndex = 0;
            this.RegBut.Text = "Register";
            this.RegBut.UseVisualStyleBackColor = true;
            this.RegBut.Click += new System.EventHandler(this.RegBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New? Register here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(37, 101);
            this.MailTB.MaxLength = 50;
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(175, 20);
            this.MailTB.TabIndex = 3;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(37, 151);
            this.PassTB.MaxLength = 15;
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(175, 20);
            this.PassTB.TabIndex = 4;
            // 
            // LicenseTB
            // 
            this.LicenseTB.Location = new System.Drawing.Point(37, 202);
            this.LicenseTB.MaxLength = 20;
            this.LicenseTB.Name = "LicenseTB";
            this.LicenseTB.Size = new System.Drawing.Size(175, 20);
            this.LicenseTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mail Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "License Plate:";
            // 
            // LogBut
            // 
            this.LogBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBut.Location = new System.Drawing.Point(329, 190);
            this.LogBut.Name = "LogBut";
            this.LogBut.Size = new System.Drawing.Size(115, 42);
            this.LogBut.TabIndex = 9;
            this.LogBut.Text = "Login";
            this.LogBut.UseVisualStyleBackColor = true;
            this.LogBut.Click += new System.EventHandler(this.LogBut_Click);
            // 
            // LoggedInLAB
            // 
            this.LoggedInLAB.AutoSize = true;
            this.LoggedInLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInLAB.Location = new System.Drawing.Point(346, 171);
            this.LoggedInLAB.Name = "LoggedInLAB";
            this.LoggedInLAB.Size = new System.Drawing.Size(81, 16);
            this.LoggedInLAB.TabIndex = 10;
            this.LoggedInLAB.Text = "Logged in!";
            this.LoggedInLAB.Visible = false;
            // 
            // ShowPassBUT
            // 
            this.ShowPassBUT.Location = new System.Drawing.Point(218, 151);
            this.ShowPassBUT.Name = "ShowPassBUT";
            this.ShowPassBUT.Size = new System.Drawing.Size(75, 21);
            this.ShowPassBUT.TabIndex = 11;
            this.ShowPassBUT.Text = "Show";
            this.ShowPassBUT.UseVisualStyleBackColor = true;
            this.ShowPassBUT.Click += new System.EventHandler(this.ShowPassBUT_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 255);
            this.Controls.Add(this.ShowPassBUT);
            this.Controls.Add(this.LoggedInLAB);
            this.Controls.Add(this.LogBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LicenseTB);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegBut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "AFR Monitor Login Window - Patrick Wildschut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox LicenseTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LogBut;
        private System.Windows.Forms.Label LoggedInLAB;
        private System.Windows.Forms.Button ShowPassBUT;
    }
}