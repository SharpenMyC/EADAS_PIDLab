using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dasPIDLab
{
    public partial class Main : Form
    {
        //Chart variables
        double xAxisValues;
        public const int CHARTMAXPOINTS = 500;
        
        NumberStyles style;
        CultureInfo provider;
        // Control Loop Variables
        double processValue,     //sensor value read from external PCB
              setpointValue,    //Setpoint given by user
              errorValueK,      //errorValue in current sample step  (setpointValue - processValue)
              errorValueK_1,    //errorValue in preceeding sample step
              errorValueK_2,    //errorValue in preceeding the preceeding sample step
              controlValueK,    //oputput value from controller in current sample step
              controlValueK_1,  //oputput value from controller in preceeding sample step
              sampleTime,       //control loop sample time
              proportionalK,    //Propotional controller constant
              integralT,        //integral controller time constant
              derivativeT,      //derivative controller time constant
              controlValueP,    //proportional controll signal contribution
              controlValueI,    //integral controll signal contribution
              controlValueD;    //derivative controll signal contribution



        public Main()
        {
            InitializeComponent();

            //To avoid the problem of decimal point sign being ','
            style = NumberStyles.AllowDecimalPoint;
            provider = new CultureInfo("en-US");

            //counter for the x-axis
            xAxisValues = 0.0;

            //Controlloop variables:
            processValue = 0.0;
            setpointValue = 0.0;
            errorValueK = 0.0;
            errorValueK_1 = 0.0;
            errorValueK_2 = 0.0;
            controlValueK = 0.0;    
            controlValueK_1 = 0.0;
            sampleTime = Convert.ToDouble(timerControlLoop.Interval)/ 1000.0; //convert to seconds
            proportionalK = 0.0;    
            integralT = 0.0;        
            derivativeT = 0.0;      
            controlValueP = 0.0;    
            controlValueI = 0.0;    
            controlValueD = 0.0;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBoxMan.ReadOnly = false;
            }
            else
            {
                textBoxMan.ReadOnly = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (serialPort.IsOpen && timer1.Enabled)
                {

                controlValueK_1 = double.Parse(textBoxMan.Text, style, provider);

                
                timerControlLoop.Enabled = true;
                textBoxSerialSend.Enabled = false;

                proportionalK = double.Parse(textBoxP.Text, style, provider);
                integralT = double.Parse(textBoxI.Text, style, provider);
                derivativeT = double.Parse(textBoxD.Text, style, provider);

                }
            }
            else
            {
                timerControlLoop.Enabled = false;
                textBoxSerialSend.Enabled = true;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPort.PortName = textBoxComPort.Text;
            serialPort.Open();
            timer1.Enabled = true;
            buttonDisconnect.Enabled = true;
            buttonConnect.Enabled = false;
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            timer1.Enabled = false;
            timerControlLoop.Enabled = false;
            buttonDisconnect.Enabled = false;
            buttonConnect.Enabled = true;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxSerialSend.Text.Length>0) 
            {
                serialPort.WriteLine(textBoxSerialSend.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Send command to read process value
            serialPort.WriteLine("LD");
        }
        private void checkBoxDataReceived_CheckedChanged(object sender, EventArgs e)
        {
            int tmpScaledControlValue;
            double tmpMeasValue = 0.0;
            double tmpSetpoint = 0.0;
            double tmpControlValue = 0.0;

            if (checkBoxDataReceived.Checked) //new data received
            {

                //get the values to draw in graph
                try
                {
                    tmpMeasValue = double.Parse(textBoxReceived.Text, style, provider);
                    tmpSetpoint = double.Parse(textBoxSetpoint.Text, style, provider);
                    tmpControlValue = double.Parse(textBoxMan.Text, style, provider);
                }
                catch (Exception)
                {

                }
                finally //draw the graph
                {
                    xAxisValues += 1.0;  //increase the X-axis counter  
                    chartPID.Series[0].Points.AddXY(xAxisValues, tmpMeasValue);
                    chartPID.Series[1].Points.AddXY(xAxisValues, tmpSetpoint);
                    chartPID.Series[2].Points.AddXY(xAxisValues, tmpControlValue);
                    if (chartPID.Series[0].Points.Count > CHARTMAXPOINTS)
                    {
                        chartPID.ChartAreas[0].AxisX.Minimum += 1;
                        chartPID.ChartAreas[0].AxisX.Maximum += 1;
                        chartPID.Series[0].Points.RemoveAt(0);
                        chartPID.Series[1].Points.RemoveAt(0);
                        chartPID.Series[2].Points.RemoveAt(0);
                    }
                }

                //Scale controlValue to the resolution wanted and send it on the serial port

                if (checkBoxResolution.Checked)  //8-bit
                {
                    tmpScaledControlValue = (int)Math.Round((255.0 / 100.0) * tmpControlValue);
                    if (tmpScaledControlValue < 10)
                    {
                        serialPort.WriteLine("AB 00" + tmpScaledControlValue.ToString());
                    }
                    else if (tmpScaledControlValue > 9 && tmpScaledControlValue < 100)
                    {
                        serialPort.WriteLine("AB 0" + tmpScaledControlValue.ToString());
                    }
                    else
                    {
                        serialPort.WriteLine("AB " + tmpScaledControlValue.ToString());
                    }
                }
                else
                {
                    tmpScaledControlValue = (int)Math.Round((15.0 / 100.0) * tmpControlValue);
                    if (tmpScaledControlValue < 10)
                    {
                        serialPort.WriteLine("AN 00" + tmpScaledControlValue.ToString());
                    }
                    else if (tmpScaledControlValue > 9)
                    {
                        serialPort.WriteLine("AN 0" + tmpScaledControlValue.ToString());
                    }
                }

                checkBoxDataReceived.Checked = false;
            }
        } 

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            string RecievedData = ((System.IO.Ports.SerialPort)sender).ReadLine();
            if (char.IsDigit(RecievedData[0]))
            {
                textBoxReceived.Invoke((MethodInvoker)delegate { textBoxReceived.Text = RecievedData.Trim('\r'); });
                checkBoxDataReceived.Invoke((MethodInvoker)delegate { checkBoxDataReceived.Checked = true; }); 
            }
            else if (RecievedData[0]=='R')
            {
                labelResolution.Invoke((MethodInvoker)delegate { labelResolution.Text = RecievedData; });
            }
        }
        private void timerControlLoop_Tick(object sender, EventArgs e)
        {
            //The Control Loop should always be on a fixed cycle to avoid signal aliasing
            //The sample time Ts should be equal to the TimerControlLoop.Intervall
            
            

            //Get the processValue from the textboxReceived
            if (string.IsNullOrEmpty(textBoxReceived.Text) == false)
            {
                double.TryParse(textBoxReceived.Text, style, provider, out processValue);
            }
            //Get the setpointValue from the textboxReceived
            if (string.IsNullOrEmpty(textBoxSetpoint.Text) == false)
            {
                double.TryParse(textBoxSetpoint.Text, style, provider, out setpointValue);
            }
            //Calculate errorValueK 
            errorValueK = (100.0/2)*(setpointValue - processValue); //The temperature span is about 2 degrees.

            //Calculate controllValueP,controllValueI,controllValueD
            controlValueP = proportionalK * (errorValueK - errorValueK_1);
            controlValueI = proportionalK * (sampleTime / integralT) * errorValueK;
            controlValueD = proportionalK * (derivativeT / sampleTime) * (errorValueK - 2 * errorValueK_1 + errorValueK_2);

            //prevent integral windup
            if (controlValueI > 100.0)
            {
                controlValueI = 100.0;
            }
            else if (controlValueI < -100.0)
            {
                controlValueI = -100.0;
            }

            //Calculate the controllValueK
            controlValueK = controlValueK_1 + controlValueP + controlValueI + controlValueD;

            if (controlValueK > 100.0)
            {
                controlValueK = 100.0;
            }
            else if (controlValueK < 0.0)
            {
                controlValueK = 0.0;
            }

            //Transfer the error values to preceeding samples
            errorValueK_2 = errorValueK_1;
            errorValueK_1 = errorValueK;

            //Transfer the controlvalues to preceeding sample
            controlValueK_1 = controlValueK;

            //transfer controlvalue to textbox for sending.
            textBoxMan.Text = controlValueK.ToString("0.00", new CultureInfo("en-US", false));
        }   


        
    }
}
