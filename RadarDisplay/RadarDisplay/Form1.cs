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
using System.IO;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace RadarDisplay
{
    public partial class Form1 : Form
    {
        private static SerialPort comPort;
        private static List<DataPoint> dataSet;
        private static List<string> rawData;


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
            rawData = new List<string>();
        }


        private void btnInit_Click(object sender, EventArgs e)
        {
            if(cbCom.SelectedItem != null)
            {
                try
                {
                    comPort = new SerialPort();
                    comPort.BaudRate = 115200;
                    comPort.PortName = cbCom.SelectedItem.ToString();
                    comPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    comPort.Open();


                    comPort.Write("I");
                    btnInit.Enabled = false;
                    btnEnd.Enabled = true;
                    cbCom.Enabled = false;
                    gbData.Enabled = false;
                    gbMap.Enabled = false;
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
            comPort.Write("exit");
            comPort.Close();
            update();
            btnInit.Enabled = true;
            cbCom.Enabled = true;
            btnEnd.Enabled = false;

            gbData.Enabled = true;
            gbMap.Enabled = true;
        }

        //Gets called whenever data is received through the com port
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            rawData.Add(indata);
            Debug.Print(indata);
            float[] parsedData = DataParser.ParseString(indata);

            if(parsedData != null)
            {
                //DataPoint tempData = new DataPoint();
                //dataSet.Add(new DataPoint(dataSet.Count + 1, parsedData[3], parsedData[0])); //left
                dataSet.Add(new DataPoint(dataSet.Count + 1, parsedData[1], parsedData[0])); //forward
                //dataSet.Add(new DataPoint(dataSet.Count + 1, parsedData[3], parsedData[2])); //right
            }

        }

        private void update()
        {
            lbDataView.Items.Clear();
            for(int i = 0; i < dataSet.Count(); i++)
            {
                lbDataView.Items.Add(dataSet[i].getID());
            }
            pbDisplay.Invalidate();
        }

        private void lbDataView_SelectedIndexChanged(object sender, EventArgs e)
        { 
            loadPointData(dataSet[lbDataView.SelectedIndex]);
        }
        private void loadPointData(DataPoint data)
        {
            lblId.Text = data.getID();
            lblDist.Text = data.getDist().ToString();
            lblAngle.Text = data.getAngle().ToString();
            lblCoord.Text = data.getCoords().X + ", " + data.getCoords().Y;
        }


        private void btnDraw_Click(object sender, EventArgs e)
        {
            pbDisplay.Invalidate();
        }

        private void pbDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int midX = pbDisplay.Width / 2;
            int midY = pbDisplay.Height / 2;

            
            if (cbAxis.Checked == true)
            {
                g.DrawLine(Pens.Blue, midX, 0, midX, pbDisplay.Height);
                g.DrawLine(Pens.Blue, 0, midY, pbDisplay.Width, midY);
            }

            Brush wallBrush = new SolidBrush(Color.Green);

            for (int i = 0; i < dataSet.Count; i++)
            {
                g.FillEllipse(wallBrush, new Rectangle(dataSet[i].getCoords().X + midX, dataSet[i].getCoords().Y + midY, 3, 3));
                /*
                try
                {
                    if (MyPoints[i].X > Int32.MinValue)
                    {
                        g.FillEllipse(wallBrush, new Rectangle(MyPoints[i].X, MyPoints[i].Y, 3, 3)); //OVERFLOW EXCEPTION
                    }
                }
                catch (System.ArgumentOutOfRangeException) { }*/
            }
            wallBrush.Dispose();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(lbDataView.SelectedItem != null)
            {
                dataSet.RemoveAt(lbDataView.SelectedIndex);
                lbDataView.Invalidate();
            }
            else
            {
                MessageBox.Show("Select a point please you cluts");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData fileName = new SaveData();

            var result = fileName.ShowDialog();
            if (result == DialogResult.OK)
            {

                //string path = @"C:\Folder1\Folder2\Folder3\Folder4";
                //string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\"));

                string file = fileName.fileName + ".txt";
                string test = Directory.GetCurrentDirectory();
                //DirectoryInfo test2 = Directory.GetParent(test);
                //DirectoryInfo test3 = Directory.GetParent(@"..\" + test);

                System.IO.File.WriteAllLines(Path.Combine(test, @"..\..\Data\") + file, rawData);
            }
            else
            {
                MessageBox.Show("Something went wrong, please try again");
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePicker = new OpenFileDialog();

            if (filePicker.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(filePicker.FileName);

                dataSet.Clear();

                gbData.Enabled = true;
                gbMap.Enabled = true;

                foreach (string line in lines)
                {
                    float[] data = DataParser.ParseString(line);
                    
                    if (data != null)
                    {
                        dataSet.Add(new DataPoint(dataSet.Count + 1, data[1], data[0]));
                    }
                }

                update();
            }
        }

        private void cbAxis_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
