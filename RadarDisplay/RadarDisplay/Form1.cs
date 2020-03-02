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
using System.Diagnostics;

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
            for(int i = 0; i < ports.Count(); i++)
            {
                cbCom.Items.Add(ports[i]);
            }
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
                    comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    comPort.Open();

                    btnInit.Enabled = false;
                    btnEnd.Enabled = true;
                    cbCom.Enabled = false;
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


        //Gets called whenever data is received through the com port
        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Debug.Print(indata);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            comPort.Close();
            btnInit.Enabled = true;
            cbCom.Enabled = true;
            btnEnd.Enabled = false;
        }
    }
}
