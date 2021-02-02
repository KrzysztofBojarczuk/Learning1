using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeden");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Dwa");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trzy");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cztery");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pięć");
        }
    }
}
