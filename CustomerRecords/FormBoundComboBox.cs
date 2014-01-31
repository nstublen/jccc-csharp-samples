using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCC.Samples.CustomerRecords
{
    public partial class FormBoundComboBox : Form
    {
        public FormBoundComboBox()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);
        }

        private void FormBoundComboBox_Load(object sender, EventArgs e)
        {
            this.statesTableAdapter.Fill(this.statesDataSet.States);
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
        }
    }
}
