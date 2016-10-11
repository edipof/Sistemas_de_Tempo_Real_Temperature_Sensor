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
        private ucProductLine m_ucProductLine = new ucProductLine();
        private ucGas m_ucGas = new ucGas();

        Thread sensor;
        Thread producao;
        Thread gas;


        static long m_Temperatura = 500;
        static long m_Produtos = 1;
        static readonly object getTemperaturaLock = new object();
        static readonly object setTemperaturaLock = new object();

        #endregion

        #region Properties

        public long Temperatura
        {
            get
            {
                lock (getTemperaturaLock)
                {
                    if (m_Temperatura == 505)
                    {
                        sensor.Interrupt();
                    }
                    return m_Temperatura;
                }
            }

            set
            {
                lock (setTemperaturaLock)
                {
                    m_Temperatura += value;
                }
            }
        }

        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
            initializeUserControls();
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

        private void atualizaThreadGas()
        {

        }

        private void atualizaThreadLinhaProducao()
        {

        }

        private void m_BtnIniciar_Click(object sender, EventArgs e)
        {
            sensor = new Thread(atualizaThreadSensor);
            producao = new Thread(atualizaThreadGas);
            gas = new Thread(atualizaThreadLinhaProducao);

            sensor.Start();
            producao.Start();
            gas.Start();
        }

        private void m_BtnDesligar_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(Timeout.Infinite);
        }

        #endregion

        #region Methods

        private void setLabel1(string e)
        {
            m_ucTemperatureSensor.TemperatureLabel = e;
        }

        private void initializeUserControls()
        {
            m_TemperaturePanel.Controls.Add(m_ucTemperatureSensor);
            m_PressionPanel.Controls.Add(m_ucGas);
            m_ProductLinePanel.Controls.Add(m_ucProductLine);
        }

        #endregion

    }
}
