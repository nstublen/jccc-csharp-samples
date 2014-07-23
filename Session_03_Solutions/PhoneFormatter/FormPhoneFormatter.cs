using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneFormatter
{
    public partial class FormPhoneFormatter : Form
    {
        public FormPhoneFormatter()
        {
            InitializeComponent();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string entry = txtPhoneNumber.Text;
            int length = entry.Length;

            if (length > 4)
            {
                if (length <= 10)
                {
                    entry = entry.Insert(length - 4, "-");
                    if (length > 7)
                    {
                        entry = entry.Insert(length - 7, ") ");
                        entry = entry.Insert(0, "(");
                    }
                }
                else
                {
                    entry = entry.Insert(10, " ");
                    entry = entry.Insert(6, "-");
                    entry = entry.Insert(3, ") ");
                    entry = entry.Insert(0, "(");
                }
            }

            lblFormattedNumber.Text = entry;
        }
    }
}
