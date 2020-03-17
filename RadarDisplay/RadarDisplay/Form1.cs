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
                //dataSet.Add(new DataPoint(dataSet.Count + 1, parsedData[3], parsedData[0]));  //left
                dataSet.Add(new DataPoint(dataSet.Count + 1, parsedData[1], parsedData[0]));    //forward
                //dataSet.Add(new DataPoint(dataSet.Count + 1, parsedData[3], parsedData[2]));  //right
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
            if(lbDataView.SelectedItem != null)
            {
                loadPointData(dataSet[lbDataView.SelectedIndex]);
            }
        }
        private void loadPointData(DataPoint data)
        {
            lblId.Text = data.getID();
            lblDist.Text = data.getDist().ToString();
            lblAngle.Text = data.getAngle().ToString();
            lblCoord.Text = data.getCoords().X + ", " + data.getCoords().Y;
            lblOccurences.Text = data.getOccurences().ToString();
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

            for (int i = 0; i < dataSet.Count; i++)
            {
                dataSet[i].drawPoint(g, midX, midY);
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData fileName = new SaveData();

            var result = fileName.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fileName.fileName + ".txt";
                string test = Directory.GetCurrentDirectory();
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

        private void btnClearData_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            rawData.Clear();
            update();
        }

        private void cbTesting_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTesting.Checked)
            {
                MessageBox.Show("Warning!!\nThis is not meant to be used for proper functionality testing.\n The program may not behave as expected.");
                btnAddp.Enabled = true;
                gbData.Enabled = true;
                gbMap.Enabled = true;
            }
            else
            {
                btnAddp.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData newPointCreator = new AddData();
            if (newPointCreator.ShowDialog() == DialogResult.OK)
            {
                string newPointString = "F" + newPointCreator.distance + "S" + newPointCreator.angle;
                rawData.Add(newPointString);
                float[] newPoint = DataParser.ParseString(newPointString);

                if (newPoint != null)
                {
                    Debug.WriteLine(newPointString);
                    dataSet.Add(new DataPoint(dataSet.Count + 1, newPoint[1], newPoint[0]));
                    update();
                    gbMap.Invalidate();
                }
            }
        }

        private void btnCondense_Click(object sender, EventArgs e)
        {
            DataPoint[] vistedPoints = new DataPoint[dataSet.Count];

            vistedPoints[0] = dataSet[0];
            vistedPoints[0] = dataSet[0];
            int currentFilled = 1; //how far into filling the visitedCoords array

            //iterate over the data set and remove all point Data that have the same x and y
            for (int i = 1; i < dataSet.Count; i++)
            {
                bool found = false;
                int index = 0;
                DataPoint currentPoint = dataSet[i];
                while (!found && index < currentFilled)
                {
                    //if the X and Y are equal
                    if(currentPoint.getCoords().X == vistedPoints[index].getCoords().X && currentPoint.getCoords().Y == vistedPoints[index].getCoords().Y)
                    {
                        found = true;
                        vistedPoints[index].addOccurence();
                    }
                }
                if (!found) //if after the while loop it still hasn't been found 
                {
                    //Add it to the list of visited points
                    vistedPoints[currentFilled] = currentPoint;
                    currentFilled++;
                }
            }

            //reset the data set array and copy in the new points
            dataSet.Clear();
            for(int i = 0; i < currentFilled; i++)
            {
                dataSet.Add(vistedPoints[i]);
            }

            update();
        }
    }
}