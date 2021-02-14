using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przekazanie_argumentu_metodzie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCard(string card)
        {
            switch (card)
            {
                case "As pik":
                    ShowAceSpades();
                    break;
                case "10 kier":
                    ShowTenHearts();
                    break;
                case "Król trefl":
                    ShowKingClubs();
                    break;
            }
        }
        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void ShowTenHearts()
        {
            tenHeartsPictureBox.Visible = true;
            aceSpadesPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void ShowKingClubs()
        {
            kingClubsPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            aceSpadesPictureBox.Visible = false;
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Proszę wybrać dowolną " + "kartę z lity.");
            }

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
