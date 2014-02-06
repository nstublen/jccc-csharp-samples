using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace JCCC.Samples.XMLReader
{
    public partial class FormXmlReader : Form
    {
        public FormXmlReader()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtReader.Text = "";
                lvwReader.Items.Clear();

                ReadXmlText(openFileDialog.FileName);
                ReadXmlReader(openFileDialog.FileName);
            }
        }

        private void ReadXmlReader(string inFilename)
        {
            using (XmlReader reader = XmlReader.Create(inFilename))
            {
                while (reader.Read() && lvwReader.Items.Count < 1000)
                {
                    ListViewItem lvi = lvwReader.Items.Add(reader.NodeType.ToString());
                    lvi.SubItems.Add(reader.Name);
                    lvi.SubItems.Add(reader.AttributeCount.ToString());
                    lvi.SubItems.Add(reader.Value);
                }
            }
        }

        private void ReadXmlText(string inFilename)
        {
            using (StreamReader reader = new StreamReader(inFilename))
            {
                while (!reader.EndOfStream)
                {
                    txtReader.Text += reader.ReadToEnd();
                }
            }
        }
    }
}
