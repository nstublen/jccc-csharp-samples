using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCC.Samples.UserControls
{
    public partial class FormControlHost : Form
    {
        public FormControlHost()
        {
            InitializeComponent();
        }

        private void FormControlHost_Load(object sender, EventArgs e)
        {
            labelEdit1.TextChanged += new EventHandler<TextChangedEventArgs>(labelEdit1_TextChanged);
        }

        void labelEdit1_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblOldText.Text = e.OldText;
            lblNewText.Text = e.NewText;
        }
    }
}
