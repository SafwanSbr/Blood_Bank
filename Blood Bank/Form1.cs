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
    public partial class BloodBank : Form
    {
        public BloodBank()
        {
            InitializeComponent();
        }

        private void BloodBank_Load(object sender, EventArgs e)
        {

        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DonorSignIn().Show();
        }

        private void btnReceiver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RECEIVER_SignIn().Show();
        }
    }
}
