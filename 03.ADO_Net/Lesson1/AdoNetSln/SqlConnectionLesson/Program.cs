using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SqlConnectionLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string connectionString = @"Data Source=.;
                                        Initial Catalog=MyCourseDB;
                                        Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Select * from Students", connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var row = dt.Rows[i];
                        Console.WriteLine("{0,-15} {1}",row["Name"], row["Surname"]);
                    }
                }
                connection.Close();
            }





            //SqlConnection connection = null;
            //try
            //{
            //    connection = new SqlConnection();

            //    connection.Open();


            //    //some code operation

            //    connection.Close();
            //}
            //finally
            //{
            //    if (connection != null)
            //    {
            //        ((IDisposable?)connection).Dispose();
            //    }
            //}

        }
    }
}
