namespace JCCC.Samples.UserControls
{
    partial class FormControlHost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOldText = new System.Windows.Forms.Label();
            this.lblNewText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEdit1 = new JCCC.Samples.UserControls.LabelEdit();
            this.SuspendLayout();
            // 
            // lblOldText
            // 
            this.lblOldText.AutoSize = true;
            this.lblOldText.Location = new System.Drawing.Point(81, 107);
            this.lblOldText.Name = "lblOldText";
            this.lblOldText.Size = new System.Drawing.Size(13, 13);
            this.lblOldText.TabIndex = 1;
            this.lblOldText.Text = "--";
            // 
            // lblNewText
            // 
            this.lblNewText.AutoSize = true;
            this.lblNewText.Location = new System.Drawing.Point(81, 130);
            this.lblNewText.Name = "lblNewText";
            this.lblNewText.Size = new System.Drawing.Size(13, 13);
            this.lblNewText.TabIndex = 2;
            this.lblNewText.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Old text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "New text:";
            // 
            // labelEdit1
            // 
            this.labelEdit1.Location = new System.Drawing.Point(26, 22);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(143, 62);
            this.labelEdit1.TabIndex = 0;
            this.labelEdit1.Text = "Double-click to edit";
            this.labelEdit1.TextChanged += new System.EventHandler<JCCC.Samples.UserControls.TextChangedEventArgs>(this.labelEdit1_TextChanged);
            // 
            // FormControlHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNewText);
            this.Controls.Add(this.lblOldText);
            this.Controls.Add(this.labelEdit1);
            this.Name = "FormControlHost";
            this.Text = "UserControl Host";
            this.Load += new System.EventHandler(this.FormControlHost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JCCC.Samples.UserControls.LabelEdit labelEdit1;
        private System.Windows.Forms.Label lblOldText;
        private System.Windows.Forms.Label lblNewText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

