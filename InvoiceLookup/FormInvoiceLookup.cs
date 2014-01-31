using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCC.Samples.InvoiceLookup
{
    public partial class FormInvoiceLookup : Form
    {
        public FormInvoiceLookup()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void FormInvoiceLookup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.customersDataSet.Invoices);
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);

        }

    }
}
