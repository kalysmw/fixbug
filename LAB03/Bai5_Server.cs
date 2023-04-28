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
    public partial class Bai5_Server : Form
    {

        TcpListener tcpListener;
        IPEndPoint ipepServer;
        List<NetworkStream> networStreams = new List<NetworkStream>();

        public Bai5_Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void bt_Listen_Click(object sender, EventArgs e)
        {
            //start server
            richTextBox1.AppendText("SERVER Started!!\n");

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
                byte[] recv = new byte[1024];
                client.Receive(recv);
                SendAll(Encoding.UTF8.GetString(recv).Replace("\0", ""));
                richTextBox1.Text += Encoding.UTF8.GetString(recv).Replace("\0", "") + "\n";
            }
        }


        private void SendAll(string mess)
        {
            foreach (NetworkStream ns in networStreams)
            {
                byte[] data = Encoding.UTF8.GetBytes(mess);
                ns.Flush();
                ns.Write(data, 0, data.Length);
            }
        }

        private void AcceptConnection()
        {
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                Socket client = tcpClient.Client;
                NetworkStream ns = tcpClient.GetStream();
                networStreams.Add(ns);

                string[] clientInfo = { ((IPEndPoint)client.RemoteEndPoint).Address.ToString(), ((IPEndPoint)client.RemoteEndPoint).Port.ToString() };

                Thread acceptConnection = new Thread(() => ReceiveMessage(client));
                acceptConnection.Start();

                richTextBox1.AppendText("New client an connected: " + clientInfo[0] + " : " + clientInfo[1] + "\n");
            }
        }

        private void Bai5_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpListener.Stop();
        }
    }
}
