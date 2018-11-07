using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Tour
    {
        private string tourID, tourName, tourState, tourCountry, tourRegion, tourSummary, tourItinerary, tourPrice,  tourDuration, Quantity, Hotel;
        private DateTime startDate, endDate;

        public Tour()
        {
        }

        public Tour(string tourID, string tourName, string tourState, string tourCountry, string tourRegion, string tourSummary, string tourItinerary,
            string tourPrice, DateTime startDate, DateTime endDate, string tourDuration, string Quantity, string Hotel)
        {
            this.tourID = tourID;
            this.tourName = tourName;
            this.tourState = tourState;
            this.tourCountry = tourCountry;
            this.tourRegion = tourRegion;
            this.tourSummary = tourSummary;
            this.tourItinerary = tourItinerary;
            this.tourPrice = tourPrice;
            this.startDate = startDate;
            this.endDate = endDate;
            this.tourDuration = tourDuration;
            this.Quantity = Quantity;
            this.Hotel = Hotel;
        }

        public string TID
        {
            get { return tourID; }
            set { tourID = value; }
        }
        public string Name
        {
            get { return tourName; }
            set { tourName = value; }
        }
        public string State
        {
            get { return tourState; }
            set { tourState = value; }
        }
        public string Country
        {
            get { return tourCountry; }
            set { tourCountry = value; }
        }
        public string Region
        {
            get { return tourRegion; }
            set { tourRegion = value; }
        }
        public string Summary
        {
            get { return tourSummary; }
            set { tourSummary = value; }
        }
        public string Itinerary
        {
            get { return tourItinerary; }
            set { tourItinerary = value; }
        }
        public string Price
        {
            get { return tourPrice; }
            set { tourPrice = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string Duration
        {
            get { return tourDuration; }
            set { tourDuration = value; }
        }
        public string TQuantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public string HotelStars
        {
            get { return Hotel; }
            set { Hotel = value; }
        }
    }
}
