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
    class DBTour
    {
        public static DataTable GetDataTable(string cmd)
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
                        comm.CommandText = cmd;
                        da.SelectCommand = comm;
                        DataTable table = new DataTable();
                        try
                        {
                            conn.Open();
                            da.Fill(table);
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
    }
}
