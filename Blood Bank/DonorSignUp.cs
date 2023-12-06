using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class DonorSignUp : Form
    {
        public DonorSignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
         DONOR donor = new DONOR(txtName.Text, txtPhone.Text, txtBG.Text, txtAddress.Text, txtPassword.Text);
            SQL sql = new SQL();
            bool b = sql.insertDONOR(donor);
            if (b)
            {
                MessageBox.Show("Account created Successfully!");
                this.Hide();
                new DonorSignIn().Show();
            }
            else
            {
                MessageBox.Show("Account Creation Failed! Please try Again");
                this.Hide();
                new DonorSignUp().Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
