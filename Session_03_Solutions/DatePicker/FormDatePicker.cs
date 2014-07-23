using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatePicker
{
    public partial class FormDatePicker : Form
    {
        public FormDatePicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime when = dateTimePicker1.Value;

            TimeSpan elapsed = DateTime.Now - when;

            lblYears.Text = ((int)elapsed.TotalDays / 365).ToString();
            lblDays.Text = ((int)elapsed.TotalDays % 365).ToString();
        }
    }
}
