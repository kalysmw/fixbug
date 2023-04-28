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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void client_Click(object sender, EventArgs e)
        {
            
        }

        private void server_Click(object sender, EventArgs e)
        {
            server_bai3 server_Bai3 = new server_bai3();
            server_Bai3.Show();
        }
        private void client_Click_1(object sender, EventArgs e)
        {
            client_bai3 client_Bai3 = new client_bai3();
            client_Bai3.Show();
        }
    }
}
