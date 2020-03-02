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
using System.Collections.ObjectModel;

namespace RadarDisplay
{
    public partial class Form1 : Form
    {
        private static SerialPort comPort;
        private static List<DataPoint> dataSet;


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

            dataSet = new List<DataPoint>();
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
        private void btnEnd_Click(object sender, EventArgs e)
        {
            comPort.Close();
            update();
            btnInit.Enabled = true;
            cbCom.Enabled = true;
            btnEnd.Enabled = false;
        }

        //Gets called whenever data is received through the com port
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Debug.Print(indata);
            int[] parsedData = DataParser.ParseString(indata);

            //DataPoint tempData = new DataPoint();
            dataSet.Add(new DataPoint(parsedData[3], parsedData[0])); //left
            dataSet.Add(new DataPoint(parsedData[3], parsedData[1])); //forward
            dataSet.Add(new DataPoint(parsedData[3], parsedData[2])); //right

        }

        private void update()
        {
            lbDataView.Items.Clear();
            for(int i = 0; i < dataSet.Count(); i++)
            {
                lbDataView.Items.Add(dataSet[i].getAngle().ToString());
            }
            lbDataView.Items.Add("test");
        }
    }
}
