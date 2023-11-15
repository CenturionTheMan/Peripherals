using System;
using System.Threading;
using System.IO.Ports;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Modems;

/*
- ATA - odbieranie polaczen
- ATD{numer} - wybiera dany numer i probuje nawiazac polaczenie
- ATH - zarwanie polaczenia
- ATSr=n - przypisanie do rejestru wybranej wartosci
- ATO - powrot z trybu komend
- ATZ - powrot do ustawien poczatkowych modemu
- AT&V - wpisanie konfiguracji
- ATS2? - czary??
*/

public partial class Form1 : Form
{
    public const string PORT_NAME = "COM1";
    public const Parity PARITY = Parity.None;
    public const int DATA_BITS = 8;
    public const int BAUD_RATE = 9600;
    public const StopBits STOP_BITS = StopBits.One;
    public const Handshake HANDSHAKE = Handshake.RequestToSend;
    public const int WRITE_TIMEOUT = 500;
    public const int READ_TIMEOUT = 500;



    public readonly Color WARNING = Color.Red;
    public readonly Color DEFAULT = Color.Black;
    public readonly Color HIGHLIGHT = Color.BlueViolet;
    public readonly Color RESULT = Color.MediumSeaGreen;


    private SerialPort mainModemPort = new();
    private bool isGuestConnected = false;


    public Form1()
    {
        InitializeComponent();
    }


    /// <summary>
    /// Function will write given message in message log (GUI)
    /// </summary>
    /// <param name="message">Message to write</param>
    public void AddTextToMessageLog(string message, Color? textColor = null)
    {
        Color col = (textColor.HasValue) ? textColor.Value : DEFAULT;
        message = message.Replace("\n", Environment.NewLine);

        RunMethodOnCurrentThread(() => {
            messageLogTextBox.SelectionColor = col;
            messageLogTextBox.AppendText(message);
        });
    }

    /// <summary>
    /// Little workover for adding text from different thread
    /// </summary>
    /// <param name="action"></param>
    private void RunMethodOnCurrentThread(Action action)
    {
        this.Invoke(new MethodInvoker(() =>
        {
            action();
        }));
    }



    private void connectPortButton_Click(object sender, EventArgs e)
    {
        if(mainModemPort.IsOpen)
        {
            AddTextToMessageLog("Main modem already connected!\n");
            return;
        }

        mainModemPort.PortName = PORT_NAME;
        mainModemPort.Parity = PARITY;
        mainModemPort.DataBits = DATA_BITS;
        mainModemPort.BaudRate = BAUD_RATE;
        mainModemPort.StopBits = STOP_BITS;
        mainModemPort.Handshake = HANDSHAKE;
        mainModemPort.DataReceived += OnDataReceived;
        mainModemPort.RtsEnable = true;
        mainModemPort.DtrEnable = true;
        mainModemPort.WriteTimeout = WRITE_TIMEOUT;
        mainModemPort.ReadTimeout = READ_TIMEOUT;

        try
        {
            mainModemPort.Open();
            //port.Write("ATE0\r"); // wylaczenie ECHA
            AddTextToMessageLog("Main modem connection acquired\n", HIGHLIGHT);
            portModemStatusLabel.Text = "CONNECTED";

            disconnectPortButton.Enabled = true;
            connectPortButton.Enabled = false;
        }
        catch (Exception ex)
        {
            AddTextToMessageLog($"Error occured!\n{ex.Message}", WARNING);
            throw;
        }
    }

    public void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        var data = mainModemPort.ReadExisting();
        if(data.Contains("CON"))
        {
            isGuestConnected = true;
            AddTextToMessageLog("Main modem connected to guest modem.\n", HIGHLIGHT);
        }

        AddTextToMessageLog($"Guest: {data}\n");
    }

    

    private void disconnectPortButton_Click(object sender, EventArgs e)
    {
        if(mainModemPort.IsOpen == false)
        {
            return;
        }

        mainModemPort.Write("ATH\r");
        mainModemPort.Close();
        isGuestConnected = false;
        AddTextToMessageLog("Main modem disconnected\n", HIGHLIGHT);

        disconnectPortButton.Enabled = false;
        connectPortButton.Enabled = true;
    }

    private void sendButton_Click(object sender, EventArgs e)
    {
        if(mainModemPort.IsOpen)
        {
            var text = userInputMessageBox.Text;
            mainModemPort.Write(text);
            AddTextToMessageLog($"Me: {text}\n");
        }
        else
        {
            AddTextToMessageLog($"Main modem is not connected!\n", WARNING);
        }
    }

    private void callButton_Click(object sender, EventArgs e)
    {
        if(mainModemPort.IsOpen)
        {
            mainModemPort.Write("atd" + guestModemNumbertextBox.Text + "\r");
        }
        else
        {
            AddTextToMessageLog($"Main modem is not connected!\n", WARNING);
        }
    }

    private void answerButton_Click(object sender, EventArgs e)
    {
        if (mainModemPort.IsOpen)
        {
            isGuestConnected = true;
            mainModemPort.Write("ATA\r");
            AddTextToMessageLog("Waiting for guest connection...\n", HIGHLIGHT);
        }
        else
        {
            AddTextToMessageLog($"Main modem is not connected!\n", WARNING);
        }
    }

    private void writingModeButton_Click(object sender, EventArgs e)
    {
        if (mainModemPort.IsOpen == false || isGuestConnected == false) return;

        AddTextToMessageLog("Changing to command mode ...\n", HIGHLIGHT);

        mainModemPort.Write("+");
        Thread.Sleep(100);
        mainModemPort.Write("+");
        Thread.Sleep(100);
        mainModemPort.Write("+");
        Thread.Sleep(100);

        AddTextToMessageLog("Command mode activated\n", HIGHLIGHT);
    }

    private void commandModeButton_Click(object sender, EventArgs e)
    {
        if (mainModemPort.IsOpen == false || isGuestConnected == false) return;
        mainModemPort.Write("ato\r");
        AddTextToMessageLog("Writing mode activated\n", HIGHLIGHT);
    }

    private void breakConnetionButton_Click(object sender, EventArgs e)
    {
        if (mainModemPort.IsOpen == false || isGuestConnected == false) return;

        AddTextToMessageLog("Disconnecting from guest...\n", HIGHLIGHT);

        mainModemPort.Write("+");
        Thread.Sleep(100);
        mainModemPort.Write("+");
        Thread.Sleep(100);
        mainModemPort.Write("+");
        Thread.Sleep(1000);
        mainModemPort.Write("ATH\r");
        Thread.Sleep(1000);
        mainModemPort.Write("ATH\r");
        isGuestConnected = false;

        AddTextToMessageLog("Disconnected\n", HIGHLIGHT);
    }
}