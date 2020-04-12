namespace AFRMonitor
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label2 = new System.Windows.Forms.Label();
            this.ReqBut = new System.Windows.Forms.Button();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.BrandTB = new System.Windows.Forms.TextBox();
            this.TypeTB = new System.Windows.Forms.TextBox();
            this.LicenseTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FullNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Register";
            // 
            // ReqBut
            // 
            this.ReqBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReqBut.Location = new System.Drawing.Point(301, 271);
            this.ReqBut.Name = "ReqBut";
            this.ReqBut.Size = new System.Drawing.Size(205, 44);
            this.ReqBut.TabIndex = 4;
            this.ReqBut.Text = "Request License";
            this.ReqBut.UseVisualStyleBackColor = true;
            this.ReqBut.Click += new System.EventHandler(this.ReqBut_Click);
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(31, 128);
            this.MailTB.MaxLength = 50;
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(198, 20);
            this.MailTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mail Address:";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(31, 167);
            this.PassTB.MaxLength = 15;
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(198, 20);
            this.PassTB.TabIndex = 8;
            // 
            // BrandTB
            // 
            this.BrandTB.Location = new System.Drawing.Point(31, 206);
            this.BrandTB.MaxLength = 25;
            this.BrandTB.Name = "BrandTB";
            this.BrandTB.Size = new System.Drawing.Size(198, 20);
            this.BrandTB.TabIndex = 9;
            // 
            // TypeTB
            // 
            this.TypeTB.Location = new System.Drawing.Point(31, 245);
            this.TypeTB.MaxLength = 100;
            this.TypeTB.Name = "TypeTB";
            this.TypeTB.Size = new System.Drawing.Size(198, 20);
            this.TypeTB.TabIndex = 10;
            // 
            // LicenseTB
            // 
            this.LicenseTB.Location = new System.Drawing.Point(31, 284);
            this.LicenseTB.MaxLength = 25;
            this.LicenseTB.Name = "LicenseTB";
            this.LicenseTB.Size = new System.Drawing.Size(198, 20);
            this.LicenseTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Car Brand:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Car Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "License Plate (with dashes):";
            // 
            // FullNameTB
            // 
            this.FullNameTB.Location = new System.Drawing.Point(31, 89);
            this.FullNameTB.MaxLength = 50;
            this.FullNameTB.Name = "FullNameTB";
            this.FullNameTB.Size = new System.Drawing.Size(198, 20);
            this.FullNameTB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Full Name:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 327);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FullNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LicenseTB);
            this.Controls.Add(this.TypeTB);
            this.Controls.Add(this.BrandTB);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.ReqBut);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReqBut;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox BrandTB;
        private System.Windows.Forms.TextBox TypeTB;
        private System.Windows.Forms.TextBox LicenseTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FullNameTB;
        private System.Windows.Forms.Label label7;
    }
}