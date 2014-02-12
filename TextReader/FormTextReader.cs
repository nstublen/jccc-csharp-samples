using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JCCC.Samples.TextReader
{
    public partial class FormTextReader : Form
    {
        public FormTextReader()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                txtFilename.Text = filename;

                ReadFile(filename);
            }
        }

        private void ReadFile(string inFilename)
        {
            lvwFileContent.Items.Clear();

            try
            {
                // The "using" blocks ensure use of IDisposable on streams.

                using (FileStream stream = new FileStream(inFilename, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        int lineCounter = 1;
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = (lineCounter++).ToString();
                            lvi.SubItems.Add(line);
                            lvwFileContent.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
