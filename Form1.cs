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

namespace PultTest
{
    public partial class Form1 : Form
    {
        SerialPort currentPort;
        public Form1()
        {
            InitializeComponent();
        }

        private bool ArduinoDetected()
        {
            try
            {
                currentPort.Open();
                System.Threading.Thread.Sleep(1000);
                
                string returnMessage = currentPort.ReadLine();
                currentPort.Close();

                if (returnMessage.Contains("1"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "1";
        }
    }
}
