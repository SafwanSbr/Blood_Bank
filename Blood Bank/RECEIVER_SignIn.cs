using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class RECEIVER_SignIn : Form
    {
        public RECEIVER_SignIn()
        {
            InitializeComponent();
        }

        private void llblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RECEIVER_SignUp().Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SQL sql1 = new SQL();
            bool b = sql1.verify(txtName.Text, txtPhone.Text);
            if( b)
            {
                User receiver = new RECEIVER();
                receiver.Name = txtName.Text;
                receiver.Phone = txtPhone.Text;

                this.Hide();
                new RECEIVER_Portal(receiver).Show();
            }
            else
            {
                MessageBox.Show("Account Not found! Please sign up or give valid Phone no and Name.");
            }
        }
    }
}
