using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        const double STREFAA = 15.0;
        const double STREFAB = 12.0;
        const double STREFAC = 9.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double numberOfClassASold = double.Parse(textBox1.Text);
                double numberOfClassBSold = double.Parse(textBox2.Text);
                double numberOfClassCSold = double.Parse(textBox3.Text);

                double revenue_ClassA = numberOfClassASold * STREFAA;
                label9.Text = revenue_ClassA.ToString("c");

                double revenue_ClassB = numberOfClassBSold * STREFAB;
                label10.Text = revenue_ClassB.ToString("c");

                double revenue_ClassC = numberOfClassCSold * STREFAC;
                label11.Text = revenue_ClassC.ToString("c");

                double totalRevenue = revenue_ClassA + revenue_ClassB + revenue_ClassC;
                label12.Text = totalRevenue.ToString("c");

                button2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";

            textBox1.Focus();
        }
    }
}
