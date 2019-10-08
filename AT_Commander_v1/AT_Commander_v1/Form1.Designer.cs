namespace AT_Commander_v1
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
            this.cmbStopbits1 = new System.Windows.Forms.ComboBox();
            this.cmbDatabits1 = new System.Windows.Forms.ComboBox();
            this.cmbParity1 = new System.Windows.Forms.ComboBox();
            this.cmbPort1 = new System.Windows.Forms.ComboBox();
            this.cmbBaud1 = new System.Windows.Forms.ComboBox();
            this.cmdStop1 = new System.Windows.Forms.Button();
            this.cmdGO1 = new System.Windows.Forms.Button();
            this.rtRX1 = new System.Windows.Forms.RichTextBox();
            this.cmbEOL1 = new System.Windows.Forms.ComboBox();
            this.cmdTX1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbStopbits1
            // 
            this.cmbStopbits1.FormattingEnabled = true;
            this.cmbStopbits1.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cmbStopbits1.Location = new System.Drawing.Point(250, 13);
            this.cmbStopbits1.Name = "cmbStopbits1";
            this.cmbStopbits1.Size = new System.Drawing.Size(45, 21);
            this.cmbStopbits1.TabIndex = 12;
            this.cmbStopbits1.Text = "Stop";
            // 
            // cmbDatabits1
            // 
            this.cmbDatabits1.FormattingEnabled = true;
            this.cmbDatabits1.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cmbDatabits1.Location = new System.Drawing.Point(201, 13);
            this.cmbDatabits1.Name = "cmbDatabits1";
            this.cmbDatabits1.Size = new System.Drawing.Size(46, 21);
            this.cmbDatabits1.TabIndex = 11;
            this.cmbDatabits1.Text = "Data";
            // 
            // cmbParity1
            // 
            this.cmbParity1.FormattingEnabled = true;
            this.cmbParity1.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cmbParity1.Location = new System.Drawing.Point(143, 13);
            this.cmbParity1.Name = "cmbParity1";
            this.cmbParity1.Size = new System.Drawing.Size(55, 21);
            this.cmbParity1.TabIndex = 10;
            this.cmbParity1.Text = "Parity";
            // 
            // cmbPort1
            // 
            this.cmbPort1.AllowDrop = true;
            this.cmbPort1.FormattingEnabled = true;
            this.cmbPort1.Location = new System.Drawing.Point(12, 13);
            this.cmbPort1.Name = "cmbPort1";
            this.cmbPort1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPort1.Size = new System.Drawing.Size(69, 21);
            this.cmbPort1.TabIndex = 8;
            this.cmbPort1.Tag = "Com Port";
            this.cmbPort1.Text = "Com Port";
            // 
            // cmbBaud1
            // 
            this.cmbBaud1.AllowDrop = true;
            this.cmbBaud1.FormattingEnabled = true;
            this.cmbBaud1.Items.AddRange(new object[] {
            "110",
            "115200",
            "1200",
            "128000",
            "14400",
            "19200",
            "2400",
            "256000",
            "300",
            "38400",
            "4800",
            "57600",
            "600",
            "9600"});
            this.cmbBaud1.Location = new System.Drawing.Point(84, 13);
            this.cmbBaud1.Name = "cmbBaud1";
            this.cmbBaud1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBaud1.Size = new System.Drawing.Size(56, 21);
            this.cmbBaud1.TabIndex = 9;
            this.cmbBaud1.Tag = "Baud";
            this.cmbBaud1.Text = "Baud";
            // 
            // cmdStop1
            // 
            this.cmdStop1.Location = new System.Drawing.Point(374, 11);
            this.cmdStop1.Name = "cmdStop1";
            this.cmdStop1.Size = new System.Drawing.Size(88, 23);
            this.cmdStop1.TabIndex = 14;
            this.cmdStop1.Text = "DISCONNECT";
            this.cmdStop1.UseVisualStyleBackColor = true;
            // 
            // cmdGO1
            // 
            this.cmdGO1.Location = new System.Drawing.Point(301, 11);
            this.cmdGO1.Name = "cmdGO1";
            this.cmdGO1.Size = new System.Drawing.Size(67, 23);
            this.cmdGO1.TabIndex = 13;
            this.cmdGO1.Text = "CONNECT";
            this.cmdGO1.UseVisualStyleBackColor = true;
            this.cmdGO1.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // rtRX1
            // 
            this.rtRX1.BackColor = System.Drawing.Color.Black;
            this.rtRX1.ForeColor = System.Drawing.Color.Red;
            this.rtRX1.Location = new System.Drawing.Point(12, 40);
            this.rtRX1.Name = "rtRX1";
            this.rtRX1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtRX1.Size = new System.Drawing.Size(450, 241);
            this.rtRX1.TabIndex = 31;
            this.rtRX1.Text = "AT+WOPEN=1\nAT+FACTORY_RESET=1\nAT+SERIAL_BAUD=115200\nAT+CGDCONT?=1,\"IP\",\"campbell." +
    "com.au\"\nAT+IFC=0,0\nAT&D0\nAT&W\nAT+WOPEN=0\nAT+SAVE";
            // 
            // cmbEOL1
            // 
            this.cmbEOL1.FormattingEnabled = true;
            this.cmbEOL1.Items.AddRange(new object[] {
            "LF",
            "CR",
            "LF,CR"});
            this.cmbEOL1.Location = new System.Drawing.Point(12, 287);
            this.cmbEOL1.Name = "cmbEOL1";
            this.cmbEOL1.Size = new System.Drawing.Size(44, 21);
            this.cmbEOL1.TabIndex = 33;
            this.cmbEOL1.Text = "CR";
            // 
            // cmdTX1
            // 
            this.cmdTX1.Location = new System.Drawing.Point(62, 287);
            this.cmdTX1.Name = "cmdTX1";
            this.cmdTX1.Size = new System.Drawing.Size(52, 23);
            this.cmdTX1.TabIndex = 32;
            this.cmdTX1.Text = "SEND";
            this.cmdTX1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 346);
            this.Controls.Add(this.cmbEOL1);
            this.Controls.Add(this.cmdTX1);
            this.Controls.Add(this.rtRX1);
            this.Controls.Add(this.cmdStop1);
            this.Controls.Add(this.cmdGO1);
            this.Controls.Add(this.cmbStopbits1);
            this.Controls.Add(this.cmbDatabits1);
            this.Controls.Add(this.cmbParity1);
            this.Controls.Add(this.cmbPort1);
            this.Controls.Add(this.cmbBaud1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStopbits1;
        private System.Windows.Forms.ComboBox cmbDatabits1;
        private System.Windows.Forms.ComboBox cmbParity1;
        private System.Windows.Forms.ComboBox cmbPort1;
        private System.Windows.Forms.ComboBox cmbBaud1;
        private System.Windows.Forms.Button cmdStop1;
        private System.Windows.Forms.Button cmdGO1;
        private System.Windows.Forms.RichTextBox rtRX1;
        private System.Windows.Forms.ComboBox cmbEOL1;
        private System.Windows.Forms.Button cmdTX1;
    }
}

