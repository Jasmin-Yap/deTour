using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Class
{
    class BackgroundColor
    {
        private static string Chosen = "";

        public static string chosenColor
        {
            get { return Chosen; }
            set { Chosen = value; }
        }
    }
}
