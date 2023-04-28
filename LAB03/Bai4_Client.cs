using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Bai4_Client : Form
    {
        private TcpClient tcpClient;
        private NetworkStream netStream;
        private bool isConnected = false;

        private readonly IPEndPoint primaryServerEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);
        private readonly IPEndPoint backupServerEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5051);

        public Bai4_Client()
        {
            InitializeComponent();
            tcpClient = new TcpClient();
        }

        private void ConnectToServer()
        {
            try
            {
                tcpClient.Connect(primaryServerEndPoint);
                netStream = tcpClient.GetStream();
                isConnected = true;
            }
            catch
            {
                try
                {
                    tcpClient.Connect(backupServerEndPoint);
                    netStream = tcpClient.GetStream();
                    isConnected = true;
                }
                catch
                {
                    isConnected = false;
                }
            }

            if (isConnected)
            {
                // Show a message to indicate the connection status.
                MessageBox.Show("Connected to the server.");
            }
            else
            {
                // Show a message to indicate the failure to connect.
                MessageBox.Show("Failed to connect to the server.");
            }
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void bt_Send_Click_1(object sender, EventArgs e)
        {
            if (netStream != null)
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(richTextBox1.Text);
                netStream.Write(data, 0, data.Length);
            }
        }

        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
            if (netStream != null)
            {
                netStream.Close();
            }
            isConnected = false;
        }
    }
}