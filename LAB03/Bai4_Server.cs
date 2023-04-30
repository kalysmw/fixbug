using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Bai4_Server : Form
    {
        TcpListener tcpListener;
        IPEndPoint ipepServer;

        TcpListener tcpBackupListener;
        IPEndPoint ipepBackupServer;

        bool isPrimaryServer = true;
        bool isStopped = false;

        public Bai4_Server()
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
           

            ipepBackupServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5051);
            tcpBackupListener = new TcpListener(ipepBackupServer);
            tcpBackupListener.Start();

            StartUnsafeThread();

            bt_Listen.Enabled = false;
        }

        private void StartUnsafeThread()
        {
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

                    string message = Encoding.UTF8.GetString(recv).Replace("\0", "") + "\n";
                        richTextBox1.Text += message;
                    
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
                    TcpClient tcpClient;

                    if (isPrimaryServer)
                    {
                        tcpClient = tcpListener.AcceptTcpClient();
                    }
                    else
                    {
                        tcpClient = tcpBackupListener.AcceptTcpClient();
                        richTextBox1.Text = "\nConnect Server Backup\n";
                    }

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

        private void Bai4_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            isStopped = true;
            tcpListener.Stop();
            tcpBackupListener.Stop();
        }
    }
}