namespace NumberSorter
{
    partial class FormNumberSorter
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
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.txtSortedNumbers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(15, 25);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(165, 20);
            this.txtNumbers.TabIndex = 0;
            // 
            // txtSortedNumbers
            // 
            this.txtSortedNumbers.Location = new System.Drawing.Point(15, 82);
            this.txtSortedNumbers.Multiline = true;
            this.txtSortedNumbers.Name = "txtSortedNumbers";
            this.txtSortedNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSortedNumbers.Size = new System.Drawing.Size(165, 103);
            this.txtSortedNumbers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter &numbers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Sorted numbers:";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(186, 22);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "&Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // FormNumberSorter
            // 
            this.AcceptButton = this.btnSort;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 205);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSortedNumbers);
            this.Controls.Add(this.txtNumbers);
            this.Name = "FormNumberSorter";
            this.Text = "Number Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.TextBox txtSortedNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSort;
    }
}

