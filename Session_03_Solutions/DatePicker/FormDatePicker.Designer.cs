namespace DatePicker
{
    partial class FormDatePicker
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
            this.lblYears = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of years:";
            // 
            // lblYears
            // 
            this.lblYears.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblYears.Location = new System.Drawing.Point(159, 53);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(49, 13);
            this.lblYears.TabIndex = 1;
            this.lblYears.Text = "0";
            this.lblYears.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of days:";
            // 
            // lblDays
            // 
            this.lblDays.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDays.Location = new System.Drawing.Point(159, 80);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(49, 13);
            this.lblDays.TabIndex = 3;
            this.lblDays.Text = "0";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FormDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 111);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.label1);
            this.Name = "FormDatePicker";
            this.Text = "Date Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

