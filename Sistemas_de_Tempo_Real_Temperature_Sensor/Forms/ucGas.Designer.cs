namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    partial class ucGas
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
            this.m_LblPressao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_LblPression
            // 
            this.m_LblPressao.AutoSize = true;
            this.m_LblPressao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.m_LblPressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LblPressao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_LblPressao.Location = new System.Drawing.Point(3, 73);
            this.m_LblPressao.Name = "m_LblPression";
            this.m_LblPressao.Size = new System.Drawing.Size(243, 39);
            this.m_LblPressao.TabIndex = 2;
            this.m_LblPressao.Text = "m_LblPression";
            // 
            // ucGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.m_LblPressao);
            this.Name = "ucGas";
            this.Size = new System.Drawing.Size(308, 196);
            this.Load += new System.EventHandler(this.ucGas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LblPressao;
    }
}
