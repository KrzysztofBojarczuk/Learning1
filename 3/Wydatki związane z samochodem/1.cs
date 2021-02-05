using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wydatki_związane_z_samochodem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rataKredytu = double.Parse(textBox1.Text);
            double ubezpieczenie = double.Parse(textBox2.Text);
            double paliwo = double.Parse(textBox3.Text);
            double olej = double.Parse(textBox4.Text);
            double opony = double.Parse(textBox5.Text);
            double serwis = double.Parse(textBox6.Text);

            double miesięczneKoszty = rataKredytu + ubezpieczenie + paliwo + olej +
                opony + serwis;

            double roczneKoszty = miesięczneKoszty * 12;

            textBox1.Text = rataKredytu.ToString("c");
            textBox2.Text = ubezpieczenie.ToString("c");
            textBox3.Text = paliwo.ToString("c");
            textBox4.Text = olej.ToString("c");
            textBox5.Text = opony.ToString("c");
            textBox6.Text = serwis.ToString("c");

            label7.Text = miesięczneKoszty.ToString("c");
            label8.Text = roczneKoszty.ToString("c");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
