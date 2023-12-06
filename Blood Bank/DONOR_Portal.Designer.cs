namespace Blood_Bank
{
    partial class DONOR_Portal
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRequestes = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(277, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(206, 34);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome \"Life Saver\"";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblRequestes
            // 
            this.lblRequestes.AutoSize = true;
            this.lblRequestes.Location = new System.Drawing.Point(334, 218);
            this.lblRequestes.Name = "lblRequestes";
            this.lblRequestes.Size = new System.Drawing.Size(78, 20);
            this.lblRequestes.TabIndex = 1;
            this.lblRequestes.Text = "Requests";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(281, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 68);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE ACCOUNT";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DONOR_Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(792, 559);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblRequestes);
            this.Controls.Add(this.lblWelcome);
            this.Name = "DONOR_Portal";
            this.Text = "DONOR_Portal";
            this.Load += new System.EventHandler(this.DONOR_Portal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRequestes;
        private System.Windows.Forms.Button btnDelete;
    }
}