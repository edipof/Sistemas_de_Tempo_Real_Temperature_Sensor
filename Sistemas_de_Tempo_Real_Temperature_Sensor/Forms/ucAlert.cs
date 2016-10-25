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
    public partial class ucAlert : UserControl
    {
        public ucAlert()
        {
            InitializeComponent();
        }

        private void ucAlert_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        public void setColor(Color cor)
        {
            BackColor = cor;
        }
    }
}
