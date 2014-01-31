using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CustomerImport
{
    public partial class FormCustomerImport : Form
    {
        public FormCustomerImport()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImportCustomers(openFileDialog.FileName);
            }
        }

        private void ImportCustomers(string inFilename)
        {
            tvwCustomers.Nodes.Clear();

            TreeNode root = tvwCustomers.Nodes.Add("Customers");

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.IgnoreWhitespace = true;
            using (XmlReader reader = XmlReader.Create(inFilename, settings))
            {
                if (reader.ReadToDescendant("Customer"))
                {
                    // We should now be at the Customer node (or
                    // there is no Cusomters node).
                    do
                    {
                        Console.WriteLine("NodeType: {0}, Name: {1}, Value: {2}", reader.NodeType.ToString(), reader.Name, reader.Value);
                        if (reader.Name == "Customer")
                        {
                            ImportCustomerNode(root, reader);
                        }
                    } while (reader.ReadToNextSibling("Customer"));
                }
            }
            root.Expand();
        }

        private void ImportCustomerNode(TreeNode inRoot, XmlReader inReader)
        {
            string id = inReader.GetAttribute("id");
            TreeNode customerNode = inRoot.Nodes.Add("id=" + id);

            inReader.ReadStartElement("Customer");
            Console.WriteLine("NodeType: {0}, Name: {1}, Value: {2}", inReader.NodeType.ToString(), inReader.Name, inReader.Value);

            do
            {
                string content = inReader.ReadElementContentAsString();
                customerNode.Nodes.Add(content);
                Console.WriteLine("NodeType: {0}, Name: {1}, Value: {2}", inReader.NodeType.ToString(), inReader.Name, inReader.Value);
            } while (inReader.NodeType != XmlNodeType.EndElement);
            Console.WriteLine("NodeType: {0}, Name: {1}, Value: {2}", inReader.NodeType.ToString(), inReader.Name, inReader.Value);
        }
    }
}
