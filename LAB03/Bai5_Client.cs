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
    public partial class Bai5_Client : Form
    {

        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;

        public Bai5_Client()
        {
            InitializeComponent();
        }


        private void bt_Test_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Connected to 127.0.0.1 SERVER Successfully!!\n");

            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);

            tcpClient.Connect(ipEndPoint);
            ns = tcpClient.GetStream();

            Socket client = tcpClient.Client;
            Thread acceptConnection = new Thread(() => ReceiveMessage(client));
            acceptConnection.Start();
        }

        private void ReceiveMessage(Socket client)
        {
            while (true)
            {
                try
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
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            string sendMessage = tb_Name.Text + ": " + tb_Message.Text;
            byte[] data = System.Text.Encoding.UTF8.GetBytes(sendMessage);
            ns.Write(data, 0, data.Length);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient.Close();
        }
    }
}
