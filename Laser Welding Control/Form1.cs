using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
//using Emgu.CV;
//using Emgu.CV.UI;
//using Emgu.Util;
//using Emgu.CV.Structure;

namespace Laser_Welding_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (string ComPortName in SerialPort.GetPortNames())
            {
                comboBoxCOMPort.Items.Add(ComPortName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = SettingsTab;
            comboBoxBaudRate.Text = "19200";
            comboBoxMachineID.Text = "00";
        }

        // refreshing COM ports
        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            comboBoxCOMPort.Items.Clear();
            foreach (string ComPortName in SerialPort.GetPortNames())
            {
                comboBoxCOMPort.Items.Add(ComPortName);
            }
        }

        private void comboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBoxCOMPort.Text))
                btnConnect.Enabled = true;
        }

        // COM port configuration
        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxCOMPort.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
            serialPort1.Parity = Parity.Even;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.WriteBufferSize = 8192;
            serialPort1.ReadBufferSize = 8192;
            serialPort1.WriteTimeout = 1000;
            serialPort1.ReadTimeout = 1000;

            try
            {
                serialPort1.Open();
            }
            catch (Exception)
            {
                throw;
            }

            if (serialPort1.IsOpen)
            {
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                COMStatusLabel.Text = $"COM Status: {comboBoxCOMPort.Text} conneted";
                COMStatusLabel.BackColor = Color.Lime;
            }
            else
            {
                labelStatus.Text = $"COM Status: {comboBoxCOMPort.Text} connection failed";
                COMStatusLabel.BackColor = Color.Red;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (serialPort1.IsOpen)
            {
                labelStatus.Text = "Disconnection Failed!!!";
                COMStatusLabel.Text = $"COM Status: {comboBoxCOMPort.Text} disconneted";
                COMStatusLabel.BackColor = Color.Lime;
            }
            else
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                COMStatusLabel.Text = $"COM Status: {comboBoxCOMPort.Text} disconneted";
                COMStatusLabel.BackColor = Color.Red;
            }
        }

        // TX
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendCommand(textBoxWrite.Text);
        }

        //RX
        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadMsg();
        }

        private void SendCommand(string cmd)
        {
            try
            {
                //byte[] byteWriteArray = Array.Empty<byte>();
                byte[] byteWriteArray = new byte[] { };
                if (rbtnASCIIMode.Checked)
                {
                    List<byte> byteWriteList = new List<byte>();

                    /*Adding STX 0x02*/
                    byteWriteList.Add(0x02);

                    /*Adding ADD1+ADD2*/
                    switch (comboBoxMachineID.Text.ToString().Trim())
                    {
                        case "00":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("00"));
                            break;
                        case "01":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("01"));
                            break;
                        case "02":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("02"));
                            break;
                        case "03":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("03"));
                            break;
                        case "04":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("04"));
                            break;
                        case "05":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("05"));
                            break;
                        case "06":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("06"));
                            break;
                        case "07":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("07"));
                            break;
                        case "08":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("08"));
                            break;
                        case "09":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("09"));
                            break;
                        case "10":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("10"));
                            break;
                        case "11":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("11"));
                            break;
                        case "12":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("12"));
                            break;
                        case "13":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("13"));
                            break;
                        case "14":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("14"));
                            break;
                        case "15":
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("15"));
                            break;
                        default:
                            byteWriteList.AddRange(Encoding.ASCII.GetBytes("00"));
                            break;
                    }

                    /*Adding SIF*/
                    string inputCmd = cmd;
                    var SIFByteArray = Encoding.ASCII.GetBytes(inputCmd.Trim());
                    //var SIFByteArray =  Encoding.ASCII.GetBytes(textBoxWrite.Text.Trim());

                    foreach (byte SIFByte in SIFByteArray)
                    {
                        byteWriteList.Add(SIFByte);
                    }

                    /*Adding ETX 0x03*/
                    byteWriteList.Add(0x03);

                    /*Adding LRC*/
                    byte LRC = 0x00;
                    for (int i = 1; i < byteWriteList.Count; i++) //ADD1+ADD2+SIF+ETX
                    {
                        LRC ^= byteWriteList[i];
                    }
                    byteWriteList.Add(LRC);
                    byteWriteArray = byteWriteList.ToArray();
                }

                else if (rbtnHexMode.Checked)
                {
                    string hexString = textBoxWrite.Text;
                    hexString = string.Join(string.Empty, hexString.Split());
                    hexString.Replace("-", "");
                    int numOfChars = hexString.Length;
                    if (numOfChars % 2 != 0)
                    {
                        MessageBox.Show("Input is not valid!\nPlease check the format of hex string(XX XX XX XX).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    byteWriteArray = HexStringToByteArray(hexString);
                }
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                serialPort1.Write(byteWriteArray, 0, byteWriteArray.Length);
                btnSend.Enabled = true;
                btnRead.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ReadMsg()
        {
            var byteRead = 0;
            var byteReadArray = new byte[8192];
            int idx = 0;
            try
            {
                textBoxRead.Text = "";
                while (true)
                {
                    byteRead = serialPort1.ReadByte();
                    byteReadArray[idx] = (byte)byteRead;
                    idx++;
                    if (serialPort1.BytesToRead == 0)
                    {
                        break;
                    }
                }
                string tmp = "";
                if (rbtnASCIIMode.Checked)
                {
                    var newByteReadArray = new byte[idx];
                    Array.Copy(byteReadArray, newByteReadArray, idx);
                    tmp = Encoding.ASCII.GetString(newByteReadArray);
                    textBoxRead.Text = tmp.Replace("\n", "\r\n");
                }
                else if (rbtnHexMode.Checked)
                {
                    var newByteReadArray = new byte[idx];
                    Array.Copy(byteReadArray, newByteReadArray, idx);
                    tmp = ByteArrayToHexString(newByteReadArray);
                    textBoxRead.Text = tmp;
                }
                btnSend.Enabled = true;
                btnRead.Enabled = false;

                return textBoxRead.Text;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Time Out!!!", "Time Out Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSend.Enabled = true;
                btnRead.Enabled = false;

                return "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static byte[] HexStringToByteArray(String hexString)
        {
            int numOfChars = hexString.Length;
            byte[] bytes = new byte[numOfChars / 2];
            for (int i = 0; i < numOfChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return bytes;
        }

        public static string ByteArrayToHexString(byte[] byteArray)
        {
            return BitConverter.ToString(byteArray).Replace("-", " ");
        }

        private void CommandModeCheckedChange(object sender, EventArgs e)
        {
            if (rbtnASCIIMode.Checked) { label3.Text = "TX: (Please type in ASCII command format. ex: RALS)"; }
            else if (rbtnHexMode.Checked) { label3.Text = "TX: (Please type in Hex command format. ex: XX XX XX XX XX)"; }
        }

        private void btn_getControl_Click(object sender, EventArgs e)
        {
            SendCommand("RRPC");
        }

        private void btn_releaseControl_Click(object sender, EventArgs e)
        {
            SendCommand("RMBO");
        }

        private void btn_highVolt_Click(object sender, EventArgs e)
        {
            SendCommand("RBSC 06,001");
        }

        private void btn_lowVolt_Click(object sender, EventArgs e)
        {
            SendCommand("RBSC 06,000");
        }

        private void btn_setFeedback_mode_to_energy_Click(object sender, EventArgs e)
        {
            string[] schemeMsg = ReadScheme();
            schemeMsg[0] = "1";

            Thread.Sleep(200);

            setScheme_Feedback(schemeMsg);
        }

        private void btn_setFeedback_mode_to_current_Click(object sender, EventArgs e)
        {
            string[] schemeMsg = ReadScheme();
            schemeMsg[0] = "0";

            Thread.Sleep(200);

            setScheme_Feedback(schemeMsg);
        }

        private void btn_readScheme_Click(object sender, EventArgs e)
        {
            ReadScheme();
        }

        private string[] ReadScheme()
        {
            string[] schemeMsg = new string[] { };
            if (comboBox_scheme.SelectedItem == null)
            {
                MessageBox.Show("未選擇參數");
                return schemeMsg;
            }

            string selected_scheme = comboBox_scheme.SelectedItem.ToString();

            try
            {
                SendCommand($"RHSI {selected_scheme}");  //ask laser "05" scheme's parameter
                string readString = ReadMsg();

                if (!string.IsNullOrEmpty(readString))
                {
                    readString.Remove(0, 8);

                    schemeMsg = readString.Split(',');

                    if (schemeMsg.Length == 8)
                    {
                        textBoxRead.Text = readString;
                        textBox_feedBack.Text = schemeMsg[0];
                        textBox_inputPower.Text = schemeMsg[1];
                        textBox_peakPower.Text = schemeMsg[2];
                        textBox_repetition.Text = schemeMsg[3];
                        textBox_firingTimes.Text = schemeMsg[4];
                        textBox_LowerEnergy.Text = schemeMsg[5];
                        textBox_energyCap.Text = schemeMsg[6];
                        textBox_setEnergy.Text = schemeMsg[7];
                        //schemeMsg[0]=
                    }
                    else MessageBox.Show("read msg not meet the spec");
                }
                else MessageBox.Show("read msg is empty");
            }
            catch { }

            return schemeMsg;
        }

        private void setScheme_Feedback(string[] schemeMsg)
        {
            if (comboBox_scheme.SelectedItem == null)
            {
                MessageBox.Show("未選擇參數");
                return;
            }

            string selected_scheme = comboBox_scheme.SelectedItem.ToString();

            try
            {
                SendCommand($"RHSC {selected_scheme}:{schemeMsg[0]},{schemeMsg[1]},{schemeMsg[2]},{schemeMsg[3]},{schemeMsg[4]},{schemeMsg[5]},{schemeMsg[6]}");  //set laser scheme's parameter

                if (schemeMsg.Length == 8)
                {
                    textBox_feedBack.Text = schemeMsg[0];
                    textBox_inputPower.Text = schemeMsg[1];
                    textBox_peakPower.Text = schemeMsg[2];
                    textBox_repetition.Text = schemeMsg[3];
                    textBox_firingTimes.Text = schemeMsg[4];
                    textBox_LowerEnergy.Text = schemeMsg[5];
                    textBox_energyCap.Text = schemeMsg[6];
                    //schemeMsg[0]=
                }
                else MessageBox.Show("read msg not meet the spec");
            }
            catch { }
        }
    }
}
