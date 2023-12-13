namespace MusicCardNet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.LoadedFileTextBox = new System.Windows.Forms.TextBox();
            this.AxWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlaySoundButton = new System.Windows.Forms.Button();
            this.StopSoundButton = new System.Windows.Forms.Button();
            this.WavHeadersRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AxWindowsMediaPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "\"Wave File (*.wav)|*.wav;\"";
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(12, 12);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(118, 20);
            this.LoadFileButton.TabIndex = 1;
            this.LoadFileButton.Text = "Load File";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // LoadedFileTextBox
            // 
            this.LoadedFileTextBox.Location = new System.Drawing.Point(136, 13);
            this.LoadedFileTextBox.Name = "LoadedFileTextBox";
            this.LoadedFileTextBox.ReadOnly = true;
            this.LoadedFileTextBox.Size = new System.Drawing.Size(652, 20);
            this.LoadedFileTextBox.TabIndex = 2;
            // 
            // AxWindowsMediaPlayer
            // 
            this.AxWindowsMediaPlayer.Enabled = true;
            this.AxWindowsMediaPlayer.Location = new System.Drawing.Point(6, 19);
            this.AxWindowsMediaPlayer.Name = "AxWindowsMediaPlayer";
            this.AxWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AxWindowsMediaPlayer.OcxState")));
            this.AxWindowsMediaPlayer.Size = new System.Drawing.Size(383, 315);
            this.AxWindowsMediaPlayer.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AxWindowsMediaPlayer);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 341);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Windows Media Player (ActiveX)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StopSoundButton);
            this.groupBox2.Controls.Add(this.PlaySoundButton);
            this.groupBox2.Location = new System.Drawing.Point(438, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PlaySound";
            // 
            // PlaySoundButton
            // 
            this.PlaySoundButton.Location = new System.Drawing.Point(6, 19);
            this.PlaySoundButton.Name = "PlaySoundButton";
            this.PlaySoundButton.Size = new System.Drawing.Size(338, 23);
            this.PlaySoundButton.TabIndex = 0;
            this.PlaySoundButton.Text = "Play Sound";
            this.PlaySoundButton.UseVisualStyleBackColor = true;
            this.PlaySoundButton.Click += new System.EventHandler(this.PlaySoundButton_Click);
            // 
            // StopSoundButton
            // 
            this.StopSoundButton.Location = new System.Drawing.Point(6, 48);
            this.StopSoundButton.Name = "StopSoundButton";
            this.StopSoundButton.Size = new System.Drawing.Size(338, 23);
            this.StopSoundButton.TabIndex = 1;
            this.StopSoundButton.Text = "Stop Sound";
            this.StopSoundButton.UseVisualStyleBackColor = true;
            this.StopSoundButton.Click += new System.EventHandler(this.StopSoundButton_Click);
            // 
            // WavHeadersRichTextBox
            // 
            this.WavHeadersRichTextBox.Location = new System.Drawing.Point(438, 196);
            this.WavHeadersRichTextBox.Name = "WavHeadersRichTextBox";
            this.WavHeadersRichTextBox.ReadOnly = true;
            this.WavHeadersRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.WavHeadersRichTextBox.Size = new System.Drawing.Size(344, 208);
            this.WavHeadersRichTextBox.TabIndex = 5;
            this.WavHeadersRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "WAV Headers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WavHeadersRichTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoadedFileTextBox);
            this.Controls.Add(this.LoadFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AxWindowsMediaPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.TextBox LoadedFileTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StopSoundButton;
        private System.Windows.Forms.Button PlaySoundButton;
        private AxWMPLib.AxWindowsMediaPlayer AxWindowsMediaPlayer;
        private System.Windows.Forms.RichTextBox WavHeadersRichTextBox;
        private System.Windows.Forms.Label label1;
    }
}

