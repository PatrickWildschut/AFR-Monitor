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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadFFile));
            this.ChartReadView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReadFromFileRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleSampleCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LowValLab = new System.Windows.Forms.Label();
            this.LowValValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TTRT = new System.Windows.Forms.Label();
            this.TTRTValue = new System.Windows.Forms.Label();
            this.SamplesLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BoostLAB = new System.Windows.Forms.Label();
            this.DateTimeLAB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReadView)).BeginInit();
            this.ReadFromFileRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartReadView
            // 
            this.ChartReadView.AllowDrop = true;
            this.ChartReadView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ChartReadView.ChartAreas.Add(chartArea1);
            this.ChartReadView.ContextMenuStrip = this.ReadFromFileRightClick;
            legend1.Name = "Legend1";
            this.ChartReadView.Legends.Add(legend1);
            this.ChartReadView.Location = new System.Drawing.Point(12, 36);
            this.ChartReadView.Name = "ChartReadView";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Value";
            this.ChartReadView.Series.Add(series1);
            this.ChartReadView.Size = new System.Drawing.Size(812, 323);
            this.ChartReadView.TabIndex = 0;
            this.ChartReadView.Text = "chart1";
            this.ChartReadView.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChartReadView_DragDrop);
            this.ChartReadView.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChartReadView_DragEnter);
            // 
            // ReadFromFileRightClick
            // 
            this.ReadFromFileRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleValuesToolStripMenuItem,
            this.replayFileToolStripMenuItem,
            this.toggleSampleCountToolStripMenuItem});
            this.ReadFromFileRightClick.Name = "ReadFromFileRightClick";
            this.ReadFromFileRightClick.Size = new System.Drawing.Size(188, 70);
            // 
            // toggleValuesToolStripMenuItem
            // 
            this.toggleValuesToolStripMenuItem.Name = "toggleValuesToolStripMenuItem";
            this.toggleValuesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.toggleValuesToolStripMenuItem.Text = "Toggle Values";
            this.toggleValuesToolStripMenuItem.Click += new System.EventHandler(this.toggleValuesToolStripMenuItem_Click);
            // 
            // replayFileToolStripMenuItem
            // 
            this.replayFileToolStripMenuItem.Name = "replayFileToolStripMenuItem";
            this.replayFileToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.replayFileToolStripMenuItem.Text = "Replay File";
            this.replayFileToolStripMenuItem.Click += new System.EventHandler(this.replayFileToolStripMenuItem_Click);
            // 
            // toggleSampleCountToolStripMenuItem
            // 
            this.toggleSampleCountToolStripMenuItem.Name = "toggleSampleCountToolStripMenuItem";
            this.toggleSampleCountToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.toggleSampleCountToolStripMenuItem.Text = "Toggle Sample Count";
            this.toggleSampleCountToolStripMenuItem.Click += new System.EventHandler(this.toggleSampleCountToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Right click chart for extra tools";
            // 
            // LowValLab
            // 
            this.LowValLab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LowValLab.AutoSize = true;
            this.LowValLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowValLab.Location = new System.Drawing.Point(9, 362);
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
            this.LowValValue.Location = new System.Drawing.Point(27, 388);
            this.LowValValue.Name = "LowValValue";
            this.LowValValue.Size = new System.Drawing.Size(32, 20);
            this.LowValValue.TabIndex = 3;
            this.LowValValue.Text = "--,-";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Drop file on chart to compare";
            // 
            // TTRT
            // 
            this.TTRT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TTRT.AutoSize = true;
            this.TTRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTRT.Location = new System.Drawing.Point(729, 363);
            this.TTRT.Name = "TTRT";
            this.TTRT.Size = new System.Drawing.Size(87, 15);
            this.TTRT.TabIndex = 5;
            this.TTRT.Text = "Total Runtime:";
            // 
            // TTRTValue
            // 
            this.TTRTValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TTRTValue.AutoSize = true;
            this.TTRTValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTRTValue.Location = new System.Drawing.Point(732, 388);
            this.TTRTValue.Name = "TTRTValue";
            this.TTRTValue.Size = new System.Drawing.Size(65, 20);
            this.TTRTValue.TabIndex = 6;
            this.TTRTValue.Text = "--,- sec";
            // 
            // SamplesLab
            // 
            this.SamplesLab.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SamplesLab.AutoSize = true;
            this.SamplesLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamplesLab.Location = new System.Drawing.Point(376, 344);
            this.SamplesLab.Name = "SamplesLab";
            this.SamplesLab.Size = new System.Drawing.Size(70, 15);
            this.SamplesLab.TabIndex = 7;
            this.SamplesLab.Text = "Time in sec";
            this.SamplesLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "AFR";
            // 
            // BoostLAB
            // 
            this.BoostLAB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BoostLAB.AutoSize = true;
            this.BoostLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoostLAB.Location = new System.Drawing.Point(356, 407);
            this.BoostLAB.Name = "BoostLAB";
            this.BoostLAB.Size = new System.Drawing.Size(131, 13);
            this.BoostLAB.TabIndex = 10;
            this.BoostLAB.Text = "High Boost (383 BHP)";
            // 
            // DateTimeLAB
            // 
            this.DateTimeLAB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DateTimeLAB.AutoSize = true;
            this.DateTimeLAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLAB.Location = new System.Drawing.Point(331, 18);
            this.DateTimeLAB.Name = "DateTimeLAB";
            this.DateTimeLAB.Size = new System.Drawing.Size(22, 15);
            this.DateTimeLAB.TabIndex = 11;
            this.DateTimeLAB.Text = "---";
            this.DateTimeLAB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadFFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 429);
            this.Controls.Add(this.DateTimeLAB);
            this.Controls.Add(this.BoostLAB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SamplesLab);
            this.Controls.Add(this.TTRTValue);
            this.Controls.Add(this.TTRT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LowValValue);
            this.Controls.Add(this.LowValLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartReadView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadFFile";
            this.Text = "Read From File - Patrick Wildschut";
            ((System.ComponentModel.ISupportInitialize)(this.ChartReadView)).EndInit();
            this.ReadFromFileRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReadView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LowValLab;
        private System.Windows.Forms.Label LowValValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TTRT;
        private System.Windows.Forms.Label TTRTValue;
        private System.Windows.Forms.Label SamplesLab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BoostLAB;
        private System.Windows.Forms.ContextMenuStrip ReadFromFileRightClick;
        private System.Windows.Forms.ToolStripMenuItem toggleValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replayFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleSampleCountToolStripMenuItem;
        private System.Windows.Forms.Label DateTimeLAB;
    }
}