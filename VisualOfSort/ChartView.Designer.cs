namespace VisualOfSort
{
    partial class ChartView
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
            this.sortChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.sortChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sortChart
            // 
            chartArea1.Name = "ChartArea1";
            this.sortChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.sortChart.Legends.Add(legend1);
            this.sortChart.Location = new System.Drawing.Point(2, 12);
            this.sortChart.Name = "sortChart";
            this.sortChart.Size = new System.Drawing.Size(669, 429);
            this.sortChart.TabIndex = 0;
            this.sortChart.Text = "chart1";
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 473);
            this.Controls.Add(this.sortChart);
            this.Name = "ChartView";
            this.Text = "ChartView";
            ((System.ComponentModel.ISupportInitialize)(this.sortChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sortChart;
    }
}