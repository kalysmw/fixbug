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
    public partial class Bai5_Form : Form
    {

        public Bai5_Form()
        {
            InitializeComponent();
        }

        private void bt_ClientBox_Click(object sender, EventArgs e)
        {
            Bai5_Client client = new Bai5_Client();
            client.Show();


        }

        private void bt_ServerBox_Click(object sender, EventArgs e)
        {
            Bai5_Server server = new Bai5_Server();
            server.Show();
        }

        private void Bai5_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
