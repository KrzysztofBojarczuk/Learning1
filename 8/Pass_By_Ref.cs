using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_By_Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetToZero(ref int number)
        {
            number = 0;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int x = 99, y = 100, z = 101;

            outputListBox.Items.Clear();
            outputListBox.Items.Add("Wartość zmiennej x wynosi " + x);
            outputListBox.Items.Add("Wartośc zmiennej y wynosi " + y);
            outputListBox.Items.Add("Wartość zmiennej z wnwosi " + z);

            SetToZero(ref x);
            SetToZero(ref y);
            SetToZero(ref z);

            outputListBox.Items.Add("--------------------------");
            outputListBox.Items.Add("Wartość zmiennej x wynosi " + x);
            outputListBox.Items.Add("Wartośc zmiennej y wynosi " + y);
            outputListBox.Items.Add("Wartość zmiennej z ynwosi " + z);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
