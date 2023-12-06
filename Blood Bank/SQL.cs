using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    internal class SQL
    {
        SqlConnection connection = new SqlConnection(@"Data Source=NIGHT-FURY\SQLEXPRESS;Initial Catalog=NIGHT-FURY;Integrated Security=True");

        public bool verify(string username, string password)
        {
            connection.Open();
            
            string command = "select* from RECEIVER_DATA Where NAME = '" + username + "' and PHONE = '" + password + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bool isVerified = false;
            if (dataTable.Rows.Count > 0) isVerified = true;
            command = "select* from DONOR_DATA Where PHONE = '" + username + "' and PASSWORD = '" + password + "'";
            SqlDataAdapter adapter2 = new SqlDataAdapter(command, connection);
            DataTable dataTable2 = new DataTable();
            try
            {
                adapter2.Fill(dataTable2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            if (dataTable2.Rows.Count > 0) isVerified = true;
            return isVerified;

        }

        public bool insertDONOR(DONOR donor)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into DONOR_DATA(NAME, PHONE, BLOOD_GROUP, ADDRESS, PASSWORD) values('" + donor.Name + "','" + donor.Phone + "','" + donor.bg + "','" + donor.Address + "','" + donor.Password + "')", connection);
            int count = 0;
            try
            {
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            if (count > 0) { return true; }
            else { return false; }
        }
        public bool removeDONOR(string phone)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete from DONOR_DATA where PHONE = '" + phone + "'", connection);
            int count = 0;
            try
            {
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            if (count > 0) { return true; }
            else { return false; }
        }

        public bool insertRECEIVER(RECEIVER receiver)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into RECEIVER_DATA(NAME, PHONE, BLOOD_GROUP, ADDRESS, NO_BAG) values('" + receiver.Name + "','" + receiver.Phone + "','" + receiver.bg + "','" + receiver.Address + "','" + receiver.NoBag + "')", connection);
            int count = 0;
            try
            {
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            if (count > 0) { return true; }
            else { return false; }
        }
    }
}
