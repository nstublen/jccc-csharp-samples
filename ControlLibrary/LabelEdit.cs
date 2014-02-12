using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JCCC.Samples.UserControls
{
    public partial class LabelEdit : UserControl
    {
        public LabelEdit()
        {
            InitializeComponent();
        }

        public void BeginEdit()
        {
            txtText.Text = lblText.Text;
            lblText.Hide();
            txtText.Show();
            txtText.Focus();
        }

        public void CancelEdit(bool inSaveChanges)
        {
            if (inSaveChanges)
            {
                string oldText = lblText.Text;
                lblText.Text = txtText.Text;
                if (oldText != lblText.Text)
                {
                    if (TextChanged != null)
                    {
                        TextChanged(this, new TextChangedEventArgs() { OldText = oldText, NewText = lblText.Text });
                    }
                }
            }
            lblText.Show();
            txtText.Hide();
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new event EventHandler<TextChangedEventArgs> TextChanged;

        private void LabelEdit_SizeChanged(object sender, EventArgs e)
        {
            txtText.Location = new Point(0, 0);
            txtText.Size = new Size(Width, Height);

            lblText.Location = new Point(0, 0);
        }

        private void lblText_DoubleClick(object sender, EventArgs e)
        {
            BeginEdit();
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\r') || (e.KeyChar == 27))
            {
                CancelEdit(e.KeyChar == '\r');
            }
        }

        private void txtText_Leave(object sender, EventArgs e)
        {
            CancelEdit(false);
        }
    }

    public class TextChangedEventArgs : EventArgs
    {
        public string OldText;
        public string NewText;
    }
}
