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
            this.SelectLab = new System.Windows.Forms.Label();
            this.StBut = new System.Windows.Forms.Button();
            this.ReBut = new System.Windows.Forms.Button();
            this.CurLab = new System.Windows.Forms.Label();
            this.CurValLab = new System.Windows.Forms.Label();
            this.RichOrLean = new System.Windows.Forms.ProgressBar();
            this.Lean = new System.Windows.Forms.Label();
            this.Rich = new System.Windows.Forms.Label();
            this.ChartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LowValLab = new System.Windows.Forms.Label();
            this.LowValueValue = new System.Windows.Forms.Label();
            this.STFB = new System.Windows.Forms.Button();
            this.RTB = new System.Windows.Forms.Button();
            this.FourteenSaveLab = new System.Windows.Forms.Label();
            this.FourteenLab = new System.Windows.Forms.Label();
            this.ElevenSaveLab = new System.Windows.Forms.Label();
            this.ElevenLab = new System.Windows.Forms.Label();
            this.TenSaveLab = new System.Windows.Forms.Label();
            this.TenLab = new System.Windows.Forms.Label();
            this.LowestValueToolTip = new System.Windows.Forms.ToolTip(this.components);
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
            // SelectLab
            // 
            this.SelectLab.AutoSize = true;
            this.SelectLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLab.Location = new System.Drawing.Point(13, 13);
            this.SelectLab.Name = "SelectLab";
            this.SelectLab.Size = new System.Drawing.Size(49, 16);
            this.SelectLab.TabIndex = 1;
            this.SelectLab.Text = "Select:";
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
            this.CurLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurLab.AutoSize = true;
            this.CurLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurLab.Location = new System.Drawing.Point(439, 59);
            this.CurLab.Name = "CurLab";
            this.CurLab.Size = new System.Drawing.Size(117, 55);
            this.CurLab.TabIndex = 4;
            this.CurLab.Text = "O_o";
            // 
            // CurValLab
            // 
            this.CurValLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurValLab.AutoSize = true;
            this.CurValLab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CurValLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurValLab.Location = new System.Drawing.Point(442, 13);
            this.CurValLab.Name = "CurValLab";
            this.CurValLab.Size = new System.Drawing.Size(125, 20);
            this.CurValLab.TabIndex = 5;
            this.CurValLab.Text = "Current Value:";
            // 
            // RichOrLean
            // 
            this.RichOrLean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.Lean.Location = new System.Drawing.Point(10, 213);
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
            this.LowValueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowValueValue.Location = new System.Drawing.Point(25, 111);
            this.LowValueValue.Name = "LowValueValue";
            this.LowValueValue.Size = new System.Drawing.Size(57, 33);
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
            // FourteenSaveLab
            // 
            this.FourteenSaveLab.AutoSize = true;
            this.FourteenSaveLab.Location = new System.Drawing.Point(315, 177);
            this.FourteenSaveLab.Name = "FourteenSaveLab";
            this.FourteenSaveLab.Size = new System.Drawing.Size(9, 13);
            this.FourteenSaveLab.TabIndex = 14;
            this.FourteenSaveLab.Text = "|";
            // 
            // FourteenLab
            // 
            this.FourteenLab.AutoSize = true;
            this.FourteenLab.Location = new System.Drawing.Point(305, 164);
            this.FourteenLab.Name = "FourteenLab";
            this.FourteenLab.Size = new System.Drawing.Size(28, 13);
            this.FourteenLab.TabIndex = 15;
            this.FourteenLab.Text = "14,7";
            // 
            // ElevenSaveLab
            // 
            this.ElevenSaveLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ElevenSaveLab.AutoSize = true;
            this.ElevenSaveLab.Location = new System.Drawing.Point(461, 177);
            this.ElevenSaveLab.Name = "ElevenSaveLab";
            this.ElevenSaveLab.Size = new System.Drawing.Size(9, 13);
            this.ElevenSaveLab.TabIndex = 16;
            this.ElevenSaveLab.Text = "|";
            // 
            // ElevenLab
            // 
            this.ElevenLab.AutoSize = true;
            this.ElevenLab.Location = new System.Drawing.Point(448, 164);
            this.ElevenLab.Name = "ElevenLab";
            this.ElevenLab.Size = new System.Drawing.Size(28, 13);
            this.ElevenLab.TabIndex = 17;
            this.ElevenLab.Text = "11,8";
            // 
            // TenSaveLab
            // 
            this.TenSaveLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TenSaveLab.AutoSize = true;
            this.TenSaveLab.Location = new System.Drawing.Point(526, 177);
            this.TenSaveLab.Name = "TenSaveLab";
            this.TenSaveLab.Size = new System.Drawing.Size(9, 13);
            this.TenSaveLab.TabIndex = 18;
            this.TenSaveLab.Text = "|";
            // 
            // TenLab
            // 
            this.TenLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TenLab.AutoSize = true;
            this.TenLab.Location = new System.Drawing.Point(516, 164);
            this.TenLab.Name = "TenLab";
            this.TenLab.Size = new System.Drawing.Size(28, 13);
            this.TenLab.TabIndex = 19;
            this.TenLab.Text = "10,5";
            // 
            // AFRMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 596);
            this.Controls.Add(this.TenLab);
            this.Controls.Add(this.TenSaveLab);
            this.Controls.Add(this.ElevenLab);
            this.Controls.Add(this.ElevenSaveLab);
            this.Controls.Add(this.FourteenLab);
            this.Controls.Add(this.FourteenSaveLab);
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.STFB);
            this.Controls.Add(this.LowValueValue);
            this.Controls.Add(this.LowValLab);
            this.Controls.Add(this.ChartView);
            this.Controls.Add(this.Rich);
            this.Controls.Add(this.Lean);
            this.Controls.Add(this.RichOrLean);
            this.Controls.Add(this.CurValLab);
            this.Controls.Add(this.CurLab);
            this.Controls.Add(this.ReBut);
            this.Controls.Add(this.StBut);
            this.Controls.Add(this.SelectLab);
            this.Controls.Add(this.ComSelector);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AFRMonitor";
            this.Text = "Air Fuel Ratio Monitor - Patrick Wildschut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.SizeChanged += new System.EventHandler(this.AFRMonitor_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ChartView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialP;
        private System.Windows.Forms.ComboBox ComSelector;
        private System.Windows.Forms.Label SelectLab;
        private System.Windows.Forms.Button StBut;
        private System.Windows.Forms.Button ReBut;
        private System.Windows.Forms.Label CurLab;
        private System.Windows.Forms.Label CurValLab;
        private System.Windows.Forms.ProgressBar RichOrLean;
        private System.Windows.Forms.Label Lean;
        private System.Windows.Forms.Label Rich;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartView;
        private System.Windows.Forms.Label LowValLab;
        private System.Windows.Forms.Label LowValueValue;
        private System.Windows.Forms.Button STFB;
        private System.Windows.Forms.Button RTB;
        private System.Windows.Forms.Label FourteenSaveLab;
        private System.Windows.Forms.Label FourteenLab;
        private System.Windows.Forms.Label ElevenSaveLab;
        private System.Windows.Forms.Label ElevenLab;
        private System.Windows.Forms.Label TenSaveLab;
        private System.Windows.Forms.Label TenLab;
        private System.Windows.Forms.ToolTip LowestValueToolTip;
    }
}

