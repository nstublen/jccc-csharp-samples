namespace NameSorter
{
    partial class FormNameSorter
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSortedNames = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnClearNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(15, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSortedNames
            // 
            this.txtSortedNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSortedNames.Location = new System.Drawing.Point(15, 82);
            this.txtSortedNames.Multiline = true;
            this.txtSortedNames.Name = "txtSortedNames";
            this.txtSortedNames.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSortedNames.Size = new System.Drawing.Size(163, 114);
            this.txtSortedNames.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a &name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Sorted names:";
            // 
            // btnAddName
            // 
            this.btnAddName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddName.Location = new System.Drawing.Point(187, 22);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 4;
            this.btnAddName.Text = "&Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnClearNames
            // 
            this.btnClearNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearNames.Location = new System.Drawing.Point(187, 82);
            this.btnClearNames.Name = "btnClearNames";
            this.btnClearNames.Size = new System.Drawing.Size(75, 23);
            this.btnClearNames.TabIndex = 5;
            this.btnClearNames.Text = "&Clear";
            this.btnClearNames.UseVisualStyleBackColor = true;
            this.btnClearNames.Click += new System.EventHandler(this.btnClearNames_Click);
            // 
            // FormNameSorter
            // 
            this.AcceptButton = this.btnAddName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 208);
            this.Controls.Add(this.btnClearNames);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSortedNames);
            this.Controls.Add(this.txtName);
            this.Name = "FormNameSorter";
            this.Text = "Name Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSortedNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnClearNames;
    }
}

