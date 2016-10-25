using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sistemas_de_Tempo_Real_Temperature_Sensor.Forms
{
    public partial class ucProductLine : UserControl
    {
        #region Members

        public delegate void ProductLineEventHandler(string text);
        public delegate void ChartEventHandler(List<DataChart> p_DataChart);

        #endregion

        #region Properties

        public string ProductLabel
        {
            get
            {
                return m_LblProductLine.Text;
            }

            set
            {
                m_LblProductLine.Text = value;
            }
        }

        #endregion

        #region constructor

        public ucProductLine()
        {
            InitializeComponent();
            m_LblProductLine.Text = string.Empty;
        }

        #endregion

        #region events

        private void ucProductLine_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        #endregion

        #region Methods

        public void setLabelProductLine(string e)
        {
            ProductLabel = e;
        }

        public void updateChart(List<DataChart> p_DataChart)
        {
            chartProduct.Controls.Clear();
            chartProduct.Series.Clear();
            chartProduct.Titles.Clear();
            
            chartProduct.Titles.Add("Produção");

            foreach (DataChart XY in p_DataChart.Distinct())
            {
                Series serie = chartProduct.Series.Add(XY.X.ToString());
                serie.Points.Add(Convert.ToDouble(XY.Y));
            }
        }

        #endregion

    }
}
