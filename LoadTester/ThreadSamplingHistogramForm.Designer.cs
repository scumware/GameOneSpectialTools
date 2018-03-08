﻿namespace LoadTester
{
    partial class ThreadSamplingHistogramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThreadSamplingHistogramForm));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Red;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.YellowGreen;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Bisque;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.DarkOliveGreen;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.LimeGreen;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.ForestGreen;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.YellowGreen;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.DarkGreen;
            chartArea1.AxisY.Title = "Iterations";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.YellowGreen;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.ForestGreen;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.Size = new System.Drawing.Size(385, 192);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ThreadSamplingHistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(385, 192);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThreadSamplingHistogramForm";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThreadSamplingHistogramForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer;
    }
}