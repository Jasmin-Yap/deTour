using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    class CartPayment
    {
        private static bool payable = false, isBankTransfer = false;
        private static int orderID;
        private static double cartCost;

        public static double ttlCost
        {
            get { return cartCost; }
            set { cartCost = value; }
        }

        public static bool Payable
        {
            get { return payable; }
            set { payable = value; }
        }

        public static bool BankTransfer
        {
            get { return isBankTransfer; }
            set { isBankTransfer = value; }
        }

        public static int OrderNo
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public static string ReceiptItem(string name, string location, string region, string price, string hotelStars, string qty)
        {
            return name + Environment.NewLine + "(" + location + ")" + Environment.NewLine + region + Environment.NewLine + "Price: " +
                price + Environment.NewLine + "Hotel: " + hotelStars + Environment.NewLine + "Quantity: " + qty;
        }

    }
}
