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
    public partial class ucTemperatureSensor : UserControl
    {
        #region Members

        public delegate void TemperatureSensorEventHandler(string text);

        #endregion

        #region Properties

        public string TemperatureLabel
        {
            get
            {
                return m_LblTemperature.Text;
            }

            set
            {
                m_LblTemperature.Text = value;
            }
        }

        #endregion

        #region Constructor
        public ucTemperatureSensor()
        {
            InitializeComponent();
            m_LblTemperature.Text = "0° C";
        }
        #endregion

        #region Events

        private void ucTemperatureSensor_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        #endregion

        #region methods

        public void setLabelTemperature(string e)
        {
            TemperatureLabel = e;
        }

        public void setValorInicialTemperatureSensor()
        {
            if (InvokeRequired)
            {
                this.Invoke(new TemperatureSensorEventHandler(setLabelTemperature), new object[] { 0.ToString() + " ° C" });
                Thread.Sleep(500);
                this.Invoke(new TemperatureSensorEventHandler(setLabelTemperature), new object[] { 500.ToString() + " ° C" });
            }
        }

        #endregion

    }
}
