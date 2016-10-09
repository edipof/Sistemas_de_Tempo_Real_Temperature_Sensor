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

namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    public partial class frmMain : Form
    {
        #region Members

        private CyclicExecutive m_CyclicExecutive = new CyclicExecutive();
        private ucTemperatureSensor m_ucTemperatureSensor = new ucTemperatureSensor();
  
        //public delegate TemperatureSensorEventHandler();
        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
            m_TemperaturePanel.Controls.Add(m_ucTemperatureSensor);
        }

        #endregion

        #region Events
        #endregion

        #region Methods
        #endregion

    }
}
