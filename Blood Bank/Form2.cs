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
    public partial class DonorSignIn : Form
    {
        public DonorSignIn()
        {
            InitializeComponent();
        }

        private void DonorSignIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new DonorSignUp().Show();
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SQL sql1 = new SQL();
            bool b = sql1.verify(txtPhoneNo.Text, txtPassword.Text);
            if( b)
            {
                DONOR donor = new DONOR();
                donor.Phone = txtPhoneNo.Text;
                donor.Password = txtPassword.Text;

                this.Hide();
                new DONOR_Portal(donor).Show();
            }
            else
            {
                MessageBox.Show("Invalid User and Password. Please try again!");
            }
        }
    }
}
