using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using Accord.Video.FFMPEG;
using AForge.Vision.Motion;

namespace CameraUSBv2
{
    public partial class Form1 : Form
    {
        FilterInfoCollection videoDevicesList;
        VideoCaptureDevice camera;

        VideoFileWriter writer = null;
        MotionDetector detector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());

        bool isRecording = false;

        public Form1()
        {
            InitializeComponent();
            SearchButton_Click(null, null);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            CameraSelectComboBox.Items.Clear();
            videoDevicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevicesList)
            {
                CameraSelectComboBox.Items.Add(videoDevice.Name);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            camera = new VideoCaptureDevice(videoDevicesList[CameraSelectComboBox.SelectedIndex].MonikerString);
            camera.NewFrame += new AForge.Video.NewFrameEventHandler(OnNewFrame);
            camera.Stop();
            camera.Start();
        }

        private void RunMethodOnCurrentThread(Action action)
        {
            try
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    action();
                }));
            }
            catch
            {

            }
        }

        private void OnNewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            if (GrayscaleCheckBox.Checked)
            {
                AForge.Imaging.Filters.Grayscale filter = new Grayscale(0.5, 0.5, 0.5);
                bitmap = filter.Apply(bitmap);
            }

            if (MotionCheckBox.Checked)
            {
                var detectionLevel = detector.ProcessFrame(bitmap);
                RunMethodOnCurrentThread(() => label1.Text = detectionLevel.ToString("0.00%"));
                if (detectionLevel > 0.02)
                {
                    DetectionPictureBox.BackColor = Color.Red;
                }
                else
                {
                    DetectionPictureBox.BackColor = Color.Green;
                }
            }

            pictureBox1.Image = bitmap;


            if (isRecording)
            {
                try
                {
                    var toSave = pictureBox1.Image.Clone();
                    writer.WriteVideoFrame((Bitmap)toSave);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void StartRecordButton_Click(object sender, EventArgs e)
        {
            if (camera is null) return;
            if (camera.IsRunning == false) return;
            if (isRecording == true) return;

            saveFileDialog1.Filter = "Avi Files (*.avi)|*.avi";
            saveFileDialog1.Title = "Save a Video File";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            try
            {
                writer = new VideoFileWriter();

                writer.Open(saveFileDialog1.FileName, pictureBox1.Image.Width, pictureBox1.Image.Height, 15, VideoCodec.MPEG4);
                isRecording = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            StopRecordButton.Enabled = true;
            StartRecordButton.Enabled = false;
        }

        private void StopRecordButton_Click(object sender, EventArgs e)
        {
            if (isRecording == false) return;
            writer.Close();
            writer.Dispose();


            StopRecordButton.Enabled = false;
            StartRecordButton.Enabled = true;

            isRecording = false;
        }

        private void ScreenshotButton_Click(object sender, EventArgs e)
        {
            Bitmap picture = (Bitmap)pictureBox1.Image;
            saveFileDialog1.Filter = "JPEG|*.jpeg";
            saveFileDialog1.Title = "Save an Image File";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
            picture.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            fs.Close();
        }
    }

}