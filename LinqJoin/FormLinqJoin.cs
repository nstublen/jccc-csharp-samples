using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCC.Samples.LinqJoin
{
    public partial class FormLinqJoin : Form
    {
        public FormLinqJoin()
        {
            InitializeComponent();
        }

        private void FormLinqJoin_Load(object sender, EventArgs e)
        {
            CustomerInvoicesDataContext db = new CustomerInvoicesDataContext();
            var results = from c in db.Customers
                          orderby c.Name
                          join i in db.Invoices on c.CustomerID equals i.CustomerID
                          select new { Name = c.Name, InvoiceDate = i.InvoiceDate, InvoiceTotal = i.InvoiceTotal };

            foreach (var result in results)
            {
                ListViewItem lvi = new ListViewItem(result.Name);
                lvi.SubItems.Add(result.InvoiceDate.ToShortDateString());
                lvi.SubItems.Add(result.InvoiceTotal.ToString("c"));
                lvwResults.Items.Add(lvi);
            }
        }
    }
}
