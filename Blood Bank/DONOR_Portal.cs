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
    public partial class DONOR_Portal : Form
    {
        private DONOR donor;
        public DONOR_Portal(DONOR donor)
        {
            InitializeComponent();
            this.donor = donor;
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            sql.removeDONOR(donor.Phone);
            this.Hide();
            new DonorSignIn().Show();
        }

        private void DONOR_Portal_Load(object sender, EventArgs e)
        {

        }
    }
}
