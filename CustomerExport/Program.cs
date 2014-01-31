using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Xml;

namespace JCCC.Samples.CustomerExport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Dump the Customers.xml file to the desktop.
            string xmlFilename = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            xmlFilename = Path.Combine(xmlFilename, "Customers.xml");

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "  ";
            settings.Encoding = System.Text.Encoding.UTF8;

            // Write the XML to a memory buffer. When we're done,
            // we'll dump the memory buffer into a file.
            using (MemoryStream memoryStream = new MemoryStream())
            {
                string cxnString = "Data Source=.\\SQLEXPRESS;"
                    + "Initial Catalog=MMABooks;"
                    + "Integrated Security=True;";
                using (SqlConnection cxn = new SqlConnection(cxnString))
                {
                    string select = "SELECT * FROM Customers ORDER BY Name";
                    using (SqlCommand cmd = new SqlCommand(select, cxn))
                    {
                        cxn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            using (XmlWriter writer = XmlWriter.Create(memoryStream, settings))
                            {
                                writer.WriteStartDocument();
                                WriteCustomers(reader, writer);
                            } // XmlWriter
                        } // SqlDataReader
                    } // SqlCommand
                } // SqlConnection

                // Dump the MemoryStream to a file.
                using (FileStream export = new FileStream(xmlFilename, FileMode.Create, FileAccess.Write))
                {
                    memoryStream.WriteTo(export);
                }
            } // MemoryStream
        } // Main

        /// <summary>
        /// Loop through the SqlDataReader and write each Customer
        /// record to the XMLWriter.
        /// </summary>
        /// <param name="inReader">The SqlDataReader that contains
        /// the query results from a Customer table.</param>
        /// <param name="inWriter">The XmlWriter that will receive
        /// the XML-formatter Customer records.</param>
        private static void WriteCustomers(SqlDataReader inReader, XmlWriter inWriter)
        {
            inWriter.WriteStartElement("Customers");

            while (inReader.Read())
            {
                inWriter.WriteStartElement("Customer");

                // Find the CustomerID column and use its
                // value as the "id" attribute.
                int idColumn = inReader.GetOrdinal("CustomerID");
                int id = inReader.GetInt32(idColumn);
                inWriter.WriteAttributeString("id", id.ToString());

                // All the other columns are child elements
                // of the Customer element.
                for (int column = 0; column < inReader.FieldCount; ++column)
                {
                    if (column == idColumn)
                        continue;
                    string name = inReader.GetName(column);
                    string value = inReader.GetSqlValue(column).ToString();

                    inWriter.WriteElementString(name, value);
                }

                inWriter.WriteEndElement();
            }

            inWriter.WriteEndElement();
        }
    } // class Program
}
