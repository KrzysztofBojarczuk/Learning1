using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Method1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gotButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To jest metoda goButton_Click().");
            DisplayMessage();
            MessageBox.Show("Ponownie w metodzie goButton_Click().");
        }
        private void DisplayMessage()
        {
            MessageBox.Show("To jest metoda DisplayMessage().");

        }
    }
}
