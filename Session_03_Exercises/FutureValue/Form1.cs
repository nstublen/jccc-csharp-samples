using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FutureValue
{
    // This is the solution to exercise 9-3 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment =
                        Convert.ToDecimal(
                            Strip(txtMonthlyInvestment.Text));
                    decimal yearlyInterestRate =
                        Convert.ToDecimal(
                            Strip(txtInterestRate.Text));
                    int years =
                        Convert.ToInt32(
                            Strip(txtYears.Text));

                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate, months);

                    decimal interestRatePercent = yearlyInterestRate / 100;
                    txtMonthlyInvestment.Text = monthlyInvestment.ToString("c");
                    txtInterestRate.Text = interestRatePercent.ToString("p");
                    txtYears.Text = years.ToString();
                    txtFutureValue.Text = futureValue.ToString("c");

                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        public bool IsValidData()
        {
            return
                // Validate the Monthly Investment text box
                IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
                IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

                // Validate the Yearly Interest Rate text box
                IsPresent(txtInterestRate, "Yearly Interest Rate") &&
                IsDecimal(txtInterestRate, "Yearly Interest Rate") &&
                IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 20) &&

                // Validate the Number of Years text box
                IsPresent(txtYears, "Number of Years") &&
                IsInt32(txtYears, "Number of Years") &&
                IsWithinRange(txtYears, "Number of Years", 1, 40);
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        // the new IsDecimal method
        public bool IsDecimal(TextBox textBox, string name)
        {
            //make sure the string only contains numbers and numeric formatting
            string s = textBox.Text;
            int decimalCount = 0;
            bool validDecimal = true;
            foreach (char c in s)
            {
                if (!(
                    c == '0' || c == '1' || c == '2' ||   // numeric chars
                    c == '3' || c == '4' || c == '5' ||
                    c == '6' || c == '7' || c == '8' ||
                    c == '9' || c == '.' ||
                    c == '$' || c == '%' || c == ',' ||  // formatting chars
                    c == ' '
                    ))
                {
                    validDecimal = false;
                    break;
                }
                if (c == '.')
                {
                    decimalCount++;
                }
            } // end loop

            if (validDecimal && decimalCount <= 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal number.",
                    "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        // a method that strips invald chars from a numeric string
        public string Strip(string s)
        {
            // Handle invalid characters, including: $, %, commas, spaces

            return s;
        }

        // the new IsInt32 method
        public bool IsInt32(TextBox textBox, string name)
        {
            //strip any invalid chars from the string
            string s = this.Strip(textBox.Text);

            //make sure the string only contains numbers
            //without a decimal point
            foreach (char c in s)
            {
                if (!(
                    c == '0' || c == '1' || c == '2' ||   // numeric chars
                    c == '3' || c == '4' || c == '5' ||
                    c == '6' || c == '7' || c == '8' ||
                    c == '9' || // no decimal point allowed
                    c == '$' || c == '%' || c == ',' ||  // formatting chars
                    c == ' '
                    ))
                {
                    MessageBox.Show(name + " must be an integer.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            string s = this.Strip(textBox.Text);
            decimal number = Convert.ToDecimal(s);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment,
            decimal interestRateMonthly, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + interestRateMonthly);
            }
            return futureValue;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}