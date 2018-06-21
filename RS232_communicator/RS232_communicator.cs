using RS232_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS232_communicator
{
    public partial class RS232_communicator : Form
    {
        bool _ackRecievied;
        bool _awaitingAck;
        bool _isConnected;
        bool _continue;
        int _pingTimeout;
        SerialPort _serialPort;
        Stopwatch _stopwatch;
        Thread _readThread;

        public RS232_communicator()
        {
            InitializeComponent();

            // Set title bar text
            Text = "RS232 communicator";

            // Put available port names into the combo box
            foreach(string portName in SerialPort.GetPortNames())
            {
                ComboBoxPort.Items.Add(portName);
            }

            // Set default values for combo boxes and text fields
            ComboBoxPort.Text = "COM1";
            ComboBoxBaudRate.Text = "9600";
            ComboBoxDataFieldSize.Text = "8";
            ComboBoxParityControl.Text = "N";
            ComboBoxStopBits.Text = "1";
            ComboBoxHandshake.Text = "None";
            TextFieldTerminator.Text = "\\n";
            TextFieldPingTimeout.Text = "500";

            // Initially disable sending data
            TextBoxDataSend.Enabled = false;
            ButtonSend.Enabled = false;

            // Instantiate fields
            _serialPort = new SerialPort();
            _stopwatch = new Stopwatch();

            // Assign initial values to fields
            _isConnected = false;
            _ackRecievied = false;
            _awaitingAck = false;
        }

        private void ButtonConnectDisconnect_Click(object sender, EventArgs e)
        {
            if(!_isConnected)
            {
                // Change button text set isConnected flag
                ButtonConnectDisconnect.Text = "Disconnect";
                _isConnected = true;

                // Disable connection properties controls
                ComboBoxBaudRate.Enabled = false;
                ComboBoxDataFieldSize.Enabled = false;
                ComboBoxHandshake.Enabled = false;
                ComboBoxParityControl.Enabled = false;
                ComboBoxPort.Enabled = false;
                ComboBoxStopBits.Enabled = false;
                TextFieldPingTimeout.Enabled = false;
                TextFieldTerminator.Enabled = false;

                // Enable sending controls
                TextBoxDataSend.Enabled = true;
                ButtonSend.Enabled = true;

                // Set port parameters based on values in form controls
                _serialPort.PortName = ComboBoxPort.Text;
                _serialPort.BaudRate = Int32.Parse(ComboBoxBaudRate.Text);
                switch(ComboBoxParityControl.Text)
                {
                    case "N":
                        _serialPort.Parity = Parity.None;
                        break;
                    case "E":
                        _serialPort.Parity = Parity.Even;
                        break;
                    case "O":
                        _serialPort.Parity = Parity.Odd;
                        break;
                }
                _serialPort.DataBits = Int32.Parse(ComboBoxDataFieldSize.Text);
                switch(ComboBoxStopBits.Text)
                {
                    case "1":
                        _serialPort.StopBits = StopBits.One;
                        break;
                    case "2":
                        _serialPort.StopBits = StopBits.Two;
                        break;
                }
                switch(ComboBoxHandshake.Text)
                {
                    case "None":
                        _serialPort.Handshake = Handshake.None;
                        break;
                    case "RTS":
                        _serialPort.Handshake = Handshake.RequestToSend;
                        break;
                    case "XOn/XOff":
                        _serialPort.Handshake = Handshake.XOnXOff;
                        break;
                }
                _serialPort.NewLine = ReEscapeIt(TextFieldTerminator.Text);
                _pingTimeout = Int32.Parse(TextFieldPingTimeout.Text);

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;

                // Open port and start the reading loop
                _serialPort.Open();
                _continue = true;
                _readThread = new Thread(Read);
                _readThread.Start();
            }

            else
            {
                // Change button text and set isConnected flag
                ButtonConnectDisconnect.Text = "Connect";
                _isConnected = false;
                
                // Enable controls
                ComboBoxBaudRate.Enabled = true;
                ComboBoxDataFieldSize.Enabled = true;
                ComboBoxHandshake.Enabled = true;
                ComboBoxParityControl.Enabled = true;
                ComboBoxPort.Enabled = true;
                ComboBoxStopBits.Enabled = true;
                TextFieldPingTimeout.Enabled = true;
                TextFieldTerminator.Enabled = true;

                // Disable sending controls
                TextBoxDataSend.Enabled = false;
                ButtonSend.Enabled = false;

                // Close port and break reading loop
                _continue = false;
                _readThread.Join();
                _serialPort.Close();
            }
        }

        public void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    if (message.Equals("ping"))
                    {
                        TextBoxLog.Text += ("PING recieved, returning ACK...\r\n");
                        _serialPort.WriteLine("ack");
                    }
                    else if (message.Equals("ack") && _awaitingAck)
                    {
                        _ackRecievied = true;
                    }
                    else if (!message.Equals("ack"))
                    {
                        TextBoxDataRecieved.Text += message + "\r\n";
                    }
                }
                catch (TimeoutException) { }
            }
        }

        public static string ReEscapeIt(string value)
        {
            string retVal = "";
            for (int i = 0; i <= value.Length - 2; i++)
            {
                string substring = value.Substring(i, 2);
                switch (substring)
                {
                    case "\\t":
                        retVal += "\t";
                        break;
                    case "\\r":
                        retVal += "\r";
                        break;
                    case "\\n":
                        retVal += "\n";
                        break;
                    default:
                        retVal += substring;
                        i++;
                        break;
                }
            }
            return retVal;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine(TextBoxDataSend.Text);
        }

        private void ButtonPing_Click(object sender, EventArgs e)
        {
            TextBoxLog.Text += "Sending PING...\r\n";
            _serialPort.WriteLine("ping");
            _awaitingAck = true;
            long stopwatchValue = 0;
            _stopwatch.Start();
            while (stopwatchValue <= _pingTimeout)
            {
                stopwatchValue = _stopwatch.ElapsedMilliseconds;
                if (_ackRecievied)
                {
                    _awaitingAck = false;
                    _ackRecievied = false;
                    TextBoxLog.Text += "Ping successful, round trip delay: " + _stopwatch.ElapsedMilliseconds + "ms\r\n";
                    _stopwatch.Reset();
                    stopwatchValue = 0;
                    break;
                }
            }
            if (stopwatchValue >= _pingTimeout && _awaitingAck)
            {
                TextBoxLog.Text += ("Ping timed out at " + _pingTimeout + "ms\r\n");
                _awaitingAck = false;
                _stopwatch.Reset();
            }
        }

        private void ButtonClearDataRecieved_Click(object sender, EventArgs e)
        {
            TextBoxDataRecieved.Text = "";
        }

        private void ButtonClearLog_Click(object sender, EventArgs e)
        {
            TextBoxLog.Text = "";
        }
    }
}
