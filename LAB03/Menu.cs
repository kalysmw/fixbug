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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3_Form bai3 = new Bai3_Form();
            bai3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5_Form bai5 = new Bai5_Form();
            bai5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4_Form bai4 = new Bai4_Form();
            bai4.Show();
        }
    }
}
