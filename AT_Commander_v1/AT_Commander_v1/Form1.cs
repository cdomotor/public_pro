using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace AT_Commander_v1
{
    public partial class Form1 : Form
    {
        public string eol1;
        public System.IO.Ports.SerialPort sport;

        public Form1()
        {
            InitializeComponent();
            LoadComboBox();
            cmbEOL1_SelectedIndexChanged(this, new EventArgs());
        }

        public String mytimestamp()
        {
            DateTime dt = DateTime.Now;
            String thistimestamp = String.Format("{0:HH:mm:ss:ff }", dt);
            return thistimestamp;
        }

        void LoadComboBox()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");
            cmbPort1.Items.Clear();
            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
                ComboBox.ObjectCollection items = cmbPort1.Items;
                items.Add(port);
            }
            //Console.ReadLine();
        }

        private void cboPort1_Click(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        public void serialport_connect(String port, int baudrate, Parity parity, int databits, StopBits stopbits)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToLongTimeString();

            sport = new System.IO.Ports.SerialPort(
            port, baudrate, parity, databits, stopbits);
            sport.ReadTimeout = 100;
            try
            {
                sport.Open();
                cmdStop1.Enabled = true;
                cmdGO1.Enabled = false;
                rtRX1.AppendText("\n" + mytimestamp() + "Connected to " + cmbPort1.Text + "\n");
                sport.NewLine = eol1;
                sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        private void sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                DateTime dt = DateTime.Now;
                String dtn = dt.ToLongTimeString();
                sport.NewLine = eol1;
                string RXline = sport.ReadLine();
                SetText(RXline.ToString());
            }
            catch (Exception) { }//MessageBox.Show(ex.ToString(), "Error"); }
        }

        delegate void SetTextCallback(string mytext);

        private void SetText(string mytext)
        {
            if (this.rtRX1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { mytext });
            }
            else
            {
                rtRX1.SelectionColor = Color.LimeGreen;
                string thistimestamp = mytimestamp();
                String myrecieved = thistimestamp + "RX: " + mytext + "\n";
                this.rtRX1.AppendText(myrecieved);
                //LogToFile(txtLogFilePath.Text + txtLogFileName.Text, myrecieved + txtNote1.Text);
                
            }
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                String port = cmbPort1.Text;
                int baudrate = Convert.ToInt32(cmbBaud1.Text);
                Parity parity = (Parity)Enum.Parse(typeof(Parity), cmbParity1.Text);
                int databits = Convert.ToInt32(cmbDatabits1.Text);
                StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopbits1.Text);
                serialport_connect(port, baudrate, parity, databits, stopbits);
                //this.ActiveControl = txtTX1;
                cmdGO1.BackColor = Color.Green;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }
        
        private void cmbEOL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEOL1.SelectedIndex + 1)
            {
                case 1:
                    eol1 = "\n";
                    break;
                case 2:
                    eol1 = "\r";
                    break;
                case 3:
                    eol1 = "\n\r";
                    break;
                default:
                    eol1 = "\n";
                    break;
            }
            lblEOL1.Text = cmbEOL1.Text;
        }




    }
}
