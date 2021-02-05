using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                if(hoursWorked > BASE_HOURS)
                {
                    basePay = hourlyPayRate * BASE_HOURS;

                    overtimeHours = hoursWorked - BASE_HOURS;

                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;

                    grossPay = basePay + overtimePay;
                }
                else
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }

                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
