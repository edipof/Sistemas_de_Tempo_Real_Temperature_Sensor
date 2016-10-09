namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    partial class frmMain
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
            this.m_TemperaturePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // m_TemperaturePanel
            // 
            this.m_TemperaturePanel.Location = new System.Drawing.Point(1, 2);
            this.m_TemperaturePanel.Name = "m_TemperaturePanel";
            this.m_TemperaturePanel.Size = new System.Drawing.Size(361, 202);
            this.m_TemperaturePanel.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 400);
            this.Controls.Add(this.m_TemperaturePanel);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_TemperaturePanel;
    }
}