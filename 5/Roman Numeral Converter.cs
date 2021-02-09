using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int inputNumber;

            if (int.TryParse(numberTextBox.Text, out inputNumber))
            {
                if (inputNumber >= 1 && inputNumber <= 10)
                {
                    switch (inputNumber)
                    {
                        case 1:
                            romanNumberLabel.Text = "I";
                            break;

                        case 2:
                            romanNumberLabel.Text = "II";
                            break;

                        case 3:
                            romanNumberLabel.Text = "III";
                            break;

                        case 4:
                            romanNumberLabel.Text = "IV";
                            break;

                        case 5:
                            romanNumberLabel.Text = "V";
                            break;

                        case 6:
                            romanNumberLabel.Text = "IV";
                            break;

                        case 7:
                            romanNumberLabel.Text = "VII";
                            break;

                        case 8:
                            romanNumberLabel.Text = "VIII";
                            break;

                        case 9:
                            romanNumberLabel.Text = "IX";
                            break;

                        case 10:
                            romanNumberLabel.Text = "X";
                            break;

                    }
                }
                else
                {
                    MessageBox.Show("Podaj liczbe z przedziału od 1 do 10");
                }
            }
            else
            {
                MessageBox.Show("Wprowadź prawidłową liczbę całkowitą.");
            }
            numberTextBox.Focus();
        }
    }
}
