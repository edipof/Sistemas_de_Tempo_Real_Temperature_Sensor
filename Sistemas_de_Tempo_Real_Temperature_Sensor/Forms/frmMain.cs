using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static Sistemas_de_Tempo_Real_Temperature_Sensor.Forms.ucTemperatureSensor;
using static Sistemas_de_Tempo_Real_Temperature_Sensor.Forms.ucGas;

namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    public partial class frmMain : Form
    {
        #region Members

        #region UserControl
        private ucTemperatureSensor m_ucTemperatureSensor = new ucTemperatureSensor();
        private ucProductLine m_ucProductLine = new ucProductLine();
        private ucGas m_ucGas = new ucGas();
        #endregion

        #region Thread
        private Thread ThreadSensor;
        private Thread ThreadProducao;
        private Thread ThreadGas;
        #endregion

        #region Lock
        private static readonly object getTemperaturaLock = new object();
        private static readonly object setTemperaturaLock = new object();
        private static readonly object getPressaoLock = new object();
        private static readonly object setPressaoLock = new object();
        private static readonly object getProdutosLock = new object();
        private static readonly object setProdutosLock = new object();
        #endregion

        #region Timer
        private int m_TempoProducao = 2000;
        private int m_TempoPressao = 10000;
        private int m_TempoTemperatura = 10000;
        #endregion

        #region Count
        private static long m_Temperatura = 500;
        private static long m_Produtos = 0;
        private static long m_Pression = 0;
        #endregion

        #endregion

        #region Properties
        //Metodos Get e Set

        public long Temperatura
        {
            get
            {
                lock (getTemperaturaLock)
                {
                    return m_Temperatura;
                }
            }

            set
            {
                lock (setTemperaturaLock)
                {
                    m_Temperatura = (m_Temperatura + value < 0 ? 0 : m_Temperatura + value);
                }
            }
        }

        public static long Produtos
        {
            get
            {
                lock (getProdutosLock)
                {
                    return m_Produtos;
                }
            }

            set
            {
                lock (setProdutosLock)
                {
                    m_Produtos += value;
                }
            }
        }

        public static long Pressao
        {
            get
            {
                lock (getPressaoLock)
                {
                    return m_Pression;
                }
            }

            set
            {
                lock (setPressaoLock)
                {
                    m_Pression += value;
                }
            }
        }

        public int TempoProducao
        {
            get
            {
                return m_TempoProducao;
            }

            set
            {
                m_TempoProducao = (m_TempoProducao + value <= 0 ? 1000 : m_TempoProducao + value);
            }
        }

        public int TempoPressao
        {
            get
            {
                return m_TempoPressao;
            }

            set
            {
                m_TempoPressao += value;
            }
        }

        public int TempoTemperatura
        {
            get
            {
                return m_TempoTemperatura;
            }

            set
            {
                m_TempoTemperatura += value;
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

        private void m_BtnIniciar_Click(object sender, EventArgs e)
        {
            ThreadSensor = new Thread(atualizaThreadSensor);
            ThreadProducao = new Thread(atualizaThreadGas);
            ThreadGas = new Thread(atualizaThreadLinhaProducao);

            ThreadSensor.Start();
            ThreadProducao.Start();
            ThreadGas.Start();
        }

        private void m_BtnDesligar_Click(object sender, EventArgs e)
        {
            try
            {
                //sensor.Interrupt();
                //producao.Interrupt();
                //gas.Interrupt();
            }
            catch
            {

            }
        }

        private void m_BtnGasUp_Click(object sender, EventArgs e)
        {//Main Thread
            Temperatura = 50;
            Pressao = 100;
            TempoProducao = -1000;

            invokeSensor();
            invokePressao();
            invokeProducao();
        }

        private void m_BtnGasDown_Click(object sender, EventArgs e)
        {//Main Thread
            Temperatura = -50;
            Pressao = -100;
            TempoProducao = +1000;

            invokeSensor();
            invokePressao();
            invokeProducao();
        }

        #endregion

        #region Methods

        private void initializeUserControls()
        {
            m_TemperaturePanel.Controls.Add(m_ucTemperatureSensor);
            m_PressionPanel.Controls.Add(m_ucGas);
            m_ProductLinePanel.Controls.Add(m_ucProductLine);
        }

        //Threads Individuais
        private void atualizaThreadSensor()
        {
            m_ucTemperatureSensor.setValorInicialTemperatureSensor();

            while (true)
            {
                Temperatura = 1;

                Thread.Sleep(TempoTemperatura);
                invokeSensor();
            }
        }

        private void atualizaThreadGas()
        {
            m_ucGas.setValorInicialPressao();
            while (true)
            {
                Pressao = 1;
                Thread.Sleep(TempoPressao);
                invokePressao();
            }
        }

        private void atualizaThreadLinhaProducao()
        {
            while (true)
            {
                Produtos = 1;
                Thread.Sleep(TempoProducao);
                invokeProducao();
            }
        }

        //Metodos compartilhados pelas Threads (main thread e threads secundarias)
        private void invokePressao()
        {
            if (m_ucGas.InvokeRequired)
            {
                this.Invoke(new PressiaoControlEventHandler(m_ucGas.setLabelPressao),
                    new object[] { "Pressão  " + Pressao.ToString() });
            }
            else
            {
                m_ucGas.PressaoLabel = "Pressão  " + Pressao.ToString();
            }
        }

        private void invokeProducao()
        {
            if (m_ucProductLine.InvokeRequired)
            {
                this.Invoke(new TemperatureSensorEventHandler(m_ucProductLine.setLabelProductLine),
                    new object[] { "Quantidade produzida  " + Produtos.ToString() });
            }
            else
            {
                m_ucProductLine.ProductLabel = "Quantidade produzida  " + Produtos.ToString();
            }
        }

        private void invokeSensor()
        {
            if (m_ucTemperatureSensor.InvokeRequired)
            {
                this.Invoke(new TemperatureSensorEventHandler(m_ucTemperatureSensor.setLabelTemperature),
                    new object[] { Temperatura.ToString() + " ° C" });
            }
            else
            {
                m_ucTemperatureSensor.TemperatureLabel = Temperatura.ToString() + " ° C";
            }
        }

        #endregion

    }
}
