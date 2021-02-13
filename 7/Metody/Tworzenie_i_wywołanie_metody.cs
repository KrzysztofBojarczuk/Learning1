using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tworzenie_i_wywołanie_metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            lightOnPictureBox.Visible = true;

            lightOffPictureBox.Visible = false;

            lightStateLabel.Text = "Włączona";
        }

        private void TurnLightOff()
        {
            lightOffPictureBox.Visible = true;

            lightOnPictureBox.Visible = false;

            lightStateLabel.Text = "Wyłączona";
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            if (lightOnPictureBox.Visible == true)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
