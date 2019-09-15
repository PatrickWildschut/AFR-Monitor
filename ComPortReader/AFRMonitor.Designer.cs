namespace AFRMonitor
{
    partial class AFRMonitor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AFRMonitor));
            this.SerialP = new System.IO.Ports.SerialPort(this.components);
            this.ComSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StBut = new System.Windows.Forms.Button();
            this.ReBut = new System.Windows.Forms.Button();
            this.CurLab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RichOrLean = new System.Windows.Forms.ProgressBar();
            this.Lean = new System.Windows.Forms.Label();
            this.Rich = new System.Windows.Forms.Label();
            this.ChartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LowValLab = new System.Windows.Forms.Label();
            this.LowValueValue = new System.Windows.Forms.Label();
            this.STFB = new System.Windows.Forms.Button();
            this.RTB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComSelector
            // 
            this.ComSelector.FormattingEnabled = true;
            this.ComSelector.Location = new System.Drawing.Point(16, 32);
            this.ComSelector.Name = "ComSelector";
            this.ComSelector.Size = new System.Drawing.Size(121, 21);
            this.ComSelector.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select:";
            // 
            // StBut
            // 
            this.StBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StBut.Location = new System.Drawing.Point(237, 9);
            this.StBut.Name = "StBut";
            this.StBut.Size = new System.Drawing.Size(127, 44);
            this.StBut.TabIndex = 2;
            this.StBut.Text = "Start";
            this.StBut.UseVisualStyleBackColor = true;
            this.StBut.Click += new System.EventHandler(this.StBut_Click);
            // 
            // ReBut
            // 
            this.ReBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReBut.Location = new System.Drawing.Point(143, 9);
            this.ReBut.Name = "ReBut";
            this.ReBut.Size = new System.Drawing.Size(84, 44);
            this.ReBut.TabIndex = 3;
            this.ReBut.Text = "Refresh";
            this.ReBut.UseVisualStyleBackColor = true;
            this.ReBut.Click += new System.EventHandler(this.ReBut_Click);
            // 
            // CurLab
            // 
            this.CurLab.AutoSize = true;
            this.CurLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurLab.Location = new System.Drawing.Point(441, 59);
            this.CurLab.Name = "CurLab";
            this.CurLab.Size = new System.Drawing.Size(117, 55);
            this.CurLab.TabIndex = 4;
            this.CurLab.Text = "O_o";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Value:";
            // 
            // RichOrLean
            // 
            this.RichOrLean.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichOrLean.Location = new System.Drawing.Point(51, 193);
            this.RichOrLean.Maximum = 200;
            this.RichOrLean.Minimum = 100;
            this.RichOrLean.Name = "RichOrLean";
            this.RichOrLean.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RichOrLean.Size = new System.Drawing.Size(507, 52);
            this.RichOrLean.TabIndex = 6;
            this.RichOrLean.Value = 100;
            // 
            // Lean
            // 
            this.Lean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lean.AutoSize = true;
            this.Lean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lean.Location = new System.Drawing.Point(12, 213);
            this.Lean.Name = "Lean";
            this.Lean.Size = new System.Drawing.Size(35, 13);
            this.Lean.TabIndex = 7;
            this.Lean.Text = "Lean";
            // 
            // Rich
            // 
            this.Rich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rich.AutoSize = true;
            this.Rich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rich.Location = new System.Drawing.Point(564, 213);
            this.Rich.Name = "Rich";
            this.Rich.Size = new System.Drawing.Size(33, 13);
            this.Rich.TabIndex = 8;
            this.Rich.Text = "Rich";
            // 
            // ChartView
            // 
            this.ChartView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartValue";
            this.ChartView.ChartAreas.Add(chartArea1);
            this.ChartView.Location = new System.Drawing.Point(51, 284);
            this.ChartView.Name = "ChartView";
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartValue";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Name = "Value";
            this.ChartView.Series.Add(series1);
            this.ChartView.Size = new System.Drawing.Size(507, 300);
            this.ChartView.TabIndex = 9;
            this.ChartView.Text = "Values";
            // 
            // LowValLab
            // 
            this.LowValLab.AutoSize = true;
            this.LowValLab.Location = new System.Drawing.Point(13, 75);
            this.LowValLab.Name = "LowValLab";
            this.LowValLab.Size = new System.Drawing.Size(74, 13);
            this.LowValLab.TabIndex = 10;
            this.LowValLab.Text = "Lowest Value:";
            // 
            // LowValueValue
            // 
            this.LowValueValue.AutoSize = true;
            this.LowValueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowValueValue.Location = new System.Drawing.Point(25, 111);
            this.LowValueValue.Name = "LowValueValue";
            this.LowValueValue.Size = new System.Drawing.Size(47, 29);
            this.LowValueValue.TabIndex = 11;
            this.LowValueValue.Text = "--,-";
            // 
            // STFB
            // 
            this.STFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STFB.Location = new System.Drawing.Point(280, 75);
            this.STFB.Name = "STFB";
            this.STFB.Size = new System.Drawing.Size(84, 44);
            this.STFB.TabIndex = 12;
            this.STFB.Text = "Save To File";
            this.STFB.UseVisualStyleBackColor = true;
            this.STFB.Click += new System.EventHandler(this.STFB_Click);
            // 
            // RTB
            // 
            this.RTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB.Location = new System.Drawing.Point(190, 75);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(84, 44);
            this.RTB.TabIndex = 13;
            this.RTB.Text = "Reset";
            this.RTB.UseVisualStyleBackColor = true;
            this.RTB.Click += new System.EventHandler(this.RTB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "14,7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "|";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "11,8";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "|";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(516, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "10,5";
            // 
            // AFRMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 596);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.STFB);
            this.Controls.Add(this.LowValueValue);
            this.Controls.Add(this.LowValLab);
            this.Controls.Add(this.ChartView);
            this.Controls.Add(this.Rich);
            this.Controls.Add(this.Lean);
            this.Controls.Add(this.RichOrLean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CurLab);
            this.Controls.Add(this.ReBut);
            this.Controls.Add(this.StBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComSelector);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AFRMonitor";
            this.Text = "Air Fuel Ratio Monitor - Patrick Wildschut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ChartView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialP;
        private System.Windows.Forms.ComboBox ComSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StBut;
        private System.Windows.Forms.Button ReBut;
        private System.Windows.Forms.Label CurLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar RichOrLean;
        private System.Windows.Forms.Label Lean;
        private System.Windows.Forms.Label Rich;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartView;
        private System.Windows.Forms.Label LowValLab;
        private System.Windows.Forms.Label LowValueValue;
        private System.Windows.Forms.Button STFB;
        private System.Windows.Forms.Button RTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

