using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Xml;

namespace CustomerExport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (MemoryStream stringWriter = new MemoryStream())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "  ";
                settings.Encoding = System.Text.Encoding.UTF8;

                using (XmlWriter writer = XmlWriter.Create(stringWriter, settings))
                {
                    string cxnString = "Data Source=.\\SQLEXPRESS;"
                        + "Initial Catalog=MMABooks;"
                        + "Integrated Security=True;";
                    using (SqlConnection cxn = new SqlConnection(cxnString))
                    {
                        cxn.Open();

                        writer.WriteStartDocument();

                        string select = "SELECT * FROM Customers ORDER BY Name";
                        using (SqlCommand cmd = new SqlCommand(select, cxn))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                            {
                                writer.WriteStartElement("Customers");

                                while (reader.Read())
                                {
                                    writer.WriteStartElement("Customer");

                                    int idColumn = reader.GetOrdinal("CustomerID");
                                    int id = reader.GetInt32(idColumn);
                                    writer.WriteAttributeString("id", id.ToString());

                                    for (int column = 0; column < reader.FieldCount; ++column)
                                    {
                                        if (column == idColumn)
                                            continue;
                                        string name = reader.GetName(column);
                                        string value = reader.GetSqlValue(column).ToString();

                                        writer.WriteElementString(name, value);
                                    }

                                    writer.WriteEndElement();
                                }

                                writer.WriteEndElement();
                            } // SqlDataReader
                        } // SqlCommand
                    } // SqlConnection
                } // XmlWriter

                // Dump the XML string to a file on the desktop.
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using (FileStream export = new FileStream(path + "\\Customers.xml", FileMode.Create, FileAccess.Write))
                {
                    stringWriter.WriteTo(export);
                }
            } // MemoryStream
        }
    }
}
