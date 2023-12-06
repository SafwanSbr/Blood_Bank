namespace Blood_Bank
{
    partial class BloodBank
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
            this.btnDonor = new System.Windows.Forms.Button();
            this.btnReceiver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDonor
            // 
            this.btnDonor.Location = new System.Drawing.Point(97, 256);
            this.btnDonor.Name = "btnDonor";
            this.btnDonor.Size = new System.Drawing.Size(160, 67);
            this.btnDonor.TabIndex = 0;
            this.btnDonor.Text = "DONOR";
            this.btnDonor.UseVisualStyleBackColor = true;
            this.btnDonor.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // btnReceiver
            // 
            this.btnReceiver.Location = new System.Drawing.Point(510, 256);
            this.btnReceiver.Name = "btnReceiver";
            this.btnReceiver.Size = new System.Drawing.Size(131, 67);
            this.btnReceiver.TabIndex = 1;
            this.btnReceiver.Text = "RECEIVER";
            this.btnReceiver.UseVisualStyleBackColor = true;
            this.btnReceiver.Click += new System.EventHandler(this.btnReceiver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO BLOOD BANK";
            // 
            // BloodBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::Blood_Bank.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(755, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReceiver);
            this.Controls.Add(this.btnDonor);
            this.Name = "BloodBank";
            this.Text = "Blood Bank";
            this.Load += new System.EventHandler(this.BloodBank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDonor;
        private System.Windows.Forms.Button btnReceiver;
        private System.Windows.Forms.Label label1;
    }
}

