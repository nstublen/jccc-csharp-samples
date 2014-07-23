using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsCalculator
{
    public partial class FormCalculator : Form
    {
        private Calculator mCalculator = new Calculator();

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            UpdateForm();
            PrepareForNextEntry();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(txtNewValue.Text);
                mCalculator.AddValue(value);
                PrepareForNextEntry();
            }
            catch
            {
                txtNewValue.Focus();
                txtNewValue.SelectAll();
            }

            UpdateForm();
        }

        private void PrepareForNextEntry()
        {
            txtNewValue.Text = "";
            txtNewValue.Focus();
        }

        private void UpdateForm()
        {
            lblCount.Text = mCalculator.Count.ToString();
            lblSum.Text = mCalculator.Sum.ToString();
            lblAverage.Text = mCalculator.Average.ToString();
            lblMaximum.Text = mCalculator.Maximum.ToString();
            lblMinimum.Text = mCalculator.Minimum.ToString();
        }
    }
}
