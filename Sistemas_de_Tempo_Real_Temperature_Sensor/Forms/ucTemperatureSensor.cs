using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    public partial class ucTemperatureSensor : UserControl
    {
        public delegate void TemperatureSensorEventHandler(string text);


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

        public ucTemperatureSensor()
        {
            InitializeComponent();
            m_LblTemperature.Text = "0° C";
        }

        private void ucTemperatureSensor_Load(object sender, EventArgs e)
        {

        }

    }
}
