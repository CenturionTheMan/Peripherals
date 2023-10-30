namespace MusicCardWF
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
            this.playWMPButton = new System.Windows.Forms.Button();
            this.stopWMPButton = new System.Windows.Forms.Button();
            this.fileLoadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadedFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pauseWMPButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pausePSButton = new System.Windows.Forms.Button();
            this.stopPSButton = new System.Windows.Forms.Button();
            this.playPSButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pauseWOWButton = new System.Windows.Forms.Button();
            this.stopWOWButton = new System.Windows.Forms.Button();
            this.playWOWButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pauseMCIButton = new System.Windows.Forms.Button();
            this.stopMCIButton = new System.Windows.Forms.Button();
            this.playMCIButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pauseDSButton = new System.Windows.Forms.Button();
            this.stopDSButton = new System.Windows.Forms.Button();
            this.playDSButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // playWMPButton
            // 
            this.playWMPButton.Location = new System.Drawing.Point(6, 22);
            this.playWMPButton.Name = "playWMPButton";
            this.playWMPButton.Size = new System.Drawing.Size(103, 23);
            this.playWMPButton.TabIndex = 0;
            this.playWMPButton.Text = "Play";
            this.playWMPButton.UseVisualStyleBackColor = true;
            this.playWMPButton.Click += new System.EventHandler(this.playWMPButton_Click);
            // 
            // stopWMPButton
            // 
            this.stopWMPButton.Location = new System.Drawing.Point(224, 23);
            this.stopWMPButton.Name = "stopWMPButton";
            this.stopWMPButton.Size = new System.Drawing.Size(103, 22);
            this.stopWMPButton.TabIndex = 1;
            this.stopWMPButton.Text = "Stop";
            this.stopWMPButton.UseVisualStyleBackColor = true;
            this.stopWMPButton.Click += new System.EventHandler(this.stopWMPButton_Click);
            // 
            // fileLoadButton
            // 
            this.fileLoadButton.Location = new System.Drawing.Point(26, 20);
            this.fileLoadButton.Name = "fileLoadButton";
            this.fileLoadButton.Size = new System.Drawing.Size(103, 40);
            this.fileLoadButton.TabIndex = 2;
            this.fileLoadButton.Text = "Load File";
            this.fileLoadButton.UseVisualStyleBackColor = true;
            this.fileLoadButton.Click += new System.EventHandler(this.fileLoadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // loadedFileTextBox
            // 
            this.loadedFileTextBox.Location = new System.Drawing.Point(135, 38);
            this.loadedFileTextBox.Name = "loadedFileTextBox";
            this.loadedFileTextBox.ReadOnly = true;
            this.loadedFileTextBox.Size = new System.Drawing.Size(285, 23);
            this.loadedFileTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loaded File:";
            // 
            // pauseWMPButton
            // 
            this.pauseWMPButton.Location = new System.Drawing.Point(115, 22);
            this.pauseWMPButton.Name = "pauseWMPButton";
            this.pauseWMPButton.Size = new System.Drawing.Size(103, 23);
            this.pauseWMPButton.TabIndex = 6;
            this.pauseWMPButton.Text = "Pause";
            this.pauseWMPButton.UseVisualStyleBackColor = true;
            this.pauseWMPButton.Click += new System.EventHandler(this.pauseWMPButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pauseWMPButton);
            this.groupBox1.Controls.Add(this.stopWMPButton);
            this.groupBox1.Controls.Add(this.playWMPButton);
            this.groupBox1.Location = new System.Drawing.Point(98, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 56);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WMP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pausePSButton);
            this.groupBox2.Controls.Add(this.stopPSButton);
            this.groupBox2.Controls.Add(this.playPSButton);
            this.groupBox2.Location = new System.Drawing.Point(98, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 56);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PlaySound";
            // 
            // pausePSButton
            // 
            this.pausePSButton.Enabled = false;
            this.pausePSButton.Location = new System.Drawing.Point(115, 22);
            this.pausePSButton.Name = "pausePSButton";
            this.pausePSButton.Size = new System.Drawing.Size(103, 23);
            this.pausePSButton.TabIndex = 6;
            this.pausePSButton.Text = "Pause";
            this.pausePSButton.UseVisualStyleBackColor = true;
            this.pausePSButton.Click += new System.EventHandler(this.pausePSButton_Click);
            // 
            // stopPSButton
            // 
            this.stopPSButton.Location = new System.Drawing.Point(224, 23);
            this.stopPSButton.Name = "stopPSButton";
            this.stopPSButton.Size = new System.Drawing.Size(103, 22);
            this.stopPSButton.TabIndex = 1;
            this.stopPSButton.Text = "Stop";
            this.stopPSButton.UseVisualStyleBackColor = true;
            this.stopPSButton.Click += new System.EventHandler(this.stopPSButton_Click);
            // 
            // playPSButton
            // 
            this.playPSButton.Location = new System.Drawing.Point(6, 22);
            this.playPSButton.Name = "playPSButton";
            this.playPSButton.Size = new System.Drawing.Size(103, 23);
            this.playPSButton.TabIndex = 0;
            this.playPSButton.Text = "Play";
            this.playPSButton.UseVisualStyleBackColor = true;
            this.playPSButton.Click += new System.EventHandler(this.playPSButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pauseWOWButton);
            this.groupBox3.Controls.Add(this.stopWOWButton);
            this.groupBox3.Controls.Add(this.playWOWButton);
            this.groupBox3.Location = new System.Drawing.Point(98, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 56);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WaveOutWrite";
            // 
            // pauseWOWButton
            // 
            this.pauseWOWButton.Location = new System.Drawing.Point(115, 22);
            this.pauseWOWButton.Name = "pauseWOWButton";
            this.pauseWOWButton.Size = new System.Drawing.Size(103, 23);
            this.pauseWOWButton.TabIndex = 6;
            this.pauseWOWButton.Text = "Pause";
            this.pauseWOWButton.UseVisualStyleBackColor = true;
            this.pauseWOWButton.Click += new System.EventHandler(this.pauseWOWButton_Click);
            // 
            // stopWOWButton
            // 
            this.stopWOWButton.Location = new System.Drawing.Point(224, 23);
            this.stopWOWButton.Name = "stopWOWButton";
            this.stopWOWButton.Size = new System.Drawing.Size(103, 22);
            this.stopWOWButton.TabIndex = 1;
            this.stopWOWButton.Text = "Stop";
            this.stopWOWButton.UseVisualStyleBackColor = true;
            this.stopWOWButton.Click += new System.EventHandler(this.stopWOWButton_Click);
            // 
            // playWOWButton
            // 
            this.playWOWButton.Location = new System.Drawing.Point(6, 22);
            this.playWOWButton.Name = "playWOWButton";
            this.playWOWButton.Size = new System.Drawing.Size(103, 23);
            this.playWOWButton.TabIndex = 0;
            this.playWOWButton.Text = "Play";
            this.playWOWButton.UseVisualStyleBackColor = true;
            this.playWOWButton.Click += new System.EventHandler(this.playWOWButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pauseMCIButton);
            this.groupBox4.Controls.Add(this.stopMCIButton);
            this.groupBox4.Controls.Add(this.playMCIButton);
            this.groupBox4.Location = new System.Drawing.Point(98, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 56);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MCI";
            // 
            // pauseMCIButton
            // 
            this.pauseMCIButton.Location = new System.Drawing.Point(115, 22);
            this.pauseMCIButton.Name = "pauseMCIButton";
            this.pauseMCIButton.Size = new System.Drawing.Size(103, 23);
            this.pauseMCIButton.TabIndex = 6;
            this.pauseMCIButton.Text = "Pause";
            this.pauseMCIButton.UseVisualStyleBackColor = true;
            this.pauseMCIButton.Click += new System.EventHandler(this.pauseMCIButton_Click);
            // 
            // stopMCIButton
            // 
            this.stopMCIButton.Location = new System.Drawing.Point(224, 23);
            this.stopMCIButton.Name = "stopMCIButton";
            this.stopMCIButton.Size = new System.Drawing.Size(103, 22);
            this.stopMCIButton.TabIndex = 1;
            this.stopMCIButton.Text = "Stop";
            this.stopMCIButton.UseVisualStyleBackColor = true;
            this.stopMCIButton.Click += new System.EventHandler(this.stopMCIButton_Click);
            // 
            // playMCIButton
            // 
            this.playMCIButton.Location = new System.Drawing.Point(6, 22);
            this.playMCIButton.Name = "playMCIButton";
            this.playMCIButton.Size = new System.Drawing.Size(103, 23);
            this.playMCIButton.TabIndex = 0;
            this.playMCIButton.Text = "Play";
            this.playMCIButton.UseVisualStyleBackColor = true;
            this.playMCIButton.Click += new System.EventHandler(this.playMCIButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pauseDSButton);
            this.groupBox5.Controls.Add(this.stopDSButton);
            this.groupBox5.Controls.Add(this.playDSButton);
            this.groupBox5.Location = new System.Drawing.Point(98, 347);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(332, 56);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DirectSound";
            // 
            // pauseDSButton
            // 
            this.pauseDSButton.Location = new System.Drawing.Point(115, 22);
            this.pauseDSButton.Name = "pauseDSButton";
            this.pauseDSButton.Size = new System.Drawing.Size(103, 23);
            this.pauseDSButton.TabIndex = 6;
            this.pauseDSButton.Text = "Pause";
            this.pauseDSButton.UseVisualStyleBackColor = true;
            this.pauseDSButton.Click += new System.EventHandler(this.pauseDSButton_Click);
            // 
            // stopDSButton
            // 
            this.stopDSButton.Location = new System.Drawing.Point(224, 23);
            this.stopDSButton.Name = "stopDSButton";
            this.stopDSButton.Size = new System.Drawing.Size(103, 22);
            this.stopDSButton.TabIndex = 1;
            this.stopDSButton.Text = "Stop";
            this.stopDSButton.UseVisualStyleBackColor = true;
            this.stopDSButton.Click += new System.EventHandler(this.stopDSButton_Click);
            // 
            // playDSButton
            // 
            this.playDSButton.Location = new System.Drawing.Point(6, 22);
            this.playDSButton.Name = "playDSButton";
            this.playDSButton.Size = new System.Drawing.Size(103, 23);
            this.playDSButton.TabIndex = 0;
            this.playDSButton.Text = "Play";
            this.playDSButton.UseVisualStyleBackColor = true;
            this.playDSButton.Click += new System.EventHandler(this.playDSButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 419);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadedFileTextBox);
            this.Controls.Add(this.fileLoadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button playWMPButton;
        private Button stopWMPButton;
        private Button fileLoadButton;
        private OpenFileDialog openFileDialog;
        private TextBox loadedFileTextBox;
        private Label label1;
        private Button pauseWMPButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button pausePSButton;
        private Button stopPSButton;
        private Button playPSButton;
        private GroupBox groupBox3;
        private Button pauseWOWButton;
        private Button stopWOWButton;
        private Button playWOWButton;
        private GroupBox groupBox4;
        private Button pauseMCIButton;
        private Button stopMCIButton;
        private Button playMCIButton;
        private GroupBox groupBox5;
        private Button pauseDSButton;
        private Button stopDSButton;
        private Button playDSButton;
    }
}