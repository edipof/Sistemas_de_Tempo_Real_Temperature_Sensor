namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    partial class ucProductLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_LblProductLine = new System.Windows.Forms.Label();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLabel.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LblProductLine
            // 
            this.m_LblProductLine.AutoSize = true;
            this.m_LblProductLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_LblProductLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblProductLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_LblProductLine.Location = new System.Drawing.Point(3, 12);
            this.m_LblProductLine.Name = "m_LblProductLine";
            this.m_LblProductLine.Size = new System.Drawing.Size(292, 39);
            this.m_LblProductLine.TabIndex = 1;
            this.m_LblProductLine.Text = "m_LblProductLine";
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.m_LblProductLine);
            this.panelLabel.Location = new System.Drawing.Point(-1, -1);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(487, 65);
            this.panelLabel.TabIndex = 2;
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.chartProduct);
            this.panelChart.Location = new System.Drawing.Point(-1, 70);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(491, 180);
            this.panelChart.TabIndex = 3;
            // 
            // chartProduct
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProduct.Legends.Add(legend1);
            this.chartProduct.Location = new System.Drawing.Point(10, 0);
            this.chartProduct.Name = "chartProduct";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProduct.Series.Add(series1);
            this.chartProduct.Size = new System.Drawing.Size(400, 180);
            this.chartProduct.TabIndex = 0;
            this.chartProduct.Text = "chart1";
            // 
            // ucProductLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelLabel);
            this.Name = "ucProductLine";
            this.Size = new System.Drawing.Size(489, 249);
            this.Load += new System.EventHandler(this.ucProductLine_Load);
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_LblProductLine;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
    }
}
