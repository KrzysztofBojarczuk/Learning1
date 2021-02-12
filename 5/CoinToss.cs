using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            int sideUp;

            Random rand = new Random();

            sideUp = rand.Next(2);

            if (sideUp == 0)
            {
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }
        }
    }
}
