namespace MusicCard
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            stopSoundDirectButton = new Button();
            playSoundDirectButton = new Button();
            openFileDialog = new OpenFileDialog();
            loadFileButton = new Button();
            loadedFileTextBox = new TextBox();
            groupBox2 = new GroupBox();
            stopSoundActiveButton = new Button();
            playSoundActiveButton = new Button();
            groupBox3 = new GroupBox();
            stopSoundWaveButton = new Button();
            playSoundWaveButton = new Button();
            startRecordButton = new Button();
            stopRecordButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            timerTextBox = new TextBox();
            saveFileDialog = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(stopSoundDirectButton);
            groupBox1.Controls.Add(playSoundDirectButton);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "DirectSound()";
            // 
            // stopSoundDirectButton
            // 
            stopSoundDirectButton.Location = new Point(6, 72);
            stopSoundDirectButton.Name = "stopSoundDirectButton";
            stopSoundDirectButton.Size = new Size(168, 29);
            stopSoundDirectButton.TabIndex = 3;
            stopSoundDirectButton.Text = "Stop Sound";
            stopSoundDirectButton.UseVisualStyleBackColor = true;
            stopSoundDirectButton.Click += stopSoundDirectButton_Click;
            // 
            // playSoundDirectButton
            // 
            playSoundDirectButton.Location = new Point(6, 37);
            playSoundDirectButton.Name = "playSoundDirectButton";
            playSoundDirectButton.Size = new Size(168, 29);
            playSoundDirectButton.TabIndex = 2;
            playSoundDirectButton.Text = "Play Sound";
            playSoundDirectButton.UseVisualStyleBackColor = true;
            playSoundDirectButton.Click += playSoundDirectButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "WAVE|*.wav";
            // 
            // loadFileButton
            // 
            loadFileButton.Location = new Point(12, 12);
            loadFileButton.Name = "loadFileButton";
            loadFileButton.Size = new Size(94, 29);
            loadFileButton.TabIndex = 0;
            loadFileButton.Text = "Load File";
            loadFileButton.UseVisualStyleBackColor = true;
            loadFileButton.Click += loadFileButton_Click;
            // 
            // loadedFileTextBox
            // 
            loadedFileTextBox.Location = new Point(112, 12);
            loadedFileTextBox.Name = "loadedFileTextBox";
            loadedFileTextBox.ReadOnly = true;
            loadedFileTextBox.Size = new Size(458, 27);
            loadedFileTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(stopSoundActiveButton);
            groupBox2.Controls.Add(playSoundActiveButton);
            groupBox2.Location = new Point(200, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(182, 115);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ActiveX";
            // 
            // stopSoundActiveButton
            // 
            stopSoundActiveButton.Location = new Point(6, 72);
            stopSoundActiveButton.Name = "stopSoundActiveButton";
            stopSoundActiveButton.Size = new Size(168, 29);
            stopSoundActiveButton.TabIndex = 1;
            stopSoundActiveButton.Text = "Stop Sound";
            stopSoundActiveButton.UseVisualStyleBackColor = true;
            stopSoundActiveButton.Click += stopSoundActiveButton_Click;
            // 
            // playSoundActiveButton
            // 
            playSoundActiveButton.Location = new Point(6, 37);
            playSoundActiveButton.Name = "playSoundActiveButton";
            playSoundActiveButton.Size = new Size(168, 29);
            playSoundActiveButton.TabIndex = 0;
            playSoundActiveButton.Text = "Play Sound";
            playSoundActiveButton.UseVisualStyleBackColor = true;
            playSoundActiveButton.Click += playSoundActiveButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(stopSoundWaveButton);
            groupBox3.Controls.Add(playSoundWaveButton);
            groupBox3.Location = new Point(388, 71);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(182, 115);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "WaveForm";
            // 
            // stopSoundWaveButton
            // 
            stopSoundWaveButton.Location = new Point(6, 72);
            stopSoundWaveButton.Name = "stopSoundWaveButton";
            stopSoundWaveButton.Size = new Size(168, 29);
            stopSoundWaveButton.TabIndex = 1;
            stopSoundWaveButton.Text = "Stop Sound";
            stopSoundWaveButton.UseVisualStyleBackColor = true;
            stopSoundWaveButton.Click += stopSoundWaveButton_Click;
            // 
            // playSoundWaveButton
            // 
            playSoundWaveButton.Location = new Point(6, 37);
            playSoundWaveButton.Name = "playSoundWaveButton";
            playSoundWaveButton.Size = new Size(168, 29);
            playSoundWaveButton.TabIndex = 0;
            playSoundWaveButton.Text = "Play Sound";
            playSoundWaveButton.UseVisualStyleBackColor = true;
            playSoundWaveButton.Click += playSoundWaveButton_Click;
            // 
            // startRecordButton
            // 
            startRecordButton.Location = new Point(12, 216);
            startRecordButton.Name = "startRecordButton";
            startRecordButton.Size = new Size(232, 29);
            startRecordButton.TabIndex = 2;
            startRecordButton.Text = "Start Recording";
            startRecordButton.UseVisualStyleBackColor = true;
            startRecordButton.Click += startRecordButton_Click;
            // 
            // stopRecordButton
            // 
            stopRecordButton.Location = new Point(12, 252);
            stopRecordButton.Name = "stopRecordButton";
            stopRecordButton.Size = new Size(232, 29);
            stopRecordButton.TabIndex = 4;
            stopRecordButton.Text = "Stop Recording";
            stopRecordButton.UseVisualStyleBackColor = true;
            stopRecordButton.Click += stopRecordButton_Click;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // timerTextBox
            // 
            timerTextBox.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            timerTextBox.Location = new Point(250, 216);
            timerTextBox.Name = "timerTextBox";
            timerTextBox.ReadOnly = true;
            timerTextBox.Size = new Size(320, 65);
            timerTextBox.TabIndex = 5;
            timerTextBox.Text = "00:00:000";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "WAVE|*.wav";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(586, 299);
            Controls.Add(timerTextBox);
            Controls.Add(stopRecordButton);
            Controls.Add(startRecordButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(loadedFileTextBox);
            Controls.Add(loadFileButton);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button stopSoundDirectButton;
        private Button playSoundDirectButton;
        private OpenFileDialog openFileDialog;
        private Button loadFileButton;
        private TextBox loadedFileTextBox;
        private GroupBox groupBox2;
        private Button playSoundActiveButton;
        private Button stopSoundActiveButton;
        private GroupBox groupBox3;
        private Button stopSoundWaveButton;
        private Button playSoundWaveButton;
        private Button startRecordButton;
        private Button stopRecordButton;
        private System.Windows.Forms.Timer timer;
        private TextBox timerTextBox;
        private SaveFileDialog saveFileDialog;
    }
}
