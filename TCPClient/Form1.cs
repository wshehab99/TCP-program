using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new(txtIp.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            sendButton.Enabled = false;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server : {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
            
        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server disconnected.{Environment.NewLine}";
            });
            
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server connected.{Environment.NewLine}";
            });
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                sendButton.Enabled = true;
                connectButton.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMeseege.Text))
                {
                    client.Send(txtMeseege.Text);
                    txtInfo.Text += $"Me : {txtMeseege.Text}{Environment.NewLine}";
                    txtMeseege.Text = "";
                }
            }
        }
    }
}
