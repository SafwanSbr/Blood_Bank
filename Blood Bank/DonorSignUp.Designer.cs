namespace Blood_Bank
{
    partial class DonorSignUp
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBG = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBloodG = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 26);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(212, 257);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(274, 26);
            this.txtPhone.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(212, 109);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(274, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // txtBG
            // 
            this.txtBG.Location = new System.Drawing.Point(212, 185);
            this.txtBG.Name = "txtBG";
            this.txtBG.Size = new System.Drawing.Size(274, 26);
            this.txtBG.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Red;
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(107, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Red;
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhone.Location = new System.Drawing.Point(107, 257);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Red;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddress.Location = new System.Drawing.Point(107, 112);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblBloodG
            // 
            this.lblBloodG.AutoSize = true;
            this.lblBloodG.BackColor = System.Drawing.Color.Red;
            this.lblBloodG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBloodG.Location = new System.Drawing.Point(107, 185);
            this.lblBloodG.Name = "lblBloodG";
            this.lblBloodG.Size = new System.Drawing.Size(99, 20);
            this.lblBloodG.TabIndex = 7;
            this.lblBloodG.Text = "Blood Group";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(378, 397);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(108, 50);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(212, 327);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(272, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Red;
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(107, 327);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // DonorSignUp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blood_Bank.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(675, 494);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblBloodG);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBG);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Name = "DonorSignUp";
            this.Text = "Donor Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBG;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBloodG;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}