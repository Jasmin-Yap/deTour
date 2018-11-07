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
    class TourCollection
    {
        private static List<Tour> tours;
        private static List<Array> bookingInfo;

        public static List<Tour> GetTour(string cmd)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            tours = new List<Tour>();
                            DataTable table = DBTour.GetDataTable(cmd);
                            foreach (DataRow dr in table.Rows)
                            {
                                Tour data = new Tour();
                                data.TID = dr["TourID"].ToString();
                                data.Name = dr["TourName"].ToString();
                                data.State = dr["TourState"].ToString();
                                data.Country = dr["Country"].ToString();
                                data.Region = dr["Region"].ToString();
                                data.Summary = dr["Summary"].ToString();
                                data.Itinerary = dr["Itinerary"].ToString();
                                data.Price = dr["Price"].ToString();
                                data.StartDate = Convert.ToDateTime(dr["StartDate"]);
                                data.EndDate = Convert.ToDateTime(dr["EndDate"]);
                                data.Duration = dr["Duration"].ToString();
                                if (DBNull.Value.Equals(dr["Quantity"]))
                                    data.TQuantity = "0";
                                else data.TQuantity = dr["Quantity"].ToString();
                                tours.Add(data);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                        return tours;
                    }
                }
            }
        }

        public static List<Tour> GetCart(string cmd)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            tours = new List<Tour>();
                            DataTable table = DBTour.GetDataTable(cmd);
                            foreach (DataRow dr in table.Rows)
                            {
                                Tour data = new Tour();
                                data.TID = dr["TourID"].ToString();
                                data.Name = dr["TourName"].ToString();
                                data.State = dr["TourState"].ToString();
                                data.Country = dr["Country"].ToString();
                                data.Region = dr["Region"].ToString();
                                data.Summary = dr["Summary"].ToString();
                                data.Itinerary = dr["Itinerary"].ToString();
                                data.Price = dr["Price"].ToString();
                                data.StartDate = Convert.ToDateTime(dr["StartDate"]);
                                data.EndDate = Convert.ToDateTime(dr["EndDate"].ToString());
                                data.Duration = dr["Duration"].ToString();
                                data.TQuantity = dr["Quantity"].ToString();
                                data.HotelStars = dr["HotelStars"].ToString();
                                tours.Add(data);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                        return tours;
                    }
                }
            }
        }

        public static void DeletedRow(string tourName)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        comm.CommandText = "DELETE FROM Cart WHERE TourID = @TN";
                        comm.Parameters.AddWithValue("@TN", getTourID(tourName));
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        public static void UpdateRow(string tourName)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        comm.CommandText = "UPDATE Cart Set HotelStars = @s, Price = @p, Quantity = @q WHERE TourID = @TN";
                        comm.Parameters.AddWithValue("@s", TourChoice.starsChosen);
                        comm.Parameters.AddWithValue("@p", TourChoice.calcTotal(getBasePrice(tourName)));
                        comm.Parameters.AddWithValue("@q", TourChoice.QuantityChosen);
                        comm.Parameters.AddWithValue("@TN", getTourID(tourName));
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        public static void InsertBK(string[] tourName, string[] pricePaid, string[] quantity, string cardNo, string[] stars)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        
                        for (int i = 0; i < TourChoice.getIndex; i++)
                        {
                            comm.CommandText = "INSERT INTO Booking" +
                            " (UserName, TransactionTime, CardNo, TourID, HotelStars, PricePaid, Quantity)" +
                            " VALUES ('" + TourChoice.UnameVar + "', '" + DateTime.Now + "', " + cardNo + ", '" + getTourID(tourName[i]) + "', " + stars[i] + ", " + pricePaid[i] + ", " + quantity[i] + ")";
                            UpdateTour(tourName[i], quantity[i]);
                        }
                        DeleteCart();
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        public static void DeleteCart()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        comm.CommandText = "DELETE FROM Cart where UserName = '" + TourChoice.UnameVar + "'";
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        public static void UpdateTour(string tourName, string quantity)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        if ((Convert.ToInt32(getQuantity(tourName)) - Convert.ToInt32(quantity)) == 0)
                            quantity = "NULL";
                        else quantity = (Convert.ToInt32(getQuantity(tourName)) - Convert.ToInt32(quantity)).ToString();
                        comm.CommandText = "UPDATE Tour Set Quantity = " + quantity + " Where TourID = '" + getTourID(tourName) + "'";
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        public static void InsertCart(string tourName, string price, string qty, string stars)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        comm.CommandText = "INSERT INTO Cart" +
                            " (UserName, TourID, HotelStars, Price, Quantity)" +
                            " VALUES ('" + TourChoice.UnameVar + "', '" + getTourID(tourName) + "', " + stars + ", " + price + ", " + qty + ")";
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

        public static void ToWishlist(string tourName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                    "database=APPD_CA2;" +
                                                    "integrated security=true";
                            conn.Open();
                            comm.Connection = conn;
                            comm.CommandText = "INSERT INTO Wishlist" +
                                " VALUES ('" + TourChoice.UnameVar + "', '" + getTourID(tourName) + "')";
                            comm.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("You have already added this tour to wishlist");
            }
        }

        public static string getTourID(string tourName)
        {
            if (tourName.Contains("JB"))
                tourName = "JB''s Local Delights 4D3N";
            if (tourName.Contains("Malaysia's"))
                tourName = "Malaysia''s Hottest 7D6N";
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        DataTable TID = DBTour.GetDataTable("Select TourID from Tour where TourName = '" + tourName + "'");
                        conn.Close();
                        string ID = TID.Rows[0][0].ToString();
                        return ID;

                    }
                }
            }
        }

        public static string getBasePrice(string tourName)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        if (tourName.Contains("JB"))
                            tourName = "JB''s Local Delights 4D3N";
                        if (tourName.Contains("Malaysia's"))
                            tourName = "Malaysia''s Hottest 7D6N";
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        DataTable TP = DBTour.GetDataTable("Select Price from Tour where TourName = '" + tourName + "'");
                        conn.Close();
                        string P = TP.Rows[0][0].ToString();
                        return P;

                    }
                }
            }
        }

        public static string getQuantity(string tourName)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        if (tourName.Contains("JB"))
                            tourName = "JB''s Local Delights 4D3N";
                        if (tourName.Contains("Malaysia's"))
                            tourName = "Malaysia''s Hottest 7D6N";
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database=APPD_CA2;" +
                                                "integrated security=true";
                        conn.Open();
                        comm.Connection = conn;
                        DataTable Tq = DBTour.GetDataTable("Select Quantity from Tour where TourName = '" + tourName + "'");
                        conn.Close();
                        string q = Tq.Rows[0][0].ToString();
                        return q;

                    }
                }
            }
        }

        public static List<Tour> Refined()
        {
            if (TourChoice.RegionCheck)
            {
                if (TourChoice.DateCheck && TourChoice.DurationCheck)
                {
                    tours = GetTour("SELECT * FROM Tour WHERE Region = '" + TourChoice.Region + "' AND StartDate >= '" + TourChoice.Date + "' AND Duration = '" + TourChoice.Duration + "'");
                }
                else if (TourChoice.DateCheck)
                {
                    tours = GetTour("SELECT * FROM Tour WHERE Region = '" + TourChoice.Region + "' AND StartDate >= '" + TourChoice.Date + "'");
                }
                else if (TourChoice.DurationCheck)
                {
                    tours = GetTour("SELECT * FROM Tour WHERE Region = '" + TourChoice.Region + "' AND Duration = '" + TourChoice.Duration + "'");
                }
                else
                {
                    tours = GetTour("SELECT * FROM Tour WHERE Region = '" + TourChoice.Region + "'");
                }
            }
            else if (TourChoice.CountryCheck)
            {
                if (TourChoice.DateCheck && TourChoice.DurationCheck)
                {
                    tours = GetTour("SELECT * FROM Tour WHERE Country = '" + TourChoice.Country + "' AND StartDate >= '" + TourChoice.Date + "' AND Duration = '" + TourChoice.Duration + "'");
                }
                else if (TourChoice.DateCheck)
                {
                    tours = GetTour("SELECT * FROM Tour WHERE Country = '" + TourChoice.Country + "' AND StartDate >= '" + TourChoice.Date + "'");
                }
                else if (TourChoice.DurationCheck)
                {
                    tours = GetTour("SELECT * FROM Tour WHERE Country = '" + TourChoice.Country + "' AND Duration = '" + TourChoice.Duration + "'");
                }
                else
                {
                    tours = GetTour("SELECT * FROM Tour WHERE Country = '" + TourChoice.Country + "' AND Region = '" + TourChoice.Region + "'");
                }
            }
            else if (TourChoice.DateCheck)
            {
                tours = GetTour("SELECT * FROM Tour WHERE StartDate >= '" + TourChoice.Date + "'");
            }
            else if (TourChoice.DurationCheck)
            {
                tours = GetTour("SELECT * FROM Tour WHERE Duration = '" + TourChoice.Duration + "'");
            }
            else
            {
                tours = GetTour("SELECT * FROM Tour");
            }
            return tours;
        }
        
        public static List<Array> getBookings()
        {
            DataTable B = new DataTable();
            B = DBTour.GetDataTable("select t.TourName, b.PricePaid, b.HotelStars, b.Quantity" +
                                    " from Tour t, Booking b" +
                                    " where b.UserName = '" + TourChoice.UnameVar + "' AND transactiontime =  Convert(varchar, GETDATE(),103) and t.tourID = b.tourID");
            bookingInfo = new List<Array>();
            foreach (DataRow dr in B.Rows)
            {
                string[] info = new string[] { dr["tourName"].ToString(), "$" + dr["PricePaid"].ToString(), "Hotel Stars: " + dr["HotelStars"].ToString(), "Quantity: " + dr["Quantity"].ToString() };
                bookingInfo.Add(info);
            }
            return bookingInfo;
        }

    }
}
