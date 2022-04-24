
namespace GUI
{
    partial class frmAnalysis
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
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvChart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chartIncome
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIncome.Legends.Add(legend1);
            this.chartIncome.Location = new System.Drawing.Point(276, 31);
            this.chartIncome.Name = "chartIncome";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartIncome.Series.Add(series1);
            this.chartIncome.Size = new System.Drawing.Size(618, 482);
            this.chartIncome.TabIndex = 0;
            this.chartIncome.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgvChart);
            this.panel1.Location = new System.Drawing.Point(11, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 482);
            this.panel1.TabIndex = 1;
            // 
            // dtgvChart
            // 
            this.dtgvChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChart.Location = new System.Drawing.Point(4, 7);
            this.dtgvChart.Name = "dtgvChart";
            this.dtgvChart.RowHeadersWidth = 51;
            this.dtgvChart.RowTemplate.Height = 24;
            this.dtgvChart.Size = new System.Drawing.Size(234, 473);
            this.dtgvChart.TabIndex = 0;
            // 
            // frmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartIncome);
            this.Name = "frmAnalysis";
            this.Text = "frmAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvChart;
    }
}