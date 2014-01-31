using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCC.Samples.LinqSample
{
    public partial class FormLinqSample : Form
    {
        public FormLinqSample()
        {
            InitializeComponent();
        }

        private bool CheckName(string inName, string inSubstring)
        {
            string[] parts = inName.Split(',');
            return parts[0].Trim().Contains(inSubstring);
        }

        private void FormLinqSample_Load(object sender, EventArgs e)
        {
            MMABooksDataContext db = new MMABooksDataContext();

            var inv = from c in db.Customers
                      join i in db.Invoices
                      on c.CustomerID equals i.CustomerID
                      orderby c.Name
                      select new { c.Name, i.InvoiceDate, i.InvoiceTotal };
            foreach (var i in inv)
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}", i.Name, i.InvoiceDate, i.InvoiceTotal));
            }

            var customers = from c in db.Customers
                            orderby c.Name
                            select c;

            var list = new List<Customer>();
            foreach (Customer c in customers)
            {
                list.Add(c);
            }

            var reduced = from c in list
                          where CheckName(c.Name, "ub")
                          select c;

            foreach (Customer c in reduced)
            {
                listBox1.Items.Add(c.Name);
            }

            foreach (Customer c in customers)
            {
                c.Name.Replace("ub", "--ub--");
            }

            db.SubmitChanges();

            foreach (Customer c in customers)
            {
                c.Name.Replace("--ub--", "ub");
            }

            db.SubmitChanges();

            Customer me = new Customer();
            me.Name = "Stublen, Neal";
            me.Address = "12345 College Ave.";
            me.City = "Overland Park";
            me.State = "KS";
            me.ZipCode = "66???";
            db.Customers.InsertOnSubmit(me);

            db.SubmitChanges();

            Invoice invoice = new Invoice();
            invoice.InvoiceDate = DateTime.Now;
            me.Invoices.Add(invoice);

            db.SubmitChanges();
        }
    }
}
