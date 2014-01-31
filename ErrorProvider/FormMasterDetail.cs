using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCC.Samples.ErrorProvider
{
    public partial class FormMasterDetail : Form
    {
        public FormMasterDetail()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);

        }

        bool changing = false;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!changing)
            {
                changing = true;
                customersBindingSource.ResetItem(listBox1.SelectedIndex);
                changing = false;
            }
        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = !toolStrip.Visible;
        }
    }
}
