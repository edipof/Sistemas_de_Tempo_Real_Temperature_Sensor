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
using static Sistemas_de_Tempo_Real_Temperature_Sensor.Forms.ucProductLine;

namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    public partial class frmMain : Form
    {
        #region Members

        private static bool m_SistemaOn = false;
        private DataChart produtosChart = new DataChart();
        private static int valorProdutosPorSegundo = 0;

        #region UserControl
        private ucTemperatureSensor m_ucTemperatureSensor = new ucTemperatureSensor();
        private ucProductLine m_ucProductLine = new ucProductLine();
        private ucGas m_ucGas = new ucGas();
        private ucAlert m_ucAlert = new ucAlert();
        #endregion

        #region Thread
        private Thread ThreadSensor;
        private Thread ThreadProducao;
        private Thread ThreadGas;
        private Thread ThreadGraficos;
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
        private static int m_Temperatura = 500;
        private static int m_Produtos = 0;
        private static int m_Pression = 0;
        #endregion

        #endregion

        #region Properties
        //Metodos Get e Set

        public int Temperatura
        {
            get
            {
                lock (getTemperaturaLock)
                {
                    setCoresPainelAlerta();

                    //if (m_Temperatura > 1000)
                    //{
                    //    MessageBox.Show("Temperatura Maxima aceitável atingida");
                    //}
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

        public static int Produtos
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

        public static int Pressao
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
                m_TempoProducao = (m_TempoProducao + value <= 0 ? 100 : m_TempoProducao + value);
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
            if (!m_SistemaOn)
            {
                setCoresPainelAlerta();

                ThreadProducao = new Thread(atualizaThreadGas);
                ThreadGas = new Thread(atualizaThreadLinhaProducao);
                ThreadSensor = new Thread(atualizaThreadSensor);
                ThreadGraficos = new Thread(atualizaGraficos);

                ThreadSensor.Start();
                ThreadProducao.Start();
                ThreadGas.Start();
                ThreadGraficos.Start();

                m_SistemaOn = true;
            }
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
            TempoProducao = -100;

            invokeSensor();
            invokePressao();
            invokeProducao();
        }

        private void m_BtnGasDown_Click(object sender, EventArgs e)
        {//Main Thread
            Temperatura = -50;
            Pressao = -100;
            TempoProducao = +100;

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
            m_PanelAlert.Controls.Add(m_ucAlert);
        }

        private void setCoresPainelAlerta()
        {
            if (m_Temperatura > 0 && m_Temperatura <= 799)
            {
                m_ucAlert.setColor(Color.FromArgb(38, 255, 0));
            }
            else if (m_Temperatura > 799 && m_Temperatura < 1000)
            {
                m_ucAlert.setColor(Color.Yellow);
            }
            else if (m_Temperatura >= 1000)
            {
                m_ucAlert.setColor(Color.Red);
                produtosChart.getFilteredList();
            }
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
                Thread.Sleep(TempoProducao);
                Produtos = 1;
                invokeProducao();
            }
        }

        private void atualizaGraficos()
        {
            while(true)
            {
                Thread.Sleep(1000);
                valorProdutosPorSegundo = Produtos - valorProdutosPorSegundo;
                produtosChart.add(valorProdutosPorSegundo, DateTime.Now);
                if (m_ucProductLine.InvokeRequired && produtosChart.ListXY != null)
                {
                    Invoke (new ChartEventHandler(m_ucProductLine.updateChart), 
                        new object[] {produtosChart.getFilteredList() });
                }
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
                m_ucGas.setLabelPressao("Pressão  " + Pressao.ToString());
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
                m_ucProductLine.setLabelProductLine("Quantidade produzida  " + Produtos.ToString());
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

    public class DataChart
    {
        private int y;
        private DateTime x;
        private List<DataChart> listXY = new List<DataChart>();

        public DataChart() { }

        public DataChart(int Y, DateTime X)
        {
            this.Y = Y;
            this.X = X;
        }

       

        public List<DataChart> ListXY
        {
            get
            {
                return listXY;
            }

            set
            {
                listXY = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public DateTime X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public void add(int Y, DateTime X)
        {
            ListXY.Add(new DataChart(Y, X));
        }

        public List<DataChart> getFilteredList()
        {
            List<DataChart> filtredList = ListXY
                .GroupBy(sec => sec.X.Second)
                .Select(p => new DataChart
                {
                    X = p.First().X,
                    Y = Convert.ToInt32(p.Sum(g => g.Y)),
                }).ToList();

            return filtredList;
        }
    }

}
