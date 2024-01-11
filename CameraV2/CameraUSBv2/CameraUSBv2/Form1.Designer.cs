using System.Drawing;
using System.Windows.Forms;

namespace CameraUSBv2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CameraSelectComboBox = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StartRecordButton = new System.Windows.Forms.Button();
            this.StopRecordButton = new System.Windows.Forms.Button();
            this.MotionCheckBox = new System.Windows.Forms.CheckBox();
            this.GrayscaleCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ScreenshotButton = new System.Windows.Forms.Button();
            this.DetectionPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(237, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CameraSelectComboBox
            // 
            this.CameraSelectComboBox.FormattingEnabled = true;
            this.CameraSelectComboBox.Location = new System.Drawing.Point(12, 54);
            this.CameraSelectComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraSelectComboBox.Name = "CameraSelectComboBox";
            this.CameraSelectComboBox.Size = new System.Drawing.Size(219, 24);
            this.CameraSelectComboBox.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 82);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(219, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start Camera";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartRecordButton
            // 
            this.StartRecordButton.Location = new System.Drawing.Point(12, 146);
            this.StartRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartRecordButton.Name = "StartRecordButton";
            this.StartRecordButton.Size = new System.Drawing.Size(219, 23);
            this.StartRecordButton.TabIndex = 3;
            this.StartRecordButton.Text = "Start Recording";
            this.StartRecordButton.UseVisualStyleBackColor = true;
            this.StartRecordButton.Click += new System.EventHandler(this.StartRecordButton_Click);
            // 
            // StopRecordButton
            // 
            this.StopRecordButton.Enabled = false;
            this.StopRecordButton.Location = new System.Drawing.Point(12, 173);
            this.StopRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopRecordButton.Name = "StopRecordButton";
            this.StopRecordButton.Size = new System.Drawing.Size(219, 23);
            this.StopRecordButton.TabIndex = 4;
            this.StopRecordButton.Text = "Stop Recording";
            this.StopRecordButton.UseVisualStyleBackColor = true;
            this.StopRecordButton.Click += new System.EventHandler(this.StopRecordButton_Click);
            // 
            // MotionCheckBox
            // 
            this.MotionCheckBox.AutoSize = true;
            this.MotionCheckBox.Location = new System.Drawing.Point(12, 270);
            this.MotionCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MotionCheckBox.Name = "MotionCheckBox";
            this.MotionCheckBox.Size = new System.Drawing.Size(101, 20);
            this.MotionCheckBox.TabIndex = 5;
            this.MotionCheckBox.Text = "Motion Filter";
            this.MotionCheckBox.UseVisualStyleBackColor = true;
            // 
            // GrayscaleCheckBox
            // 
            this.GrayscaleCheckBox.AutoSize = true;
            this.GrayscaleCheckBox.Location = new System.Drawing.Point(12, 122);
            this.GrayscaleCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrayscaleCheckBox.Name = "GrayscaleCheckBox";
            this.GrayscaleCheckBox.Size = new System.Drawing.Size(91, 20);
            this.GrayscaleCheckBox.TabIndex = 6;
            this.GrayscaleCheckBox.Text = "Grayscale";
            this.GrayscaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 10);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(219, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search for Camera";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // ScreenshotButton
            // 
            this.ScreenshotButton.Location = new System.Drawing.Point(12, 218);
            this.ScreenshotButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScreenshotButton.Name = "ScreenshotButton";
            this.ScreenshotButton.Size = new System.Drawing.Size(219, 23);
            this.ScreenshotButton.TabIndex = 8;
            this.ScreenshotButton.Text = "Screenshot";
            this.ScreenshotButton.UseVisualStyleBackColor = true;
            this.ScreenshotButton.Click += new System.EventHandler(this.ScreenshotButton_Click);
            // 
            // DetectionPictureBox
            // 
            this.DetectionPictureBox.BackColor = System.Drawing.Color.LimeGreen;
            this.DetectionPictureBox.Location = new System.Drawing.Point(15, 323);
            this.DetectionPictureBox.Name = "DetectionPictureBox";
            this.DetectionPictureBox.Size = new System.Drawing.Size(37, 33);
            this.DetectionPictureBox.TabIndex = 9;
            this.DetectionPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Motion Ratio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetectionPictureBox);
            this.Controls.Add(this.ScreenshotButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.GrayscaleCheckBox);
            this.Controls.Add(this.MotionCheckBox);
            this.Controls.Add(this.StopRecordButton);
            this.Controls.Add(this.StartRecordButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CameraSelectComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox CameraSelectComboBox;
        private Button StartButton;
        private Button StartRecordButton;
        private Button StopRecordButton;
        private CheckBox MotionCheckBox;
        private CheckBox GrayscaleCheckBox;
        private Button SearchButton;
        private SaveFileDialog saveFileDialog1;
        private Button ScreenshotButton;
        private PictureBox DetectionPictureBox;
        private Label label1;
        private Label label2;
    }
}
