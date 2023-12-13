using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;


namespace MusicCardNet
{
    public partial class Form1 : Form
    {
        private SoundPlayer spPlayer = null;
        private string fileToOpen = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            if(OpenFileDialog.ShowDialog() != DialogResult.OK)
                return;

            LoadedFileTextBox.Text = OpenFileDialog.FileName;
            fileToOpen = OpenFileDialog.FileName;

            //AxWindowsMediaPlayer.URL = OpenFileDialog.FileName;
            AxWindowsMediaPlayer.currentMedia = AxWindowsMediaPlayer.newMedia(OpenFileDialog.FileName);

            ShowWavHeaders();
        }

        private void PlaySoundButton_Click(object sender, EventArgs e)
        {
            if (fileToOpen == null) return;

            if (spPlayer == null)
            {
                spPlayer = new SoundPlayer(fileToOpen);
                spPlayer.Play();
            }
        }

        private void StopSoundButton_Click(object sender, EventArgs e)
        {
            if (fileToOpen == null) return;
            if (spPlayer == null) return;
            spPlayer.Stop();
            spPlayer = null;
        }

        private void ShowWavHeaders()
        {
            if (fileToOpen == null) return;

            StringBuilder stringBuilder = new StringBuilder();

            using (var fileStream = new FileStream(fileToOpen, FileMode.Open, FileAccess.Read))

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
            
            WavHeadersRichTextBox.Text = stringBuilder.ToString();
        }

        private string ByteArrToString(byte[] bytes)
        {
            return System.Text.Encoding.Default.GetString(bytes);
        }
    }
}
