namespace StatsCalculator
{
    partial class FormCalculator
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(12, 12);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(100, 20);
            this.txtNewValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minimum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maximum:";
            // 
            // lblMaximum
            // 
            this.lblMaximum.Location = new System.Drawing.Point(139, 149);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(54, 13);
            this.lblMaximum.TabIndex = 11;
            this.lblMaximum.Text = "-";
            this.lblMaximum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMinimum
            // 
            this.lblMinimum.Location = new System.Drawing.Point(139, 125);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(54, 13);
            this.lblMinimum.TabIndex = 10;
            this.lblMinimum.Text = "-";
            this.lblMinimum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(139, 101);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(54, 13);
            this.lblAverage.TabIndex = 9;
            this.lblAverage.Text = "-";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(139, 77);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(54, 13);
            this.lblSum.TabIndex = 8;
            this.lblSum.Text = "-";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(139, 53);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(54, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "-";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormCalculator
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 182);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewValue);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblCount;
    }
}

