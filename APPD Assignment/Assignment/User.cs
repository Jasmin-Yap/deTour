using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class User
    {
        private char accountType;
        private string salution, name, username, password, address, passNo, email;
        private int zipCd, phoneNo;
        private DateTime passED;
        private double discount;

        public User() { }

        public User(char accountType, string salution, string name, string username, string password, string address, int zipCd, string passNo, DateTime passED, int phoneNo, string email, double discount)
        {
            this.accountType = accountType;
            this.salution = salution;
            this.name = name;
            this.username = username;
            this.password = password;
            this.address = address;
            this.zipCd = zipCd;
            this.passNo = passNo;
            this.passED = passED;
            this.phoneNo = phoneNo;
            this.email = email;
            this.discount = discount;
        }

        public char userAccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public string userSalution
        {
            get { return salution; }
            set { salution = value; }
        }

        public string userName
        {
            get { return name; }
            set { name = value; }
        }

        public string userUsername
        {
            get { return username; }
            set { username = value; }
        }

        public string userPassword
        {
            get { return password; }
            set { password = value; }
        }

        public string userAddress
        {
            get { return address; }
            set { address = value; }
        }

        public int userZipCd
        {
            get { return zipCd; }
            set { zipCd = value; }
        }

        public string userPassNo
        {
            get { return passNo; }
            set { passNo = value; }
        }

        public DateTime userPassED
        {
            get { return passED; }
            set { passED = value; }
        }

        public int userPhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        public string userEmail
        {
            get { return email; }
            set { email = value; }
        }

        public double userDiscount
        {
            get { return discount; }
            set { discount = value; }
        }

        public virtual double CartPayable()
        {
            return CartPayment.ttlCost;
        }

    }
}