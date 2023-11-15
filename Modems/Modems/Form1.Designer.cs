namespace Modems;

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
            this.messageLogTextBox = new System.Windows.Forms.RichTextBox();
            this.userInputMessageBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portModemStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disconnectPortButton = new System.Windows.Forms.Button();
            this.connectPortButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.breakConnetionButton = new System.Windows.Forms.Button();
            this.answerButton = new System.Windows.Forms.Button();
            this.callButton = new System.Windows.Forms.Button();
            this.guestModemNumbertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.commandModeButton = new System.Windows.Forms.Button();
            this.writingModeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLogTextBox
            // 
            this.messageLogTextBox.Location = new System.Drawing.Point(254, 12);
            this.messageLogTextBox.Name = "messageLogTextBox";
            this.messageLogTextBox.ReadOnly = true;
            this.messageLogTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.messageLogTextBox.Size = new System.Drawing.Size(555, 385);
            this.messageLogTextBox.TabIndex = 0;
            this.messageLogTextBox.Text = "";
            // 
            // userInputMessageBox
            // 
            this.userInputMessageBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userInputMessageBox.Location = new System.Drawing.Point(254, 408);
            this.userInputMessageBox.Name = "userInputMessageBox";
            this.userInputMessageBox.Size = new System.Drawing.Size(474, 25);
            this.userInputMessageBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendButton.Location = new System.Drawing.Point(734, 403);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 35);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portModemStatusLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.disconnectPortButton);
            this.groupBox1.Controls.Add(this.connectPortButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Modem";
            // 
            // portModemStatusLabel
            // 
            this.portModemStatusLabel.AutoSize = true;
            this.portModemStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.portModemStatusLabel.Location = new System.Drawing.Point(78, 28);
            this.portModemStatusLabel.Name = "portModemStatusLabel";
            this.portModemStatusLabel.Size = new System.Drawing.Size(133, 21);
            this.portModemStatusLabel.TabIndex = 7;
            this.portModemStatusLabel.Text = "DISCONNECTED";
            this.portModemStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "STATUS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // disconnectPortButton
            // 
            this.disconnectPortButton.Enabled = false;
            this.disconnectPortButton.Location = new System.Drawing.Point(6, 111);
            this.disconnectPortButton.Name = "disconnectPortButton";
            this.disconnectPortButton.Size = new System.Drawing.Size(156, 39);
            this.disconnectPortButton.TabIndex = 5;
            this.disconnectPortButton.Text = "Disconnect with modem";
            this.disconnectPortButton.UseVisualStyleBackColor = true;
            this.disconnectPortButton.Click += new System.EventHandler(this.disconnectPortButton_Click);
            // 
            // connectPortButton
            // 
            this.connectPortButton.Location = new System.Drawing.Point(6, 66);
            this.connectPortButton.Name = "connectPortButton";
            this.connectPortButton.Size = new System.Drawing.Size(156, 39);
            this.connectPortButton.TabIndex = 4;
            this.connectPortButton.Text = "Connect with modem";
            this.connectPortButton.UseVisualStyleBackColor = true;
            this.connectPortButton.Click += new System.EventHandler(this.connectPortButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.breakConnetionButton);
            this.groupBox2.Controls.Add(this.answerButton);
            this.groupBox2.Controls.Add(this.callButton);
            this.groupBox2.Controls.Add(this.guestModemNumbertextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guest Modem";
            // 
            // breakConnetionButton
            // 
            this.breakConnetionButton.Location = new System.Drawing.Point(11, 106);
            this.breakConnetionButton.Name = "breakConnetionButton";
            this.breakConnetionButton.Size = new System.Drawing.Size(200, 29);
            this.breakConnetionButton.TabIndex = 4;
            this.breakConnetionButton.Text = "Break Connection";
            this.breakConnetionButton.UseVisualStyleBackColor = true;
            this.breakConnetionButton.Click += new System.EventHandler(this.breakConnetionButton_Click);
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(114, 70);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(97, 30);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "ANSWER";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // callButton
            // 
            this.callButton.Location = new System.Drawing.Point(11, 70);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(97, 30);
            this.callButton.TabIndex = 2;
            this.callButton.Text = "CALL";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // guestModemNumbertextBox
            // 
            this.guestModemNumbertextBox.Location = new System.Drawing.Point(11, 41);
            this.guestModemNumbertextBox.Name = "guestModemNumbertextBox";
            this.guestModemNumbertextBox.Size = new System.Drawing.Size(200, 23);
            this.guestModemNumbertextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modem number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.commandModeButton);
            this.groupBox3.Controls.Add(this.writingModeButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 95);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode Selection";
            // 
            // commandModeButton
            // 
            this.commandModeButton.Location = new System.Drawing.Point(6, 56);
            this.commandModeButton.Name = "commandModeButton";
            this.commandModeButton.Size = new System.Drawing.Size(205, 28);
            this.commandModeButton.TabIndex = 1;
            this.commandModeButton.Text = "Command mode";
            this.commandModeButton.UseVisualStyleBackColor = true;
            this.commandModeButton.Click += new System.EventHandler(this.commandModeButton_Click);
            // 
            // writingModeButton
            // 
            this.writingModeButton.Location = new System.Drawing.Point(6, 22);
            this.writingModeButton.Name = "writingModeButton";
            this.writingModeButton.Size = new System.Drawing.Size(205, 28);
            this.writingModeButton.TabIndex = 0;
            this.writingModeButton.Text = "Writing mode";
            this.writingModeButton.UseVisualStyleBackColor = true;
            this.writingModeButton.Click += new System.EventHandler(this.writingModeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.userInputMessageBox);
            this.Controls.Add(this.messageLogTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private RichTextBox messageLogTextBox;
    private TextBox userInputMessageBox;
    private Button sendButton;
    private GroupBox groupBox1;
    private Label portModemStatusLabel;
    private Label label1;
    private Button disconnectPortButton;
    private Button connectPortButton;
    private GroupBox groupBox2;
    private Button callButton;
    private TextBox guestModemNumbertextBox;
    private Label label2;
    private Button answerButton;
    private Button breakConnetionButton;
    private GroupBox groupBox3;
    private Button commandModeButton;
    private Button writingModeButton;
}