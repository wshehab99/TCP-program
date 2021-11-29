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

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SimpleTcpServer server;
        private void startButton_Click(object sender, EventArgs e)
        {
            //start TCP serve
            server.Start();

            txtInfo.Text += $"Starting ...{Environment.NewLine}";
            startButton.Enabled = false;
            sendButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sendButton.Enabled = false;
            server = new SimpleTcpServer(txtIp.Text);
            server.Events.ClientConnected += Event_ClientConnected;
            server.Events.ClientDisconnected+= Event_ClientDisConnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} : {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
            
        }

        private void Event_ClientDisConnected(object sender, ClientDisconnectedEventArgs e)
        {
            //excute the code in another thread
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                clientIPList.Items.Remove(e.IpPort);
            });
            
        }

        private void Event_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            //excute the code in another thread
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                clientIPList.Items.Add(e.IpPort);
            });
           
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(txtMeseege.Text)&&clientIPList.SelectedItem!=null)
                {
                    server.Send(clientIPList.SelectedItem.ToString(), txtMeseege.Text);
                    txtInfo.Text += $"Server : {txtMeseege.Text}{Environment.NewLine}";
                    txtMeseege.Text = "";

                }
            }
        }
    }
}
