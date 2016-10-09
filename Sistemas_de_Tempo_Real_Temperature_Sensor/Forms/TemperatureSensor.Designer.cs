namespace Sistemas_de_Tempo_Real_Temperature_Sensor
{
    partial class TemperatureSensor
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
            this.tempteader = new System.Windows.Forms.Button();
            this.labeltemp = new System.Windows.Forms.Label();
            this.labelconnection = new System.Windows.Forms.Label();
            this.tempreader = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tempteader
            // 
            this.tempteader.Location = new System.Drawing.Point(175, 204);
            this.tempteader.Name = "tempteader";
            this.tempteader.Size = new System.Drawing.Size(97, 28);
            this.tempteader.TabIndex = 0;
            this.tempteader.Text = "Read Temp";
            this.tempteader.UseVisualStyleBackColor = true;
            tempteader.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeltemp.Location = new System.Drawing.Point(31, 52);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(0, 73);
            this.labeltemp.TabIndex = 1;
            // 
            // labelconnection
            // 
            this.labelconnection.AutoSize = true;
            this.labelconnection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelconnection.Location = new System.Drawing.Point(13, 237);
            this.labelconnection.Name = "labelconnection";
            this.labelconnection.Size = new System.Drawing.Size(0, 13);
            this.labelconnection.TabIndex = 2;
            // 
            // tempreader
            // 
            this.tempreader.Tick += new System.EventHandler(this.tempreader_Tick);
            // 
            // tempreaderform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelconnection);
            this.Controls.Add(this.labeltemp);
            this.Controls.Add(this.tempteader);
            this.Name = "tempreaderform";
            this.Text = "Temperature Reader";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion
        private System.Windows.Forms.Button tempteader;
        private System.Windows.Forms.Label labeltemp;
        private System.Windows.Forms.Label labelconnection;
        private System.Windows.Forms.Timer tempreader;
    }
}

