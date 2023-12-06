namespace Blood_Bank
{
    partial class DonorSignIn
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
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.lblAcc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(214, 78);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(258, 26);
            this.txtPhoneNo.TabIndex = 0;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.txtPhoneNo_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(258, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(390, 210);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(82, 39);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(111, 81);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(87, 20);
            this.lblPhoneNo.TabIndex = 3;
            this.lblPhoneNo.Text = "Phone No :";
            this.lblPhoneNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(111, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password : ";
            this.lblPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Location = new System.Drawing.Point(406, 309);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(66, 20);
            this.linkSignUp.TabIndex = 5;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Sign Up";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(260, 309);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(140, 20);
            this.lblAcc.TabIndex = 6;
            this.lblAcc.Text = "Create an account";
            this.lblAcc.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // DonorSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(804, 480);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhoneNo);
            this.Name = "DonorSignIn";
            this.Text = "DONOR Sign In";
            this.Load += new System.EventHandler(this.DonorSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.Label lblAcc;
    }
}