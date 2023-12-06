namespace Blood_Bank
{
    partial class RECEIVER_SignIn
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
            this.lblPleaseLogIn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNeverSUB = new System.Windows.Forms.Label();
            this.llblSignUp = new System.Windows.Forms.LinkLabel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPleaseLogIn
            // 
            this.lblPleaseLogIn.AutoSize = true;
            this.lblPleaseLogIn.Location = new System.Drawing.Point(310, 87);
            this.lblPleaseLogIn.Name = "lblPleaseLogIn";
            this.lblPleaseLogIn.Size = new System.Drawing.Size(59, 20);
            this.lblPleaseLogIn.TabIndex = 1;
            this.lblPleaseLogIn.Text = "Sign In";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(115, 162);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(111, 227);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone :";
            // 
            // lblNeverSUB
            // 
            this.lblNeverSUB.AutoSize = true;
            this.lblNeverSUB.Location = new System.Drawing.Point(200, 359);
            this.lblNeverSUB.Name = "lblNeverSUB";
            this.lblNeverSUB.Size = new System.Drawing.Size(187, 20);
            this.lblNeverSUB.TabIndex = 4;
            this.lblNeverSUB.Text = "Never Signed Up before, ";
            // 
            // llblSignUp
            // 
            this.llblSignUp.AutoSize = true;
            this.llblSignUp.Location = new System.Drawing.Point(380, 359);
            this.llblSignUp.Name = "llblSignUp";
            this.llblSignUp.Size = new System.Drawing.Size(78, 20);
            this.llblSignUp.TabIndex = 5;
            this.llblSignUp.TabStop = true;
            this.llblSignUp.Text = "Click here";
            this.llblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignUp_LinkClicked);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(180, 159);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(180, 227);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(384, 290);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(89, 50);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // RECEIVER_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::Blood_Bank.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(709, 520);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.llblSignUp);
            this.Controls.Add(this.lblNeverSUB);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPleaseLogIn);
            this.Name = "RECEIVER_SignIn";
            this.Text = "RECEIVER_SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseLogIn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNeverSUB;
        private System.Windows.Forms.LinkLabel llblSignUp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSignIn;
    }
}