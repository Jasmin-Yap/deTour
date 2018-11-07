using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class UserFree : User
    {
        public UserFree() { }
        public UserFree(char accountType, string salution, string name, string username, string password, string address, int zipCd, string passNo, DateTime passED, int phoneNo, string email, double discount) : base(accountType, salution, name, username, password, address, zipCd, passNo, passED, phoneNo, email, discount)
        {
        }

        public override double CartPayable()
        {
            return CartPayment.ttlCost;
        }
    }
}
