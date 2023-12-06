namespace Blood_Bank
{
    partial class RECEIVER_SignUp
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBG = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNeed = new System.Windows.Forms.Label();
            this.lblNoBag = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtBag = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(158, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(154, 109);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 20);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone :";
            // 
            // lblBG
            // 
            this.lblBG.AutoSize = true;
            this.lblBG.Location = new System.Drawing.Point(110, 162);
            this.lblBG.Name = "lblBG";
            this.lblBG.Size = new System.Drawing.Size(107, 20);
            this.lblBG.TabIndex = 2;
            this.lblBG.Text = "Blood Group :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(141, 216);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address :";
            // 
            // lblNeed
            // 
            this.lblNeed.AutoSize = true;
            this.lblNeed.Location = new System.Drawing.Point(71, 278);
            this.lblNeed.Name = "lblNeed";
            this.lblNeed.Size = new System.Drawing.Size(146, 20);
            this.lblNeed.TabIndex = 4;
            this.lblNeed.Text = "Must needed Until :";
            // 
            // lblNoBag
            // 
            this.lblNoBag.AutoSize = true;
            this.lblNoBag.Location = new System.Drawing.Point(89, 332);
            this.lblNoBag.Name = "lblNoBag";
            this.lblNoBag.Size = new System.Drawing.Size(128, 20);
            this.lblNoBag.TabIndex = 5;
            this.lblNoBag.Text = "No of bag Need :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(223, 109);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(276, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(223, 213);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(276, 26);
            this.txtAddress.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(223, 272);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(276, 26);
            this.txtDate.TabIndex = 10;
            // 
            // txtBag
            // 
            this.txtBag.Location = new System.Drawing.Point(223, 329);
            this.txtBag.Name = "txtBag";
            this.txtBag.Size = new System.Drawing.Size(276, 26);
            this.txtBag.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBG
            // 
            this.txtBG.Location = new System.Drawing.Point(229, 163);
            this.txtBG.Name = "txtBG";
            this.txtBG.Size = new System.Drawing.Size(278, 26);
            this.txtBG.TabIndex = 15;
            // 
            // RECEIVER_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blood_Bank.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(638, 529);
            this.Controls.Add(this.txtBG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBag);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNoBag);
            this.Controls.Add(this.lblNeed);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBG);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Name = "RECEIVER_SignUp";
            this.Text = "RECEIVER_SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBG;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNeed;
        private System.Windows.Forms.Label lblNoBag;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtBag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBG;
    }
}