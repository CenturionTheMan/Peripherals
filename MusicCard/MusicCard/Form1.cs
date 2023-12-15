using NAudio;
using SharpDX.XAudio2;
using SharpDX.Multimedia;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio.Wave;
using System.Text;
using SharpDX.XAPO;
using SharpDX.XAPO.Fx;
using System.Collections;
using System.IO;
using System.Globalization;


namespace MusicCard;

public partial class Form1 : Form
{
    //import winmm.dll - PlaySound()
    [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
    private static extern bool PlaySound(string pszSound, System.IntPtr hmod, PlaySoundFlags flags);

    //Flags for PlaySound()
    [System.Flags]
    public enum PlaySoundFlags : int
    {
        SND_SYNC = 0x0000,
        SND_ASYNC = 0x0001,
        SND_NODEFAULT = 0x0002,
        SND_LOOP = 0x0008,
        SND_NOSTOP = 0x0010,
        SND_NOWAIT = 0x00002000,
        SND_FILENAME = 0x00020000,
        SND_RESOURCE = 0x00040004
    }

    //loaded file
    private string? filePath = null; 

    //ActiveX
    SourceVoice? sourceVoice = null;
    
    //WaveForm - Play sound
    WaveOut waveOutDevice = new WaveOut();
    AudioFileReader? audioFileReader = null;

    //WaveFOrm record
    WaveIn? waveIn = null;
    WaveFileWriter? waveWriter = null;     

    //timer count
    long recordTime = 0;

    public Form1()
    {
        InitializeComponent();

        startRecordButton.Enabled = true;
        stopRecordButton.Enabled = false;
    }

    /// <summary>
    /// Load data from open file dialog
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void loadFileButton_Click(object sender, EventArgs e)
    {
        var res = openFileDialog.ShowDialog();
        if (res != DialogResult.OK) return;

        filePath = openFileDialog.FileName;
        loadedFileTextBox.Text = openFileDialog.SafeFileName;
        if (openFileDialog.SafeFileName.ToLower().Contains(".wav"))
            ShowWavHeaders(); //show headers
        else
            ShowMPEGHeaders(); //show headers

    }

    /// <summary>
    /// Play direct sound
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void playSoundDirectButton_Click(object sender, EventArgs e)
    {
        if (filePath == null) return;
        PlaySound(filePath, new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
    }

    /// <summary>
    /// Stop direct sound
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void stopSoundDirectButton_Click(object sender, EventArgs e)
    {
        PlaySound(null, (IntPtr)null, PlaySoundFlags.SND_ASYNC); //set path to null
    }

    /// <summary>
    /// ActiveX play sound
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void playSoundActiveButton_Click(object sender, EventArgs e)
    {
        if (filePath == null) return;

        if (sourceVoice != null)
        {
            sourceVoice.Stop();
            sourceVoice.Dispose();
        }

        try
        {
            var xaudio = new XAudio2();

            // master voice
            var masteringVoice = new MasteringVoice(xaudio);

            // read file as stream
            using (var fileStream = File.OpenRead(filePath))
            {
                var soundStream = new SoundStream(fileStream);
                var waveFormat = soundStream.Format;
                var buffer = new AudioBuffer
                {
                    Stream = soundStream.ToDataStream(),
                    AudioBytes = (int)soundStream.Length,
                    Flags = SharpDX.XAudio2.BufferFlags.EndOfStream
                };

                sourceVoice = new SourceVoice(xaudio, waveFormat, true);


                if (echoCheckBox.Checked)
                {
                    var effectDes = new EffectDescriptor(new Echo(xaudio));
                    sourceVoice.SetEffectChain(effectDes);
                }

                sourceVoice.SubmitSourceBuffer(buffer, soundStream.DecodedPacketsInfo);
                soundStream.Dispose();

                sourceVoice.Start();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("ERROR!\n" + ex.Message);
        }

    }

    /// <summary>
    /// ActiveX stop sound
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void stopSoundActiveButton_Click(object sender, EventArgs e)
    {
        if (sourceVoice == null) return;
        sourceVoice.Stop();
        sourceVoice.Dispose();
    }

    /// <summary>
    /// WaveForm play sound
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void playSoundWaveButton_Click(object sender, EventArgs e)
    {
        if (audioFileReader != null)
        {
            waveOutDevice.Stop();
            audioFileReader.Close();
            audioFileReader = null;
        }

        audioFileReader = new(filePath);
        waveOutDevice.Init(audioFileReader);

        waveOutDevice.Play();
    }

    /// <summary>
    /// WaveForm stop sound
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void stopSoundWaveButton_Click(object sender, EventArgs e)
    {
        if (audioFileReader == null) return;

        waveOutDevice.Stop();
        audioFileReader.Close();

        audioFileReader = null;
    }

    /// <summary>
    /// Timer update for recording
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer_Tick(object sender, EventArgs e)
    {
        recordTime += 100;
        //DateTime.Now.ToString("")
        long secAmount = recordTime / 1000;
        long minAmount = secAmount / 60;
        timerTextBox.Text = $"{minAmount}:{secAmount}:{recordTime % 1000}";

    }

    /// <summary>
    /// Start recording 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void startRecordButton_Click(object sender, EventArgs e)
    {
        if(saveFileDialog.ShowDialog() != DialogResult.OK) return;

        recordTime = 0;
        timer.Start();

        waveIn = new();
        waveIn.WaveFormat = new NAudio.Wave.WaveFormat(44100, 1); //set file format
        waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveInSafeRecord);
        waveWriter = new WaveFileWriter(saveFileDialog.FileName, waveIn.WaveFormat); //save to file

        waveIn.StartRecording();
        startRecordButton.Enabled = false;
        stopRecordButton.Enabled = true;
    }

    /// <summary>
    /// Update wav file while recording
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void waveInSafeRecord(object sender, WaveInEventArgs e)
    {
        if (waveWriter != null)
        {
            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }
    }

    /// <summary>
    /// Stop recording
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void stopRecordButton_Click(object sender, EventArgs e)
    {
        if (waveIn == null || waveWriter == null) return;
        timer.Stop();

        waveIn.StopRecording();
        waveIn.Dispose();
        waveWriter.Dispose();

        startRecordButton.Enabled = true;
        stopRecordButton.Enabled = false;
    }

    /// <summary>
    /// Show headers
    /// </summary>
    private void ShowWavHeaders()
    {
        if (filePath == null) return;

        StringBuilder stringBuilder = new StringBuilder();

        using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))

        using (var binaryReader = new BinaryReader(fileStream))
        {
            try
            {
                //https://docs.fileformat.com/pl/audio/wav/#google_vignette
                stringBuilder.AppendLine($"RIFF ->{ByteArrToString(binaryReader.ReadBytes(4))}");
                stringBuilder.AppendLine($"File size -> {binaryReader.ReadUInt32()}");
                stringBuilder.AppendLine($"File type -> {ByteArrToString(binaryReader.ReadBytes(4))}");
                stringBuilder.AppendLine($"Format chunk marker -> {ByteArrToString(binaryReader.ReadBytes(4))}");
                stringBuilder.AppendLine($"Length of format data as listed above -> {binaryReader.ReadUInt32()}");
                stringBuilder.AppendLine($"Type of format -> {binaryReader.ReadUInt16()}");
                stringBuilder.AppendLine($"Number of Channels -> {binaryReader.ReadUInt16()}");
                stringBuilder.AppendLine($"Sample rate -> {binaryReader.ReadUInt32()}");
                stringBuilder.AppendLine($"Byte per sec -> {binaryReader.ReadUInt32()}");
                stringBuilder.AppendLine($"Bits per sample -> {binaryReader.ReadUInt16()}");
                binaryReader.ReadUInt16();
                stringBuilder.AppendLine($"Data ID -> {ByteArrToString(binaryReader.ReadBytes(4))}");
                stringBuilder.AppendLine($"Data size -> {binaryReader.ReadUInt32()}");
            }
            finally
            {
                binaryReader.Close();
                fileStream.Close();
            }
        }

        headersRichTextBox.Text = stringBuilder.ToString();
    }

