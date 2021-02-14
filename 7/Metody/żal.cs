using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace żal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayValue(int value)
        {
            MessageBox.Show(value.ToString());
        }

        private void demo1Button_Click(object sender, EventArgs e)
        {
            DisplayValue(5);
        }

        private void demo2Button_Click(object sender, EventArgs e)
        {
            DisplayValue(3 + 5);
        }

        private void demo3Button_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < 5; count++)
            {
                DisplayValue(count);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
