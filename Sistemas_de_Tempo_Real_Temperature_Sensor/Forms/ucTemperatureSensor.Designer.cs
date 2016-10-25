namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    partial class ucTemperatureSensor
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
            this.m_LblTemperature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_LblTemperature
            // 
            this.m_LblTemperature.AutoSize = true;
            this.m_LblTemperature.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_LblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblTemperature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_LblTemperature.Location = new System.Drawing.Point(41, 58);
            this.m_LblTemperature.Name = "m_LblTemperature";
            this.m_LblTemperature.Size = new System.Drawing.Size(274, 76);
            this.m_LblTemperature.TabIndex = 0;
            this.m_LblTemperature.Text = "1000° C";
            // 
            // ucTemperatureSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.m_LblTemperature);
            this.Name = "ucTemperatureSensor";
            this.Size = new System.Drawing.Size(223, 193);
            this.Load += new System.EventHandler(this.ucTemperatureSensor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblTemperature;
    }
}
