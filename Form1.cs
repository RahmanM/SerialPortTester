using System;
using System.Windows.Forms;

namespace ArduinoSamples
{
    public partial class Form1 : Form
    {


        private bool _Connected = false;
        private bool _ReceiveConnected;

        public Form1()
        {
            InitializeComponent();
        }


        #region "General"

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                serialCommSend.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSendPort.Text = "COM7";
        }

        #endregion

        #region "Send message"

        private void buttonOn_Click(object sender, EventArgs e)
        {

            try
            {
                // NB: The NewLine is required at the end, otherwise SerialPort can't read it and returns null
                serialCommSend.Write(txtSendMessage.Text + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(!serialCommSend.IsOpen)
                {
                    serialCommSend.PortName = cmbSendPort.Text;
                    serialCommSend.Open();
                    _Connected = true;
                }
                
            }
            catch (Exception ex)
            {
                _Connected = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSendPort.SelectedIndex != -1)
            {
                cmdSendConnect.Enabled = true;
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            if (txtSendMessage.Text != "" && _Connected ==true && cmdSendConnect.Enabled==true)
            {
                cmdSend.Enabled = true;
            }
        }

        #endregion

        #region "Receive message"

        private void serialCommReceive_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            try
            {
                while (true)
                {
                    if (serialCommReceive.BytesToRead == 0) return;

                    var data = serialCommReceive.ReadLine();
                    txtMessageReceived.InvokeRequired(c => c.Text += data.ToString() + Environment.NewLine);
                }

  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdReceiveConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialCommReceive.IsOpen)
                {
                    serialCommReceive.PortName = cmbRecievePort.Text;
                    serialCommReceive.Open();
                    _ReceiveConnected = true;
                }

            }
            catch (Exception ex)
            {
                _ReceiveConnected = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbRecievePort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRecievePort.SelectedIndex != -1)
            {
                cmdReceiveConnect.Enabled = true;
            }
        }

        #endregion

    }

    /// <summary>
    /// Extension method that enables to communicate to the UI thread
    /// </summary>
    public static class ControlExtensions
    {
        public static void InvokeRequired<T>(this T c, Action<T> action) where T : Control
        {
            if (c.InvokeRequired)
            {
                c.Invoke(new Action(() => action(c)));
            }
            else
            {
                action(c);
            }
        }
    }

}
