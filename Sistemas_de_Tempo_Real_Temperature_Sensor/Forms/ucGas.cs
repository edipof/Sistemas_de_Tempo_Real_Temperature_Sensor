using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    public partial class ucGas : UserControl
    {
        #region Members

        public delegate void PressiaoControlEventHandler(string text);

        #endregion

        #region Properties

        public string PressaoLabel
        {
            get
            {
                return m_LblPressao.Text;
            }

            set
            {
                m_LblPressao.Text = value;
            }
        }

        #endregion

        #region Constructor

        public ucGas()
        {
            InitializeComponent();
            m_LblPressao.Text = string.Empty;
        }

        #endregion

        #region Events

        private void ucGas_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        #endregion

        #region Methods

        public void setLabelPressao(string e)
        {
            PressaoLabel = e;
        }

        public void setValorInicialPressao()
        {
            if (InvokeRequired)
            {
                Invoke(new PressiaoControlEventHandler(setLabelPressao), new object[] { 0.ToString()});
                Thread.Sleep(100);
                this.Invoke(new PressiaoControlEventHandler(setLabelPressao), new object[] { 100.ToString() + " ° C" });
            }
        }

        #endregion

    }
}
