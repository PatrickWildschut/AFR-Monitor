namespace AFRMonitor
{
    partial class ReadFFile
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadFFile));
            this.ChartReadView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.LowValLab = new System.Windows.Forms.Label();
            this.LowValValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReadView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartReadView
            // 
            this.ChartReadView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ChartReadView.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartReadView.Legends.Add(legend1);
            this.ChartReadView.Location = new System.Drawing.Point(12, 53);
            this.ChartReadView.Name = "ChartReadView";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Value";
            this.ChartReadView.Series.Add(series1);
            this.ChartReadView.Size = new System.Drawing.Size(546, 287);
            this.ChartReadView.TabIndex = 0;
            this.ChartReadView.Text = "chart1";
            this.ChartReadView.DoubleClick += new System.EventHandler(this.ChartReadView_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click chart to view file";
            // 
            // LowValLab
            // 
            this.LowValLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LowValLab.AutoSize = true;
            this.LowValLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowValLab.Location = new System.Drawing.Point(12, 352);
            this.LowValLab.Name = "LowValLab";
            this.LowValLab.Size = new System.Drawing.Size(91, 16);
            this.LowValLab.TabIndex = 2;
            this.LowValLab.Text = "Lowest Value:";
            // 
            // LowValValue
            // 
            this.LowValValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LowValValue.AutoSize = true;
            this.LowValValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowValValue.Location = new System.Drawing.Point(30, 379);
            this.LowValValue.Name = "LowValValue";
            this.LowValValue.Size = new System.Drawing.Size(32, 20);
            this.LowValValue.TabIndex = 3;
            this.LowValValue.Text = "--,-";
            // 
            // ReadFFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 429);
            this.Controls.Add(this.LowValValue);
            this.Controls.Add(this.LowValLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartReadView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadFFile";
            this.Text = "Read From File - Patrick Wildschut";
            ((System.ComponentModel.ISupportInitialize)(this.ChartReadView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReadView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LowValLab;
        private System.Windows.Forms.Label LowValValue;
    }
}