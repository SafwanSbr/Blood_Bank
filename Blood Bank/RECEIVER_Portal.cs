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
    public partial class RECEIVER_Portal : Form
    {
        User receiver = new RECEIVER();
        public RECEIVER_Portal(User receiver)
        {
            this.receiver = receiver;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RECEIVER_SignIn().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=NIGHT-FURY\SQLEXPRESS;Initial Catalog=NIGHT-FURY;Integrated Security=True");
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from DONOR_DATA", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
