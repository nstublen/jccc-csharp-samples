using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace JCCC.Samples.CustomerLinq
{
    static class Program
    {
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Customer> customers = new List<Customer>();

            string cxnString = "Data Source=.\\SQLEXPRESS;"
                + "Initial Catalog=MMABooks;"
                + "Integrated Security=True;";
            using (SqlConnection cxn = new SqlConnection(cxnString))
            {
                cxn.Open();

                string select = "SELECT * FROM Customers ORDER BY Name";
                using (SqlCommand cmd = new SqlCommand(select, cxn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            Customer c = new Customer();
                            c.ID = reader.GetInt32(reader.GetOrdinal("CustomerID"));
                            c.Name = reader.GetString(reader.GetOrdinal("Name"));
                            c.Address = reader.GetString(reader.GetOrdinal("Address"));
                            c.City = reader.GetString(reader.GetOrdinal("City"));
                            c.State = reader.GetString(reader.GetOrdinal("State"));
                            c.ZipCode = reader.GetString(reader.GetOrdinal("ZipCode"));

                            customers.Add(c);
                        }
                    } // SqlDataReader
                } // SqlCommand
            } // SqlConnection

            var matches = from c in customers
                          where c.Name.StartsWith("Ce")
                          orderby c.Name
                          select c;
            foreach (Customer c in matches)
            {
                Console.WriteLine(c.Name);
            }
            MessageBox.Show(String.Format("Found {0} customers", matches.Count()));
        }
    }
}
