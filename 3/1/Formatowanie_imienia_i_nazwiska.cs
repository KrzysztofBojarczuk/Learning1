using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formatowanie_imienia_i_nazwiska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName;

            fullName = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " "
                + textBox4.Text;

            label6.Text = fullName;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullName;

            fullName = textBox1.Text + " " + textBox2.Text + " " +
                textBox3.Text;

            label6.Text = fullName;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fullName;

            fullName = textBox1.Text + " " + textBox2.Text;

            label6.Text = fullName;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fullName;
             
            fullName = textBox3.Text + ", " + textBox2.Text + " " + textBox1.Text +
                ", " + textBox4.Text;

            label6.Text = fullName;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fullName;

            fullName = textBox3.Text + ", " + textBox2.Text + " " + textBox1.Text;

            label6.Text = fullName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fullName;

            fullName = textBox3.Text + ", " + textBox1.Text;

            label6.Text = fullName;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
