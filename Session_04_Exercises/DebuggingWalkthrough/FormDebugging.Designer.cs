namespace DebuggingWalkthrough
{
    partial class FormDebugging
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.btnThrow = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(12, 12);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Location = new System.Drawing.Point(12, 64);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(75, 23);
            this.btnThrow.TabIndex = 1;
            this.btnThrow.Text = "Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(12, 118);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // FormDebugging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnClickMe);
            this.Name = "FormDebugging";
            this.Text = "Debugging";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Button btnDivide;
    }
}