    private void ShowMPEGHeaders()
    {
        if (filePath == null) return;

        string res = "";

        using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            using (var binaryReader = new BinaryReader(fileStream))
            {
                try
                {
                    var bytes = binaryReader.ReadBytes(4);
                    var bits = new BitArray(bytes);
                    res += $"Frame synchronizer: {BitArrIntoString(bits, 0, 10)}\n";
                    res += $"MPEG version ID: {BitArrIntoString(bits, 11, 12)}\n";
                    res += $"Layer: {BitArrIntoString(bits, 13, 14)}\n";
                    res += $"CRC Protection: {BitArrIntoString(bits, 15, 15)}\n";
                    res += $"Bitrate index: {BitArrIntoString(bits, 16, 19)}\n";
                    res += $"Samplig rate frequency index: {BitArrIntoString(bits, 20, 21)}\n";
                    res += $"Padding: {BitArrIntoString(bits, 22, 22)}\n";
                    res += $"Private bit: {BitArrIntoString(bits, 23, 23)}\n";
                    res += $"Channel: {BitArrIntoString(bits, 24, 25)}\n";
                    res += $"Mode extension: {BitArrIntoString(bits, 26, 27)}\n";
                    res += $"Copyright: {BitArrIntoString(bits, 28, 28)}\n";
                    res += $"Original: {BitArrIntoString(bits, 29, 29)}\n";
                    res += $"Emphasis: {BitArrIntoString(bits, 30, 31)}\n";
                    res += "\n\n";
                }
                finally
                {
                    binaryReader.Close();
                }
            }

            //byte[] data = new byte[128];
            //fileStream.Seek(-128, SeekOrigin.End);
            //fileStream.Read(data, 0, 128);
            //fileStream.Close();

            //res += $"Tag identification: {ByteArrToString(data,0,127)}";

        }


        headersRichTextBox.Text = res;
    }

    private string BitArrIntoString(BitArray bitArray, int from, int to)
    {
        string res = "";
        for (int i = from; i <= to; i++)
        {
            res += bitArray[i] ? "1" : "0";
        }
        return res;
    }

    private string ByteArrToString(byte[] bytes, int from, int to)
    {
        StringBuilder stringBuilder = new();
        for (int i = from; i <= to; i++)
        {
            var tmp = Convert.ToChar(bytes[i]);
            stringBuilder.Append(tmp);
        }
        return stringBuilder.ToString();
    }

    private string ByteArrToString(byte[] bytes)
    {
        return Encoding.Default.GetString(bytes);
    }


}
