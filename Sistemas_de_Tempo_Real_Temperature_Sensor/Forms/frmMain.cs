using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemas_de_Tempo_Real_Temperature_Sensor.Classes;
using System.Threading;
using static Sistemas_de_Tempo_Real_Temperature_Sensor.Forms.ucTemperatureSensor;

namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    public partial class frmMain : Form
    {
        #region Members

        private CyclicExecutive m_CyclicExecutive = new CyclicExecutive();
        private ucTemperatureSensor m_ucTemperatureSensor = new ucTemperatureSensor();
  
        
        
        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
            m_TemperaturePanel.Controls.Add(m_ucTemperatureSensor);

            Thread m_ThreadSensor = new Thread(atualizaThreadSensor);
            m_ThreadSensor.Start();

        }

        #endregion

        #region Events

        private void atualizaThreadSensor()
        {
            int count = 0;
            while (true)
            {
                count++;
                Thread.Sleep(1000);
                if (m_ucTemperatureSensor.InvokeRequired)
                {
                    this.Invoke(new TemperatureSensorEventHandler(setLabel1), new object[] { count.ToString() + " ° C" });
                }
                else
                {
                    m_ucTemperatureSensor.TemperatureLabel = count.ToString();
                }
            }
        }

        #endregion

        #region Methods

        private void setLabel1(string e)
        {
            m_ucTemperatureSensor.TemperatureLabel = e;
        }
        #endregion

    }
}
