namespace ComPortReader
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
            this.VCont = new System.Windows.Forms.Button();
            this.BCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VCont
            // 
            this.VCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VCont.Location = new System.Drawing.Point(12, 67);
            this.VCont.Name = "VCont";
            this.VCont.Size = new System.Drawing.Size(166, 54);
            this.VCont.TabIndex = 0;
            this.VCont.Text = "Voice Control";
            this.VCont.UseVisualStyleBackColor = true;
            this.VCont.Click += new System.EventHandler(this.VCont_Click);
            // 
            // BCont
            // 
            this.BCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCont.Location = new System.Drawing.Point(414, 67);
            this.BCont.Name = "BCont";
            this.BCont.Size = new System.Drawing.Size(166, 54);
            this.BCont.TabIndex = 1;
            this.BCont.Text = "Button Control";
            this.BCont.UseVisualStyleBackColor = true;
            this.BCont.Click += new System.EventHandler(this.BCont_Click);
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 192);
            this.Controls.Add(this.BCont);
            this.Controls.Add(this.VCont);
            this.Name = "Starter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Starter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VCont;
        private System.Windows.Forms.Button BCont;
    }
}