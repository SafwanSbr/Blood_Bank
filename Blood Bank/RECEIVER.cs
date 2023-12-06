using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
    public class RECEIVER : User
    {
        private string noBag;
        public string NoBag
        {
            get { return noBag; }
            set { noBag = value; }
        }
        public RECEIVER() : base()
        {

        }
        public RECEIVER(string name, string phone, string address, string bg, string noBag) : base(name, phone, bg, address)
        {
            this.noBag = noBag;
        }
        public override bool search()
        {
            throw new NotImplementedException();
        }
    }
}
