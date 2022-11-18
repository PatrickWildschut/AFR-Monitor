namespace AFRMonitor
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LicenseTB = new System.Windows.Forms.TextBox();
            this.CarNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTB = new System.Windows.Forms.TextBox();
            this.CompleteBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ReqLicenseCB = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "License Plate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Car Name: (this will be displayed)";
            // 
            // LicenseTB
            // 
            this.LicenseTB.Location = new System.Drawing.Point(15, 158);
            this.LicenseTB.MaxLength = 25;
            this.LicenseTB.Name = "LicenseTB";
            this.LicenseTB.Size = new System.Drawing.Size(198, 20);
            this.LicenseTB.TabIndex = 18;
            // 
            // CarNameTB
            // 
            this.CarNameTB.Location = new System.Drawing.Point(15, 119);
            this.CarNameTB.MaxLength = 25;
            this.CarNameTB.Name = "CarNameTB";
            this.CarNameTB.Size = new System.Drawing.Size(198, 20);
            this.CarNameTB.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "AFR Monitor Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Full Name:";
            // 
            // FullNameTB
            // 
            this.FullNameTB.Location = new System.Drawing.Point(15, 80);
            this.FullNameTB.MaxLength = 25;
            this.FullNameTB.Name = "FullNameTB";
            this.FullNameTB.Size = new System.Drawing.Size(198, 20);
            this.FullNameTB.TabIndex = 23;
            // 
            // CompleteBut
            // 
            this.CompleteBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CompleteBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteBut.Location = new System.Drawing.Point(177, 238);
            this.CompleteBut.Name = "CompleteBut";
            this.CompleteBut.Size = new System.Drawing.Size(205, 44);
            this.CompleteBut.TabIndex = 25;
            this.CompleteBut.Text = "Complete setup";
            this.CompleteBut.UseVisualStyleBackColor = true;
            this.CompleteBut.Click += new System.EventHandler(this.ReqBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 103);
            this.label3.MaximumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 39);
            this.label3.TabIndex = 26;
            this.label3.Text = "Before you can use this program, you need to fill in this. ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReqLicenseCB
            // 
            this.ReqLicenseCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReqLicenseCB.AutoSize = true;
            this.ReqLicenseCB.Location = new System.Drawing.Point(46, 235);
            this.ReqLicenseCB.Name = "ReqLicenseCB";
            this.ReqLicenseCB.Size = new System.Drawing.Size(106, 17);
            this.ReqLicenseCB.TabIndex = 27;
            this.ReqLicenseCB.Text = "Request License";
            this.ReqLicenseCB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 196);
            this.label7.MaximumSize = new System.Drawing.Size(200, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Do you want to request a full access license?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 294);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReqLicenseCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CompleteBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LicenseTB);
            this.Controls.Add(this.CarNameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.Text = "Setup AFR Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LicenseTB;
        private System.Windows.Forms.TextBox CarNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameTB;
        private System.Windows.Forms.Button CompleteBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ReqLicenseCB;
        private System.Windows.Forms.Label label7;
    }
}