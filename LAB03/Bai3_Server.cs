using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Bai3_Server : Form
    {

        TcpListener tcpListener;
        IPEndPoint ipepServer;

        public Bai3_Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void bt_Listen_Click(object sender, EventArgs e)
        {
            //Server started
            richTextBox1.AppendText("SERVER Started\n");
            //

            ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);
            tcpListener = new TcpListener(ipepServer);
            tcpListener.Start();

            StartUnsafeThread();

            bt_Listen.Enabled = false;
        }

        private void StartUnsafeThread()
        {
            //AcceptConnection();
            Thread acceptConnection = new Thread(new ThreadStart(AcceptConnection));
            acceptConnection.Start();
        }
        private void ReceiveMessage(Socket client)
        {
            while (client.Connected)
            {
                try
                {
                    byte[] recv = new byte[1024];
                    client.Receive(recv);
                    richTextBox1.Text += Encoding.UTF8.GetString(recv).Replace("\0", "") + "\n";
                }
                catch (Exception ex)
                {
                    client.Close();
                    break;
                }
            }
        }


        private void AcceptConnection()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    Socket client = tcpClient.Client;
                    NetworkStream ns = tcpClient.GetStream();

                    //Get client information
                    IPEndPoint clientEndPoint = (IPEndPoint)tcpClient.Client.RemoteEndPoint;
                    string clientIPAddress = clientEndPoint.Address.ToString();
                    richTextBox1.AppendText(clientIPAddress + " connected!\n");

                    Thread acceptConnection = new Thread(() => ReceiveMessage(client));
                    acceptConnection.Start();
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ ở đây
                }

            }
        }

        private void Bai3_Server_FormClosing(object sender, FormClosingEventArgs e)
        {

            tcpListener.Stop();

        }
    }
}
