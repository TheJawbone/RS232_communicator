namespace RS232_communicator
{
    partial class RS232_communicator
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
            this.LabelBaudRate = new System.Windows.Forms.Label();
            this.LabelDataFieldSize = new System.Windows.Forms.Label();
            this.LabelParityControl = new System.Windows.Forms.Label();
            this.LabelStopBits = new System.Windows.Forms.Label();
            this.LabelHandshake = new System.Windows.Forms.Label();
            this.LabelTerminator = new System.Windows.Forms.Label();
            this.TextFieldTerminator = new System.Windows.Forms.TextBox();
            this.ComboBoxHandshake = new System.Windows.Forms.ComboBox();
            this.ComboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.ComboBoxParityControl = new System.Windows.Forms.ComboBox();
            this.ComboBoxDataFieldSize = new System.Windows.Forms.ComboBox();
            this.ComboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.GroupBoxConnectionParameters = new System.Windows.Forms.GroupBox();
            this.LabelPingTimeout = new System.Windows.Forms.Label();
            this.TextFieldPingTimeout = new System.Windows.Forms.TextBox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.ComboBoxPort = new System.Windows.Forms.ComboBox();
            this.ButtonConnectDisconnect = new System.Windows.Forms.Button();
            this.ButtonPing = new System.Windows.Forms.Button();
            this.GroupBoxDataSend = new System.Windows.Forms.GroupBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.TextBoxDataSend = new System.Windows.Forms.TextBox();
            this.GroupBoxDataRecieved = new System.Windows.Forms.GroupBox();
            this.ButtonClearDataRecieved = new System.Windows.Forms.Button();
            this.TextBoxDataRecieved = new System.Windows.Forms.TextBox();
            this.GroupBoxLog = new System.Windows.Forms.GroupBox();
            this.ButtonClearLog = new System.Windows.Forms.Button();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.GroupBoxConnectionParameters.SuspendLayout();
            this.GroupBoxDataSend.SuspendLayout();
            this.GroupBoxDataRecieved.SuspendLayout();
            this.GroupBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelBaudRate
            // 
            this.LabelBaudRate.AutoSize = true;
            this.LabelBaudRate.Location = new System.Drawing.Point(6, 55);
            this.LabelBaudRate.Name = "LabelBaudRate";
            this.LabelBaudRate.Size = new System.Drawing.Size(56, 13);
            this.LabelBaudRate.TabIndex = 0;
            this.LabelBaudRate.Text = "Baud rate:";
            // 
            // LabelDataFieldSize
            // 
            this.LabelDataFieldSize.AutoSize = true;
            this.LabelDataFieldSize.Location = new System.Drawing.Point(6, 82);
            this.LabelDataFieldSize.Name = "LabelDataFieldSize";
            this.LabelDataFieldSize.Size = new System.Drawing.Size(76, 13);
            this.LabelDataFieldSize.TabIndex = 1;
            this.LabelDataFieldSize.Text = "Data field size:";
            // 
            // LabelParityControl
            // 
            this.LabelParityControl.AutoSize = true;
            this.LabelParityControl.Location = new System.Drawing.Point(6, 109);
            this.LabelParityControl.Name = "LabelParityControl";
            this.LabelParityControl.Size = new System.Drawing.Size(71, 13);
            this.LabelParityControl.TabIndex = 2;
            this.LabelParityControl.Text = "Parity control:";
            // 
            // LabelStopBits
            // 
            this.LabelStopBits.AutoSize = true;
            this.LabelStopBits.Location = new System.Drawing.Point(6, 136);
            this.LabelStopBits.Name = "LabelStopBits";
            this.LabelStopBits.Size = new System.Drawing.Size(51, 13);
            this.LabelStopBits.TabIndex = 3;
            this.LabelStopBits.Text = "Stop bits:";
            // 
            // LabelHandshake
            // 
            this.LabelHandshake.AutoSize = true;
            this.LabelHandshake.Location = new System.Drawing.Point(6, 163);
            this.LabelHandshake.Name = "LabelHandshake";
            this.LabelHandshake.Size = new System.Drawing.Size(65, 13);
            this.LabelHandshake.TabIndex = 4;
            this.LabelHandshake.Text = "Handshake:";
            // 
            // LabelTerminator
            // 
            this.LabelTerminator.AutoSize = true;
            this.LabelTerminator.Location = new System.Drawing.Point(6, 190);
            this.LabelTerminator.Name = "LabelTerminator";
            this.LabelTerminator.Size = new System.Drawing.Size(60, 13);
            this.LabelTerminator.TabIndex = 5;
            this.LabelTerminator.Text = "Terminator:";
            // 
            // TextFieldTerminator
            // 
            this.TextFieldTerminator.Location = new System.Drawing.Point(113, 187);
            this.TextFieldTerminator.Name = "TextFieldTerminator";
            this.TextFieldTerminator.Size = new System.Drawing.Size(90, 20);
            this.TextFieldTerminator.TabIndex = 6;
            // 
            // ComboBoxHandshake
            // 
            this.ComboBoxHandshake.FormattingEnabled = true;
            this.ComboBoxHandshake.Items.AddRange(new object[] {
            "None",
            "RTS",
            "XOn/XOff"});
            this.ComboBoxHandshake.Location = new System.Drawing.Point(113, 160);
            this.ComboBoxHandshake.Name = "ComboBoxHandshake";
            this.ComboBoxHandshake.Size = new System.Drawing.Size(90, 21);
            this.ComboBoxHandshake.TabIndex = 7;
            // 
            // ComboBoxStopBits
            // 
            this.ComboBoxStopBits.FormattingEnabled = true;
            this.ComboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.ComboBoxStopBits.Location = new System.Drawing.Point(113, 133);
            this.ComboBoxStopBits.Name = "ComboBoxStopBits";
            this.ComboBoxStopBits.Size = new System.Drawing.Size(90, 21);
            this.ComboBoxStopBits.TabIndex = 8;
            // 
            // ComboBoxParityControl
            // 
            this.ComboBoxParityControl.FormattingEnabled = true;
            this.ComboBoxParityControl.Items.AddRange(new object[] {
            "N",
            "E",
            "O"});
            this.ComboBoxParityControl.Location = new System.Drawing.Point(113, 106);
            this.ComboBoxParityControl.Name = "ComboBoxParityControl";
            this.ComboBoxParityControl.Size = new System.Drawing.Size(90, 21);
            this.ComboBoxParityControl.TabIndex = 9;
            // 
            // ComboBoxDataFieldSize
            // 
            this.ComboBoxDataFieldSize.FormattingEnabled = true;
            this.ComboBoxDataFieldSize.Items.AddRange(new object[] {
            "7",
            "8"});
            this.ComboBoxDataFieldSize.Location = new System.Drawing.Point(113, 79);
            this.ComboBoxDataFieldSize.Name = "ComboBoxDataFieldSize";
            this.ComboBoxDataFieldSize.Size = new System.Drawing.Size(90, 21);
            this.ComboBoxDataFieldSize.TabIndex = 10;
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(113, 52);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(90, 21);
            this.ComboBoxBaudRate.TabIndex = 11;
            // 
            // GroupBoxConnectionParameters
            // 
            this.GroupBoxConnectionParameters.Controls.Add(this.LabelPingTimeout);
            this.GroupBoxConnectionParameters.Controls.Add(this.TextFieldPingTimeout);
            this.GroupBoxConnectionParameters.Controls.Add(this.LabelPort);
            this.GroupBoxConnectionParameters.Controls.Add(this.ComboBoxPort);
            this.GroupBoxConnectionParameters.Controls.Add(this.LabelBaudRate);
            this.GroupBoxConnectionParameters.Controls.Add(this.ComboBoxBaudRate);
            this.GroupBoxConnectionParameters.Controls.Add(this.LabelDataFieldSize);
            this.GroupBoxConnectionParameters.Controls.Add(this.ComboBoxDataFieldSize);
            this.GroupBoxConnectionParameters.Controls.Add(this.LabelParityControl);
            this.GroupBoxConnectionParameters.Controls.Add(this.ComboBoxParityControl);
            this.GroupBoxConnectionParameters.Controls.Add(this.LabelStopBits);
            this.GroupBoxConnectionParameters.Controls.Add(this.ComboBoxStopBits);
            this.GroupBoxConnectionParameters.Controls.Add(this.LabelHandshake);
            this.GroupBoxConnectionParameters.Controls.Add(this.ComboBoxHandshake);
            this.GroupBoxConnectionParameters.Controls.Add(this.LabelTerminator);
            this.GroupBoxConnectionParameters.Controls.Add(this.TextFieldTerminator);
            this.GroupBoxConnectionParameters.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxConnectionParameters.Name = "GroupBoxConnectionParameters";
            this.GroupBoxConnectionParameters.Size = new System.Drawing.Size(216, 247);
            this.GroupBoxConnectionParameters.TabIndex = 12;
            this.GroupBoxConnectionParameters.TabStop = false;
            this.GroupBoxConnectionParameters.Text = "Connection parameters:";
            // 
            // LabelPingTimeout
            // 
            this.LabelPingTimeout.AutoSize = true;
            this.LabelPingTimeout.Location = new System.Drawing.Point(6, 217);
            this.LabelPingTimeout.Name = "LabelPingTimeout";
            this.LabelPingTimeout.Size = new System.Drawing.Size(90, 13);
            this.LabelPingTimeout.TabIndex = 15;
            this.LabelPingTimeout.Text = "Ping timeout (ms):";
            // 
            // TextFieldPingTimeout
            // 
            this.TextFieldPingTimeout.Location = new System.Drawing.Point(113, 214);
            this.TextFieldPingTimeout.Name = "TextFieldPingTimeout";
            this.TextFieldPingTimeout.Size = new System.Drawing.Size(90, 20);
            this.TextFieldPingTimeout.TabIndex = 14;
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Location = new System.Drawing.Point(6, 28);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(29, 13);
            this.LabelPort.TabIndex = 13;
            this.LabelPort.Text = "Port:";
            // 
            // ComboBoxPort
            // 
            this.ComboBoxPort.FormattingEnabled = true;
            this.ComboBoxPort.Location = new System.Drawing.Point(113, 25);
            this.ComboBoxPort.Name = "ComboBoxPort";
            this.ComboBoxPort.Size = new System.Drawing.Size(90, 21);
            this.ComboBoxPort.TabIndex = 12;
            // 
            // ButtonConnectDisconnect
            // 
            this.ButtonConnectDisconnect.Location = new System.Drawing.Point(12, 265);
            this.ButtonConnectDisconnect.Name = "ButtonConnectDisconnect";
            this.ButtonConnectDisconnect.Size = new System.Drawing.Size(97, 23);
            this.ButtonConnectDisconnect.TabIndex = 13;
            this.ButtonConnectDisconnect.Text = "Connect";
            this.ButtonConnectDisconnect.UseVisualStyleBackColor = true;
            this.ButtonConnectDisconnect.Click += new System.EventHandler(this.ButtonConnectDisconnect_Click);
            // 
            // ButtonPing
            // 
            this.ButtonPing.Location = new System.Drawing.Point(131, 265);
            this.ButtonPing.Name = "ButtonPing";
            this.ButtonPing.Size = new System.Drawing.Size(97, 23);
            this.ButtonPing.TabIndex = 14;
            this.ButtonPing.Text = "Ping";
            this.ButtonPing.UseVisualStyleBackColor = true;
            this.ButtonPing.Click += new System.EventHandler(this.ButtonPing_Click);
            // 
            // GroupBoxDataSend
            // 
            this.GroupBoxDataSend.Controls.Add(this.ButtonSend);
            this.GroupBoxDataSend.Controls.Add(this.TextBoxDataSend);
            this.GroupBoxDataSend.Location = new System.Drawing.Point(234, 12);
            this.GroupBoxDataSend.Name = "GroupBoxDataSend";
            this.GroupBoxDataSend.Size = new System.Drawing.Size(200, 127);
            this.GroupBoxDataSend.TabIndex = 15;
            this.GroupBoxDataSend.TabStop = false;
            this.GroupBoxDataSend.Text = "Data send:";
            // 
            // ButtonSend
            // 
            this.ButtonSend.Location = new System.Drawing.Point(6, 101);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(188, 23);
            this.ButtonSend.TabIndex = 1;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // TextBoxDataSend
            // 
            this.TextBoxDataSend.Location = new System.Drawing.Point(6, 28);
            this.TextBoxDataSend.Multiline = true;
            this.TextBoxDataSend.Name = "TextBoxDataSend";
            this.TextBoxDataSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDataSend.Size = new System.Drawing.Size(188, 67);
            this.TextBoxDataSend.TabIndex = 0;
            // 
            // GroupBoxDataRecieved
            // 
            this.GroupBoxDataRecieved.Controls.Add(this.ButtonClearDataRecieved);
            this.GroupBoxDataRecieved.Controls.Add(this.TextBoxDataRecieved);
            this.GroupBoxDataRecieved.Location = new System.Drawing.Point(234, 161);
            this.GroupBoxDataRecieved.Name = "GroupBoxDataRecieved";
            this.GroupBoxDataRecieved.Size = new System.Drawing.Size(200, 131);
            this.GroupBoxDataRecieved.TabIndex = 16;
            this.GroupBoxDataRecieved.TabStop = false;
            this.GroupBoxDataRecieved.Text = "Data recieved:";
            // 
            // ButtonClearDataRecieved
            // 
            this.ButtonClearDataRecieved.Location = new System.Drawing.Point(6, 104);
            this.ButtonClearDataRecieved.Name = "ButtonClearDataRecieved";
            this.ButtonClearDataRecieved.Size = new System.Drawing.Size(188, 23);
            this.ButtonClearDataRecieved.TabIndex = 1;
            this.ButtonClearDataRecieved.Text = "Clear";
            this.ButtonClearDataRecieved.UseVisualStyleBackColor = true;
            this.ButtonClearDataRecieved.Click += new System.EventHandler(this.ButtonClearDataRecieved_Click);
            // 
            // TextBoxDataRecieved
            // 
            this.TextBoxDataRecieved.Location = new System.Drawing.Point(6, 28);
            this.TextBoxDataRecieved.Multiline = true;
            this.TextBoxDataRecieved.Name = "TextBoxDataRecieved";
            this.TextBoxDataRecieved.ReadOnly = true;
            this.TextBoxDataRecieved.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDataRecieved.Size = new System.Drawing.Size(188, 67);
            this.TextBoxDataRecieved.TabIndex = 0;
            // 
            // GroupBoxLog
            // 
            this.GroupBoxLog.Controls.Add(this.ButtonClearLog);
            this.GroupBoxLog.Controls.Add(this.TextBoxLog);
            this.GroupBoxLog.Location = new System.Drawing.Point(440, 12);
            this.GroupBoxLog.Name = "GroupBoxLog";
            this.GroupBoxLog.Size = new System.Drawing.Size(200, 280);
            this.GroupBoxLog.TabIndex = 17;
            this.GroupBoxLog.TabStop = false;
            this.GroupBoxLog.Text = "Log:";
            // 
            // ButtonClearLog
            // 
            this.ButtonClearLog.Location = new System.Drawing.Point(7, 253);
            this.ButtonClearLog.Name = "ButtonClearLog";
            this.ButtonClearLog.Size = new System.Drawing.Size(188, 23);
            this.ButtonClearLog.TabIndex = 2;
            this.ButtonClearLog.Text = "Clear";
            this.ButtonClearLog.UseVisualStyleBackColor = true;
            this.ButtonClearLog.Click += new System.EventHandler(this.ButtonClearLog_Click);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Location = new System.Drawing.Point(7, 28);
            this.TextBoxLog.Multiline = true;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.ReadOnly = true;
            this.TextBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxLog.Size = new System.Drawing.Size(187, 216);
            this.TextBoxLog.TabIndex = 0;
            // 
            // RS232_communicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 304);
            this.Controls.Add(this.GroupBoxLog);
            this.Controls.Add(this.GroupBoxDataRecieved);
            this.Controls.Add(this.GroupBoxDataSend);
            this.Controls.Add(this.ButtonPing);
            this.Controls.Add(this.ButtonConnectDisconnect);
            this.Controls.Add(this.GroupBoxConnectionParameters);
            this.Name = "RS232_communicator";
            this.Text = "Form1";
            this.GroupBoxConnectionParameters.ResumeLayout(false);
            this.GroupBoxConnectionParameters.PerformLayout();
            this.GroupBoxDataSend.ResumeLayout(false);
            this.GroupBoxDataSend.PerformLayout();
            this.GroupBoxDataRecieved.ResumeLayout(false);
            this.GroupBoxDataRecieved.PerformLayout();
            this.GroupBoxLog.ResumeLayout(false);
            this.GroupBoxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelBaudRate;
        private System.Windows.Forms.Label LabelDataFieldSize;
        private System.Windows.Forms.Label LabelParityControl;
        private System.Windows.Forms.Label LabelStopBits;
        private System.Windows.Forms.Label LabelHandshake;
        private System.Windows.Forms.Label LabelTerminator;
        private System.Windows.Forms.TextBox TextFieldTerminator;
        private System.Windows.Forms.ComboBox ComboBoxHandshake;
        private System.Windows.Forms.ComboBox ComboBoxStopBits;
        private System.Windows.Forms.ComboBox ComboBoxParityControl;
        private System.Windows.Forms.ComboBox ComboBoxDataFieldSize;
        private System.Windows.Forms.ComboBox ComboBoxBaudRate;
        private System.Windows.Forms.GroupBox GroupBoxConnectionParameters;
        private System.Windows.Forms.Label LabelPingTimeout;
        private System.Windows.Forms.TextBox TextFieldPingTimeout;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.ComboBox ComboBoxPort;
        private System.Windows.Forms.Button ButtonConnectDisconnect;
        private System.Windows.Forms.Button ButtonPing;
        private System.Windows.Forms.GroupBox GroupBoxDataSend;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.TextBox TextBoxDataSend;
        private System.Windows.Forms.GroupBox GroupBoxDataRecieved;
        private System.Windows.Forms.Button ButtonClearDataRecieved;
        private System.Windows.Forms.TextBox TextBoxDataRecieved;
        private System.Windows.Forms.GroupBox GroupBoxLog;
        private System.Windows.Forms.Button ButtonClearLog;
        private System.Windows.Forms.TextBox TextBoxLog;
    }
}

