using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_Tempo_Real_Temperature_Sensor
{
    public partial class TemperatureSensor : Form
    {
        public TemperatureSensor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (comport.connect(9600, "I'M ARDUINO", 4, 8, 16))
            //{
            //    labelconnection.Text = "Connection Successful - Connected to  " + comport.port;
            //    portConnection = true;
                tempreader.Start();
            //}
            //else
            //{
            //    labelconnection.Text = "Not connected . . . ";
            //    //portConnection = false;
            //    tempreader.Stop();
            //}
        }

        private void tempreader_Tick(object sender, EventArgs e)
        {
            //labeltemp.Text = comport.message(4, 8, 32) + "C";
            labeltemp.Text = "32" + "C";
        }

    }
}
