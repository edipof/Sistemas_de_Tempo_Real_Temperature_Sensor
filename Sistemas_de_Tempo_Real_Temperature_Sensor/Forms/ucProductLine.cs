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
    public partial class ucProductLine : UserControl
    {
        public delegate void ProductLineEventHandler(string text);

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

        public ucProductLine()
        {
            InitializeComponent();
        }

        private void ucProductLine_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
