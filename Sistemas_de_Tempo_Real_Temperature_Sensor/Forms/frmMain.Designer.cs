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
            this.m_ProductLinePanel = new System.Windows.Forms.Panel();
            this.m_PressionPanel = new System.Windows.Forms.Panel();
            this.m_BbxControls = new System.Windows.Forms.GroupBox();
            this.m_BtnGasDown = new System.Windows.Forms.Button();
            this.m_BtnGasUp = new System.Windows.Forms.Button();
            this.m_lblPressaoGas = new System.Windows.Forms.Label();
            this.m_lblTemperature = new System.Windows.Forms.Label();
            this.m_lblLinhaProducao = new System.Windows.Forms.Label();
            this.m_BtnDesligar = new System.Windows.Forms.Button();
            this.m_BtnIniciar = new System.Windows.Forms.Button();
            this.m_PanelAlert = new System.Windows.Forms.Panel();
            this.m_BbxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_TemperaturePanel
            // 
            this.m_TemperaturePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_TemperaturePanel.Location = new System.Drawing.Point(1, 2);
            this.m_TemperaturePanel.Name = "m_TemperaturePanel";
            this.m_TemperaturePanel.Size = new System.Drawing.Size(334, 177);
            this.m_TemperaturePanel.TabIndex = 0;
            // 
            // m_ProductLinePanel
            // 
            this.m_ProductLinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ProductLinePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_ProductLinePanel.Location = new System.Drawing.Point(494, 2);
            this.m_ProductLinePanel.Name = "m_ProductLinePanel";
            this.m_ProductLinePanel.Size = new System.Drawing.Size(432, 259);
            this.m_ProductLinePanel.TabIndex = 1;
            // 
            // m_PressionPanel
            // 
            this.m_PressionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_PressionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_PressionPanel.Location = new System.Drawing.Point(1, 208);
            this.m_PressionPanel.Name = "m_PressionPanel";
            this.m_PressionPanel.Size = new System.Drawing.Size(334, 168);
            this.m_PressionPanel.TabIndex = 1;
            // 
            // m_BbxControls
            // 
            this.m_BbxControls.Controls.Add(this.m_BtnGasDown);
            this.m_BbxControls.Controls.Add(this.m_BtnGasUp);
            this.m_BbxControls.Location = new System.Drawing.Point(351, 210);
            this.m_BbxControls.Name = "m_BbxControls";
            this.m_BbxControls.Size = new System.Drawing.Size(133, 166);
            this.m_BbxControls.TabIndex = 2;
            this.m_BbxControls.TabStop = false;
            this.m_BbxControls.Text = "Controle de Gás";
            // 
            // m_BtnGasDown
            // 
            this.m_BtnGasDown.Location = new System.Drawing.Point(6, 96);
            this.m_BtnGasDown.Name = "m_BtnGasDown";
            this.m_BtnGasDown.Size = new System.Drawing.Size(121, 45);
            this.m_BtnGasDown.TabIndex = 1;
            this.m_BtnGasDown.Text = "- Pressão";
            this.m_BtnGasDown.UseVisualStyleBackColor = true;
            this.m_BtnGasDown.Click += new System.EventHandler(this.m_BtnGasDown_Click);
            // 
            // m_BtnGasUp
            // 
            this.m_BtnGasUp.Location = new System.Drawing.Point(6, 33);
            this.m_BtnGasUp.Name = "m_BtnGasUp";
            this.m_BtnGasUp.Size = new System.Drawing.Size(121, 45);
            this.m_BtnGasUp.TabIndex = 0;
            this.m_BtnGasUp.Text = "+ Pressão";
            this.m_BtnGasUp.UseVisualStyleBackColor = true;
            this.m_BtnGasUp.Click += new System.EventHandler(this.m_BtnGasUp_Click);
            // 
            // m_lblPressaoGas
            // 
            this.m_lblPressaoGas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblPressaoGas.AutoSize = true;
            this.m_lblPressaoGas.Location = new System.Drawing.Point(133, 382);
            this.m_lblPressaoGas.Name = "m_lblPressaoGas";
            this.m_lblPressaoGas.Size = new System.Drawing.Size(67, 13);
            this.m_lblPressaoGas.TabIndex = 3;
            this.m_lblPressaoGas.Text = "Pressão Gás";
            // 
            // m_lblTemperature
            // 
            this.m_lblTemperature.AutoSize = true;
            this.m_lblTemperature.Location = new System.Drawing.Point(133, 186);
            this.m_lblTemperature.Name = "m_lblTemperature";
            this.m_lblTemperature.Size = new System.Drawing.Size(67, 13);
            this.m_lblTemperature.TabIndex = 4;
            this.m_lblTemperature.Text = "Temperatura";
            // 
            // m_lblLinhaProducao
            // 
            this.m_lblLinhaProducao.AutoSize = true;
            this.m_lblLinhaProducao.Location = new System.Drawing.Point(663, 275);
            this.m_lblLinhaProducao.Name = "m_lblLinhaProducao";
            this.m_lblLinhaProducao.Size = new System.Drawing.Size(97, 13);
            this.m_lblLinhaProducao.TabIndex = 5;
            this.m_lblLinhaProducao.Text = "Linha de Produção";
            // 
            // m_BtnDesligar
            // 
            this.m_BtnDesligar.Location = new System.Drawing.Point(717, 331);
            this.m_BtnDesligar.Name = "m_BtnDesligar";
            this.m_BtnDesligar.Size = new System.Drawing.Size(121, 45);
            this.m_BtnDesligar.TabIndex = 6;
            this.m_BtnDesligar.Text = "Desligar";
            this.m_BtnDesligar.UseVisualStyleBackColor = true;
            this.m_BtnDesligar.Click += new System.EventHandler(this.m_BtnDesligar_Click);
            // 
            // m_BtnIniciar
            // 
            this.m_BtnIniciar.Location = new System.Drawing.Point(578, 331);
            this.m_BtnIniciar.Name = "m_BtnIniciar";
            this.m_BtnIniciar.Size = new System.Drawing.Size(121, 45);
            this.m_BtnIniciar.TabIndex = 7;
            this.m_BtnIniciar.Text = "Iniciar";
            this.m_BtnIniciar.UseVisualStyleBackColor = true;
            this.m_BtnIniciar.Click += new System.EventHandler(this.m_BtnIniciar_Click);
            // 
            // m_PanelAlert
            // 
            this.m_PanelAlert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PanelAlert.Location = new System.Drawing.Point(351, 51);
            this.m_PanelAlert.Name = "m_PanelAlert";
            this.m_PanelAlert.Size = new System.Drawing.Size(133, 73);
            this.m_PanelAlert.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(938, 400);
            this.Controls.Add(this.m_PanelAlert);
            this.Controls.Add(this.m_BtnIniciar);
            this.Controls.Add(this.m_BtnDesligar);
            this.Controls.Add(this.m_lblLinhaProducao);
            this.Controls.Add(this.m_lblTemperature);
            this.Controls.Add(this.m_lblPressaoGas);
            this.Controls.Add(this.m_BbxControls);
            this.Controls.Add(this.m_PressionPanel);
            this.Controls.Add(this.m_ProductLinePanel);
            this.Controls.Add(this.m_TemperaturePanel);
            this.Name = "frmMain";
            this.Text = "Supervisório Produção";
            this.m_BbxControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel m_TemperaturePanel;
        private System.Windows.Forms.Panel m_ProductLinePanel;
        private System.Windows.Forms.Panel m_PressionPanel;
        private System.Windows.Forms.GroupBox m_BbxControls;
        private System.Windows.Forms.Label m_lblPressaoGas;
        private System.Windows.Forms.Label m_lblTemperature;
        private System.Windows.Forms.Label m_lblLinhaProducao;
        private System.Windows.Forms.Button m_BtnGasDown;
        private System.Windows.Forms.Button m_BtnGasUp;
        private System.Windows.Forms.Button m_BtnDesligar;
        private System.Windows.Forms.Button m_BtnIniciar;
        private System.Windows.Forms.Panel m_PanelAlert;
    }
}