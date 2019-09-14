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
            this.ChartReadView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReadView)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartReadView
            // 
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
            this.ChartReadView.Size = new System.Drawing.Size(610, 300);
            this.ChartReadView.TabIndex = 0;
            this.ChartReadView.Text = "chart1";
            this.ChartReadView.DoubleClick += new System.EventHandler(this.ChartReadView_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click chart to view file";
            // 
            // ReadFFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartReadView);
            this.Name = "ReadFFile";
            this.Text = "Read From File - Patrick Wildschut";
            ((System.ComponentModel.ISupportInitialize)(this.ChartReadView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReadView;
        private System.Windows.Forms.Label label1;
    }
}