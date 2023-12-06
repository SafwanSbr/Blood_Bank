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
    public partial class RECEIVER_SignUp : Form
    {
        public RECEIVER_SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            RECEIVER receiver = new RECEIVER(txtName.Text, txtPhone.Text, txtAddress.Text, txtBG.Text, txtBag.Text);
            
            bool b = sql.insertRECEIVER(receiver);
            if( b)
            {
                MessageBox.Show(" Account Created Successfully!");
                this.Hide();
                new RECEIVER_SignIn().Show();
            }
        }
    }
}
