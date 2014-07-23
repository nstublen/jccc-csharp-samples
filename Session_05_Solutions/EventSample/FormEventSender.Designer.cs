namespace JCCC.Samples.EventSample
{
    partial class FormEventSender
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnLose = new System.Windows.Forms.Button();
            this.btnWin = new System.Windows.Forms.Button();
            this.btnListener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 99);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(12, 70);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnLose
            // 
            this.btnLose.Location = new System.Drawing.Point(12, 41);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(75, 23);
            this.btnLose.TabIndex = 13;
            this.btnLose.Text = "Lose";
            this.btnLose.UseVisualStyleBackColor = true;
            this.btnLose.Click += new System.EventHandler(this.btnLose_Click);
            // 
            // btnWin
            // 
            this.btnWin.Location = new System.Drawing.Point(12, 12);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(75, 23);
            this.btnWin.TabIndex = 12;
            this.btnWin.Text = "Win";
            this.btnWin.UseVisualStyleBackColor = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // btnListener
            // 
            this.btnListener.Location = new System.Drawing.Point(126, 12);
            this.btnListener.Name = "btnListener";
            this.btnListener.Size = new System.Drawing.Size(75, 23);
            this.btnListener.TabIndex = 20;
            this.btnListener.Text = "Listener...";
            this.btnListener.UseVisualStyleBackColor = true;
            this.btnListener.Click += new System.EventHandler(this.btnListener_Click);
            // 
            // FormEventSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 135);
            this.Controls.Add(this.btnListener);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnLose);
            this.Controls.Add(this.btnWin);
            this.Name = "FormEventSender";
            this.Text = "My Sports Team";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.Button btnWin;
        private System.Windows.Forms.Button btnListener;
    }
}

