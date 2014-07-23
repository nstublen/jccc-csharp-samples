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
    public partial class FormSecondary : Form
    {
        private string mName;

        public FormSecondary()
        {
            InitializeComponent();
        }

        private void FormSecondary_Load(object sender, EventArgs e)
        {
            txtName.Text = mName;
            txtName.Focus();
            txtName.SelectAll();
        }

        public string getName()
        {
            return mName;
        }

        public void setName(string inName)
        {
            mName = inName;
        }

        private void FormSecondary_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mName != txtName.Text)
            {
                DialogResult confirm;
                if (DialogResult == DialogResult.OK)
                {
                    confirm = MessageBox.Show("Are you sure you want to change the name?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    if (confirm == DialogResult.Yes)
                    {
                        mName = txtName.Text;
                    }
                }
                else
                {
                    confirm = MessageBox.Show("Are you sure you want to lose your changes?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                }

                if (confirm != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
