using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSorter
{
    public partial class FormNameSorter : Form
    {
        List<string> mNames = new List<string>();

        public FormNameSorter()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text;
            if (newName != "")
            {
                mNames.Add(newName);
            }

            mNames.Sort();

            string allNames = "";
            foreach (string name in mNames)
            {
                allNames += name + "\r\n";
            }
            txtSortedNames.Text = allNames;

            txtName.Text = "";
            txtName.Focus();
        }

        private void btnClearNames_Click(object sender, EventArgs e)
        {
            mNames.Clear();
            txtSortedNames.Text = "";
            txtName.Focus();
        }
    }
}
