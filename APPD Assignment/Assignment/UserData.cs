using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Assignment
{
    class UserData
    {
        private static List<User> user = new List<User>();
        private static List<UserPremium> userP = new List<UserPremium>();
        private static List<UserFree> userF = new List<UserFree>();

        public static List<User> getUserInfo(string cmd)
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
                        comm.Connection = conn;
                        comm.CommandText = "Select * from Users" + cmd;
                        da.SelectCommand = comm;
                        DataTable table = new DataTable();
                        try
                        {
                            conn.Open();
                            da.Fill(table);
                            foreach (DataRow dr in table.Rows)
                            {
                                if (dr["AccountType"].Equals("P"))
                                {
                                    UserPremium data = new UserPremium();
                                    data.userAccountType = Convert.ToChar(dr["AccountType"]);
                                    data.userSalution = dr["Salution"].ToString();
                                    data.userName = dr["Name"].ToString();
                                    data.userUsername = dr["UserName"].ToString();
                                    data.userPassword = dr["UserPassword"].ToString();
                                    data.userAddress = dr["UserAddress"].ToString();
                                    data.userZipCd = Convert.ToInt32(dr["ZipCode"]);
                                    data.userPassNo = dr["PassportNo"].ToString();
                                    data.userPassED = Convert.ToDateTime(dr["PassportExpiry"]);
                                    data.userPhoneNo = Convert.ToInt32(dr["PhoneNo"]);
                                    data.userEmail = dr["Email"].ToString();
                                    data.userDiscount = Convert.ToDouble(dr["Discount"]);
                                    user.Add(data);
                                }
                                else
                                {
                                    UserFree data = new UserFree();
                                    data.userAccountType = Convert.ToChar(dr["AccountType"]);
                                    data.userSalution = dr["Salution"].ToString();
                                    data.userName = dr["Name"].ToString();
                                    data.userUsername = dr["UserName"].ToString();
                                    data.userPassword = dr["UserPassword"].ToString();
                                    data.userAddress = dr["UserAddress"].ToString();
                                    data.userZipCd = Convert.ToInt32(dr["ZipCode"]);
                                    data.userPassNo = dr["PassportNo"].ToString();
                                    data.userPassED = Convert.ToDateTime(dr["PassportExpiry"]);
                                    data.userPhoneNo = Convert.ToInt32(dr["PhoneNo"]);
                                    data.userEmail = dr["Email"].ToString();
                                    data.userDiscount = 0;
                                    user.Add(data);
                                }
                            }

                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                        return user;
                    }
                }
            }
        }

        public static DataTable getPaymentInfo()
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
                        comm.Connection = conn;
                        comm.CommandText = "Select * from PaymentPremium where UserName = '" + TourChoice.UnameVar + "'";
                        da.SelectCommand = comm;
                        DataTable table = new DataTable();
                        try
                        {
                            conn.Open();
                            da.Fill(table);
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            conn.Close();
                        }
                        return table;
                    }
                }
            }
        }

        public static void InsertPremiumPayment(string username, string cardno, string cardname, DateTime carded)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    try
                    {
                        conn.ConnectionString = "Data Source = DIT-NB1727526\\SQLEXPRESS;" +
                                                "database = APPD_CA2;" +
                                                "integrated security = true";

                        conn.Open();
                        cmd.Connection = conn;

                        cmd.CommandText = "INSERT INTO PaymentPremium VALUES (@user,@cn,@cna,@ced)";
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@cn", cardno);
                        cmd.Parameters.AddWithValue("@cna", cardname);
                        cmd.Parameters.AddWithValue("@ced", carded.ToShortDateString());
                        cmd.ExecuteNonQuery();
                    } //End of try
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                } //End of using cmd
            } //End of using conn
        }

        public static void UpdateUser(string name, string password, string add, string zp, string passNo, DateTime passED, string ph, string mail)
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
                        comm.CommandText = "UPDATE Users " +
                            "Set UserPassword = @pass, UserAddress = @ad, ZipCode = @zip, PassPortNo = @pNo, PassPortExpiry = @pED, PhoneNo = @pNum, Email = @em WHERE UserName = '" + TourChoice.UnameVar + "'";
                        comm.Parameters.AddWithValue("@pass", password);
                        comm.Parameters.AddWithValue("@ad", add);
                        comm.Parameters.AddWithValue("@pNo", passNo);
                        comm.Parameters.AddWithValue("@pED", passED.ToShortDateString());
                        comm.Parameters.AddWithValue("@zip", zp);
                        comm.Parameters.AddWithValue("@pNum", ph);
                        comm.Parameters.AddWithValue("@em", mail);
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }

            }
        }

        public static void createUser(char accountType, string salution, string name, string username, string password, string address, int zipCd, string passNo, DateTime passED, int phoneNo, string email, double disc)
        {
            string discount;
            if (disc == 0)
                discount = "null";
            else discount = disc.ToString();
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
                        comm.CommandText = "Insert Into Users VALUES (@at, @sal, @n, @user, @pass, @ad, @zip, @pNo, @pED, @pNum, @em, @d)";
                        comm.Parameters.AddWithValue("@at", accountType);
                        comm.Parameters.AddWithValue("@sal", salution);
                        comm.Parameters.AddWithValue("@n", name);
                        comm.Parameters.AddWithValue("@user", username);
                        comm.Parameters.AddWithValue("@pass", password);
                        comm.Parameters.AddWithValue("@ad", address);
                        comm.Parameters.AddWithValue("@pNo", passNo);
                        comm.Parameters.AddWithValue("@pED", passED.ToShortDateString());
                        comm.Parameters.AddWithValue("@zip", zipCd);
                        comm.Parameters.AddWithValue("@pNum", phoneNo);
                        comm.Parameters.AddWithValue("@em", email);
                        comm.Parameters.AddWithValue("@d", disc);
                        comm.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
        }

    }
}


