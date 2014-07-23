using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormSecondary frm = new FormSecondary();
            
            // Solution 1: Pass the name in the form's Tag property.
            // frm.Tag = lblName.Text;

            // Solution 2 (Better): Use a method.
            frm.setName(lblName.Text);

            if (DialogResult.OK == frm.ShowDialog())
            {
                // lblName.Text = (string)frm.Tag;

                lblName.Text = frm.getName();
            }
        }
    }
}
