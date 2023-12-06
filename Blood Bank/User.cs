using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
    public  abstract class User
    {
        public User()
        {

        }
        private string name;
        private string phone;
        public string bg;
        private string address;

        public User(string name, string phone, string bg, string address)
        {
            this.name = name;
            this.phone = phone;
            this.bg = bg;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public abstract bool search();
    }
}
