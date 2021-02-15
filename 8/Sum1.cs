using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int userAge, friendAge, combinedAge;

            if (int.TryParse(age1TextBox.Text, out userAge))
            {
                if (int.TryParse(age2TextBox.Text, out friendAge))
                {
                    combinedAge = Sum(userAge, friendAge);
                    combinedAgeLabel.Text = combinedAge.ToString();
                }
                else
                {
                    MessageBox.Show("Podaj liczbę całkowitą.");
                }
            }
            else
            {
                MessageBox.Show("Podaj liczbę całkowitą");
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
