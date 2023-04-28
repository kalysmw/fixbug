using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Bai4_Form : Form
    {
        public Bai4_Form()
        {
            InitializeComponent();
        }

        private void bt_ServerBox_Click(object sender, EventArgs e)
        {
            Bai4_Server server = new Bai4_Server();
            server.Show();
        }

        private void bt_ClientBox_Click(object sender, EventArgs e)
        {
            
        }

        private void Bai4_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_ClientBox_Click_1(object sender, EventArgs e)
        {
            Bai4_Client client = new Bai4_Client();
            client.Show();
        }
    }
}
