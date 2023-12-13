using NAudio;
using SharpDX.XAudio2;
using SharpDX.Multimedia;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio.Wave;

namespace MusicCard;

public partial class Form1 : Form
{
    //import winmm.dll do PlaySound()
    [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
    private static extern bool PlaySound(string pszSound, System.IntPtr hmod, PlaySoundFlags flags);

    //flagi dla PlaySound()
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


    private string? filePath = null;
    SourceVoice? sourceVoice = null;
    WaveOut waveOutDevice = new WaveOut(); //obiekt urządzenia
    WaveIn? waveIn = null; //obiekt do nagrywania dźwięku
    WaveFileWriter? waveWriter = null; //obiekt do obsługi nagrywania
    AudioFileReader? audioFileReader = null; //obiekt do czytania z pliku
    long recordTime = 0;

    public Form1()
    {
        InitializeComponent();

        startRecordButton.Enabled = true;
        stopRecordButton.Enabled = false;
    }


    private void loadFileButton_Click(object sender, EventArgs e)
    {
        var res = openFileDialog.ShowDialog();
        if (res != DialogResult.OK) return;

        filePath = openFileDialog.FileName;
        loadedFileTextBox.Text = openFileDialog.SafeFileName;
    }

    private void playSoundDirectButton_Click(object sender, EventArgs e)
    {
        if (filePath == null) return;
        PlaySound(filePath, new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
    }


    private void stopSoundDirectButton_Click(object sender, EventArgs e)
    {
        PlaySound(null, (IntPtr)null, PlaySoundFlags.SND_ASYNC); //ustawienie ścieżki na NULL
    }

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
            // Inicjalizacja XAudio2
            var xaudio = new XAudio2();

            // Tworzenie głównego głosu
            var masteringVoice = new MasteringVoice(xaudio);

            // Wczytanie pliku dźwiękowego jako strumień
            using (var fileStream = File.OpenRead(filePath))
            {
                // Tworzenie głosu dla dźwięku
                var soundStream = new SoundStream(fileStream);
                var waveFormat = soundStream.Format;
                var buffer = new AudioBuffer
                {
                    Stream = soundStream.ToDataStream(),
                    AudioBytes = (int)soundStream.Length,
                    Flags = BufferFlags.EndOfStream
                };

                // Tworzenie głosu dla dźwięku
                sourceVoice = new SourceVoice(xaudio, waveFormat, true);
                sourceVoice.SubmitSourceBuffer(buffer, soundStream.DecodedPacketsInfo);
                soundStream.Dispose();

                // Odtwarzanie dźwięku
                sourceVoice.Start();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }

    }

    private void stopSoundActiveButton_Click(object sender, EventArgs e)
    {
        if (sourceVoice == null) return;
        sourceVoice.Stop();
        sourceVoice.Dispose();
    }

    private void playSoundWaveButton_Click(object sender, EventArgs e)
    {
        if (audioFileReader != null)
        {
            waveOutDevice.Stop();
            audioFileReader.Close();
            audioFileReader = null;
        }

        audioFileReader = new(filePath);
        waveOutDevice.Init(audioFileReader); //przekazanie pliku WAV do inicjacji

        waveOutDevice.Play(); //odtworzenie dźwięku
    }

    private void stopSoundWaveButton_Click(object sender, EventArgs e)
    {
        if (audioFileReader == null) return;

        waveOutDevice.Stop();
        audioFileReader.Close(); //zamknięcie strumienia danych

        audioFileReader = null;
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        recordTime += 100;
        //DateTime.Now.ToString("")
        long secAmount = recordTime / 1000;
        long minAmount = secAmount / 60;
        timerTextBox.Text = $"{minAmount}:{secAmount}:{recordTime % 1000}";

    }

    private void startRecordButton_Click(object sender, EventArgs e)
    {
        if(saveFileDialog.ShowDialog() != DialogResult.OK) return;

        recordTime = 0;
        timer.Start();

        waveIn = new();
        waveIn.WaveFormat = new NAudio.Wave.WaveFormat(44100, 1); //ustawienie formatu pliku
        waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveInSafeRecord);
        waveWriter = new WaveFileWriter(saveFileDialog.FileName, waveIn.WaveFormat); //zapisywanie danych do pliku

        waveIn.StartRecording(); //rozpoczęcie nagrywania
        startRecordButton.Enabled = false;
        stopRecordButton.Enabled = true;
    }

    private void waveInSafeRecord(object sender, WaveInEventArgs e)
    {
        if (waveWriter != null)
        {
            waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }
    }


    private void stopRecordButton_Click(object sender, EventArgs e)
    {
        timer.Stop();

        waveIn.StopRecording();
        waveIn.Dispose();
        waveWriter.Dispose();

        startRecordButton.Enabled = true;
        stopRecordButton.Enabled = false;
    }
}
