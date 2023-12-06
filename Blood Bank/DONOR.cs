using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
    public class DONOR : User
    {
        private string password;
        public DONOR() : base()
        {

        }
        public DONOR(string name, string phone, string bg, string address, string password) : base(name, phone, bg, address)
        {
            this.password = password;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public override bool search()
        {
            throw new NotImplementedException();
        }
    }
}
