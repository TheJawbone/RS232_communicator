// The following code is based on an example from Microsoft's Developer Network

using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

public class PortChat
{
    static bool _continue;
    static bool _ackRecievied;
    static bool _awaitingAck;
    static int _pingTimeout = 500;
    static SerialPort _serialPort;
    static Stopwatch stopwatch;

    public static void Main()
    {
        stopwatch = new Stopwatch();
        _ackRecievied = false;
        _awaitingAck = false;
        string name;
        string message;
        StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
        Thread readThread = new Thread(Read);

        // Create a new SerialPort object with default settings.
        _serialPort = new SerialPort();

        // Allow the user to set the appropriate properties.
        _serialPort.PortName = SetPortName(_serialPort.PortName);
        _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
        _serialPort.Parity = SetPortParity(_serialPort.Parity);
        _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
        _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
        _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);
        _serialPort.NewLine = SetTerminator(_serialPort.NewLine);

        // Set the read/write timeouts
        _serialPort.ReadTimeout = 500;
        _serialPort.WriteTimeout = 500;

        _serialPort.Open();
        _continue = true;
        readThread.Start();

        Console.Write("Name: ");
        name = Console.ReadLine();

        Console.WriteLine("Type QUIT to exit or PING to test connection");

        while (_continue)
        {
            message = Console.ReadLine();

            if (stringComparer.Equals("quit", message))
            {
                _continue = false;
            }
            else if (stringComparer.Equals("ping", message))
            {
                stopwatch.Start();
                _awaitingAck = true;
                _serialPort.WriteLine(String.Format(message));
                long stopwatchValue = 0;
                while(stopwatchValue <= _pingTimeout)
                {
                    stopwatchValue = stopwatch.ElapsedMilliseconds;
                    if(_ackRecievied)
                    {
                        _awaitingAck = false;
                        _ackRecievied = false;
                        stopwatch.Reset();
                        break;
                    }
                }
                if(stopwatchValue >= _pingTimeout)
                {
                    Console.WriteLine("Ping timed out at " + _pingTimeout + "ms");
                    _awaitingAck = false;
                    stopwatch.Reset();
                }
            }
            else
            {
                _serialPort.WriteLine(
                    String.Format("<{0}>: {1}", name, message));
            }
        }

        readThread.Join();
        _serialPort.Close();
    }

    public static void Read()
    {
        while (_continue)
        {
            try
            {
                string message = _serialPort.ReadLine();
                if (message.Equals("ping") || message.Equals("PING"))
                {
                    _serialPort.WriteLine("ack");
                }
                else if (message.Equals("ack") && _awaitingAck)
                {
                    Console.WriteLine("Ping successfull, time: " + stopwatch.ElapsedMilliseconds + "ms");
                    _ackRecievied = true;
                }
                else if (!message.Equals("ack"))
                {
                    Console.WriteLine(message);
                }
            }
            catch (TimeoutException) { }
        }
    }

    // Display Port values and prompt user to enter a port.
    public static string SetPortName(string defaultPortName)
    {
        string portName;

        Console.WriteLine("Available Ports:");
        foreach (string s in SerialPort.GetPortNames())
        {
            Console.WriteLine("   {0}", s);
        }

        Console.Write("Enter COM port value (Default: {0}): ", defaultPortName);
        portName = Console.ReadLine();

        if (portName == "" || !(portName.ToLower()).StartsWith("com"))
        {
            portName = defaultPortName;
        }
        return portName;
    }
    // Display BaudRate values and prompt user to enter a value.
    public static int SetPortBaudRate(int defaultPortBaudRate)
    {
        string baudRate;

        Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
        baudRate = Console.ReadLine();

        if (baudRate == "")
        {
            baudRate = defaultPortBaudRate.ToString();
        }

        return int.Parse(baudRate);
    }

    // Display PortParity values and prompt user to enter a value.
    public static Parity SetPortParity(Parity defaultPortParity)
    {
        string parity;

        Console.WriteLine("Available Parity options:");
        foreach (string s in Enum.GetNames(typeof(Parity)))
        {
            Console.WriteLine("   {0}", s);
        }

        Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
        parity = Console.ReadLine();

        if (parity == "")
        {
            parity = defaultPortParity.ToString();
        }

        return (Parity)Enum.Parse(typeof(Parity), parity, true);
    }
    // Display DataBits values and prompt user to enter a value.
    public static int SetPortDataBits(int defaultPortDataBits)
    {
        string dataBits;

        Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
        dataBits = Console.ReadLine();

        if (dataBits == "")
        {
            dataBits = defaultPortDataBits.ToString();
        }

        return int.Parse(dataBits.ToUpperInvariant());
    }

    // Display StopBits values and prompt user to enter a value.
    public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
    {
        string stopBits;

        Console.WriteLine("Available StopBits options:");
        foreach (string s in Enum.GetNames(typeof(StopBits)))
        {
            Console.WriteLine("   {0}", s);
        }

        Console.Write("Enter StopBits value (None is not supported and \n" +
         "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
        stopBits = Console.ReadLine();

        if (stopBits == "")
        {
            stopBits = defaultPortStopBits.ToString();
        }

        return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
    }
    public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
    {
        string handshake;

        Console.WriteLine("Available Handshake options:");
        foreach (string s in Enum.GetNames(typeof(Handshake)))
        {
            Console.WriteLine("   {0}", s);
        }

        Console.Write("Enter Handshake value (Default: {0}):", defaultPortHandshake.ToString());
        handshake = Console.ReadLine();

        if (handshake == "")
        {
            handshake = defaultPortHandshake.ToString();
        }

        return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
    }

    public static string SetTerminator(string defaultTerminator)
    {
        string terminator;

        Console.Write("Enter terminator (Default: {0}): ", EscapeIt(defaultTerminator));
        terminator = Console.ReadLine();
        terminator = ReEscapeIt(terminator);

        if (terminator == "")
        {
            terminator = defaultTerminator;
        }
        return terminator;
    }

    public static string EscapeIt(string value)
    {
        var builder = new System.Text.StringBuilder();
        foreach (var cur in value)
        {
            switch (cur)
            {
                case '\t':
                    builder.Append(@"\t");
                    break;
                case '\r':
                    builder.Append(@"\r");
                    break;
                case '\n':
                    builder.Append(@"\n");
                    break;
                default:
                    builder.Append(cur);
                    break;
            }
        }
        return builder.ToString();
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
}