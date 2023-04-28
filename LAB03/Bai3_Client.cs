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

    public partial class Bai3_Client : Form
    {

        //private const int port_Number = 5050;

        TcpClient tcpClient = new TcpClient();
        NetworkStream netStream;

        public Bai3_Client()
        {
            InitializeComponent();
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);

            tcpClient.Connect(ipEndPoint);
            netStream = tcpClient.GetStream();

        }


        private void bt_Send_Click(object sender, EventArgs e)
        {
            if (netStream != null)
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(richTextBox1.Text);
                netStream.Write(data, 0, data.Length);
            }
        }

        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            tcpClient.Close();
            netStream.Close();
        }

    }
}
