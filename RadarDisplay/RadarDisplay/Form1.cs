using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RadarDisplay
{
    public partial class Form1 : Form
    {
        private SerialPort comPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            for(int i = 0; i < ports.Count() - 1; i++)
            {
                cbCom.Items.Add(ports[i]);
            }

            cbCom.Items.Add("Test");
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            if(cbCom.SelectedItem != null)
            {
                try
                {
                    comPort = new SerialPort();
                    comPort.BaudRate = 9600;
                    comPort.PortName = cbCom.SelectedItem.ToString();
                    comPort.Open();

                    btnInit.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("There has been an error connecting");
                }
            }

            else
            {
                MessageBox.Show("Please select an item from the drop down");
            }
        }
    }
}
