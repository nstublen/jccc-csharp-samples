namespace PhoneFormatter
{
    partial class FormPhoneFormatter
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFormattedNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a phone &number:";
            // 
            // lblFormattedNumber
            // 
            this.lblFormattedNumber.AutoSize = true;
            this.lblFormattedNumber.Location = new System.Drawing.Point(12, 72);
            this.lblFormattedNumber.Name = "lblFormattedNumber";
            this.lblFormattedNumber.Size = new System.Drawing.Size(69, 13);
            this.lblFormattedNumber.TabIndex = 1;
            this.lblFormattedNumber.Text = "(xxx) xxx-xxxx";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 25);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(148, 20);
            this.txtPhoneNumber.TabIndex = 2;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // FormPhoneFormatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 112);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblFormattedNumber);
            this.Controls.Add(this.label1);
            this.Name = "FormPhoneFormatter";
            this.Text = "Phone Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFormattedNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}

