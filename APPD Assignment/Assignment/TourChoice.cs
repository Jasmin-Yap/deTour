using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class TourChoice
    { 
        private static string chosen, price, duration, Uname, Upass, selectedRegion, selectedCountry, selectedDate, selectedDuration;
        private static int hotelStars, ItemNo, Quantity, index, stars;
        private static bool RegionRB, dateCB, durationCB, CountryRB;
        private static double TotalCost;

        public static double Cost
        {
            get { return TotalCost; }
            set { TotalCost = value; }
        }
        public static int getIndex
        {
            get { return index; }
            set { index = value; }
        }
        public static string tourChosen
        {
            get { return chosen; }
            set { chosen = value; }
        }

        public static string tourPrice
        {
            get { return price; }
            set { price = value; }
        }

        public static string tourDuration
        {
            get { return duration; }
            set { duration = value; }
        }

        public static int tourHotelStars
        {
            get { return hotelStars; }
            set { hotelStars = value; }
        }

        public static int QuantityChosen
        {
            get { return Quantity; }
            set { Quantity = value; }
        }

        public static string UnameVar
        {
            get { return Uname; }
            set { Uname = value; }
        }
        public static string UpassVar
        {
            get { return Upass; }
            set { Upass = value; }
        }
        public static int ItemVar
        {
            get { return ItemNo; }
            set { ItemNo = value; }
        }
        public static string Country
        {
            get { return selectedCountry; }
            set { selectedCountry = value; }
        }

        public static string Date
        {
            get { return selectedDate; }
            set { selectedDate = value; }
        }

        public static string Duration
        {
            get { return selectedDuration; }
            set { selectedDuration = value; }
        }

        public static string Region
        {
            get { return selectedRegion; }
            set { selectedRegion = value; }
        }

        public static bool RegionCheck
        {
            get { return RegionRB; }
            set { RegionRB = value; }
        }

        public static bool DateCheck
        {
            get { return dateCB; }
            set { dateCB = value; }
        }

        public static bool DurationCheck
        {
            get { return durationCB; }
            set { durationCB = value; }
        }

        public static bool CountryCheck
        {
            get { return CountryRB; }
            set { CountryRB = value; }
        }

        public static int starsChosen
        {
            get { return stars; }
            set { stars = value; }
        }

        public static double calcTotal(string x)
        {
            double calculatedPrice = double.Parse(x);

            switch (hotelStars)
            {
                case 1:
                    calculatedPrice += 1000;
                    break;
                case 2:
                    calculatedPrice += 800;
                    break;
                case 3:
                    calculatedPrice += 400;
                    break;
                case 4:
                    calculatedPrice += 200;
                    break;
                case 5:
                    calculatedPrice += 100;
                    break;
                default:
                    calculatedPrice *= 1;
                    break;
            }
            return calculatedPrice;
        }
    }
}
