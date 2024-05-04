namespace ArduinoSamples
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.cmdSendConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSendPort = new System.Windows.Forms.ComboBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.serialCommSend = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessageReceived = new System.Windows.Forms.TextBox();
            this.cmdReceiveConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRecievePort = new System.Windows.Forms.ComboBox();
            this.serialCommReceive = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSendMessage);
            this.groupBox1.Controls.Add(this.cmdSendConnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSendPort);
            this.groupBox1.Controls.Add(this.cmdSend);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(304, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message to send:";
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(16, 116);
            this.txtSendMessage.Multiline = true;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendMessage.Size = new System.Drawing.Size(274, 79);
            this.txtSendMessage.TabIndex = 5;
            this.txtSendMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // cmdSendConnect
            // 
            this.cmdSendConnect.Enabled = false;
            this.cmdSendConnect.Location = new System.Drawing.Point(16, 63);
            this.cmdSendConnect.Name = "cmdSendConnect";
            this.cmdSendConnect.Size = new System.Drawing.Size(274, 23);
            this.cmdSendConnect.TabIndex = 4;
            this.cmdSendConnect.Text = "Connect using the COM port";
            this.cmdSendConnect.UseVisualStyleBackColor = true;
            this.cmdSendConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM Port";
            // 
            // cmbSendPort
            // 
            this.cmbSendPort.DisplayMember = "COM7";
            this.cmbSendPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSendPort.FormattingEnabled = true;
            this.cmbSendPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18"});
            this.cmbSendPort.Location = new System.Drawing.Point(159, 22);
            this.cmbSendPort.Name = "cmbSendPort";
            this.cmbSendPort.Size = new System.Drawing.Size(121, 21);
            this.cmbSendPort.TabIndex = 2;
            this.cmbSendPort.ValueMember = "COM7";
            this.cmbSendPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            // 
            // cmdSend
            // 
            this.cmdSend.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdSend.Enabled = false;
            this.cmdSend.Location = new System.Drawing.Point(2, 230);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(300, 34);
            this.cmdSend.TabIndex = 0;
            this.cmdSend.Text = "Send Message";
            this.cmdSend.UseVisualStyleBackColor = false;
            this.cmdSend.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // serialCommSend
            // 
            this.serialCommSend.PortName = "COM8";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMessageReceived);
            this.groupBox2.Controls.Add(this.cmdReceiveConnect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbRecievePort);
            this.groupBox2.Location = new System.Drawing.Point(326, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(365, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Received Messages:";
            // 
            // txtMessageReceived
            // 
            this.txtMessageReceived.Location = new System.Drawing.Point(16, 116);
            this.txtMessageReceived.Multiline = true;
            this.txtMessageReceived.Name = "txtMessageReceived";
            this.txtMessageReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessageReceived.Size = new System.Drawing.Size(334, 144);
            this.txtMessageReceived.TabIndex = 5;
            // 
            // cmdReceiveConnect
            // 
            this.cmdReceiveConnect.Enabled = false;
            this.cmdReceiveConnect.Location = new System.Drawing.Point(16, 63);
            this.cmdReceiveConnect.Name = "cmdReceiveConnect";
            this.cmdReceiveConnect.Size = new System.Drawing.Size(274, 23);
            this.cmdReceiveConnect.TabIndex = 4;
            this.cmdReceiveConnect.Text = "Connect using the COM port";
            this.cmdReceiveConnect.UseVisualStyleBackColor = true;
            this.cmdReceiveConnect.Click += new System.EventHandler(this.cmdReceiveConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "COM Port";
            // 
            // cmbRecievePort
            // 
            this.cmbRecievePort.DisplayMember = "COM7";
            this.cmbRecievePort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRecievePort.FormattingEnabled = true;
            this.cmbRecievePort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18"});
            this.cmbRecievePort.Location = new System.Drawing.Point(159, 22);
            this.cmbRecievePort.Name = "cmbRecievePort";
            this.cmbRecievePort.Size = new System.Drawing.Size(121, 21);
            this.cmbRecievePort.TabIndex = 2;
            this.cmbRecievePort.ValueMember = "COM7";
            this.cmbRecievePort.SelectedIndexChanged += new System.EventHandler(this.cmbRecievePort_SelectedIndexChanged);
            // 
            // serialCommReceive
            // 
            this.serialCommReceive.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialCommReceive_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arduino Samples";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialCommSend;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSendPort;
        private System.Windows.Forms.Button cmdSendConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessageReceived;
        private System.Windows.Forms.Button cmdReceiveConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRecievePort;
        private System.IO.Ports.SerialPort serialCommReceive;
    }
}

