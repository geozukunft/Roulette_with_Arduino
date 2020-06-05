using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Roulette_with_Arduino
{
    public partial class Form1 : Form
    {
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate Delegate1;
        public AddDataDelegate Delegate2;
        public AddDataDelegate Delegate3;
        int[] data; 


        public Form1()
        {
            InitializeComponent();

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            this.Delegate1 = new AddDataDelegate(AddDataMethodNumber);
            this.Delegate2 = new AddDataDelegate(AddDataMethodEven);
            this.Delegate3 = new AddDataDelegate(AddDatatoFileAndLBO);
        }

        private static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            //data received on serial port is asssigned to "indata" string
            //Console.WriteLine("Received data:");
            //Console.Write(indata);
        }

        public void AddDatatoFileAndLBO(String myString)
        {
            lboData.Items.Add(myString);

        }

        public void AddDataMethodNumber(String myString)
        {
            lblResult.Text = myString;
        }

        public void AddDataMethodEven(String myString)
        {
            lblEvenUneven.Text = myString;
        }

        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            string[] splitLine = indata.Split(';');

            int values = data.Count();
            data[values] = Convert.ToInt32(splitLine[0]);

            lblResult.Invoke(this.Delegate1, new Object[] { splitLine[0] });
            lblEvenUneven.Invoke(this.Delegate2, new Object[] { splitLine[1] });
            lboData.Invoke(this.Delegate3, new object[] { splitLine[0] });
        }

        private void ListCom()
        {
            //Write all available ports into String
            string[] ports = SerialPort.GetPortNames();

            //Display available Ports
            foreach (string port in ports)
            {
                cboPorts.Items.Add(port);
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboPorts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select COM-POrt");
            }
            else
            {
                serialPort1.PortName = cboPorts.SelectedItem.ToString();
                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                        MessageBox.Show("Port opened");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A error occurred!");
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboPorts_Click(object sender, EventArgs e)
        {
            ListCom(); //List Ports in Menu
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                MessageBox.Show("Port closed");
            }
            else
            {
                MessageBox.Show("Port not open");
            }
        }

        private void cmdRequest_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("1");
        }
    }



}
