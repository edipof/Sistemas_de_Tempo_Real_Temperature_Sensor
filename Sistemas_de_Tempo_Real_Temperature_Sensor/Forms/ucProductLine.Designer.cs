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
            this.m_LblProductLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_LblProductLine
            // 
            this.m_LblProductLine.AutoSize = true;
            this.m_LblProductLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_LblProductLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblProductLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_LblProductLine.Location = new System.Drawing.Point(3, 82);
            this.m_LblProductLine.Name = "m_LblProductLine";
            this.m_LblProductLine.Size = new System.Drawing.Size(292, 39);
            this.m_LblProductLine.TabIndex = 1;
            this.m_LblProductLine.Text = "m_LblProductLine";
            // 
            // ucProductLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.m_LblProductLine);
            this.Name = "ucProductLine";
            this.Size = new System.Drawing.Size(489, 249);
            this.Load += new System.EventHandler(this.ucProductLine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblProductLine;
    }
}
