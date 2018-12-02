using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Beltless
{
    class ConnectionToAzure
    {
        public static void ConnectAzure(ListBox ss)
        {
            /*  string result = "";
              SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
              builder.DataSource = "pexax.database.windows.net";
              builder.UserID = "pexax";
              builder.Password = "Xelyun12_";
              builder.InitialCatalog = "Beltlessx";
              builder.ConnectionString = "Select* from Person";
              SqlConnection connection = new SqlConnection(builder);
                    
              connection.Open();

              SqlCommand command = new SqlCommand();
              SqlDataReader reader = command.ExecuteReader();

              while (reader.Read())
              {
                  result = reader["Name"].ToString();
              }
              reader.Close();
              connection.Close();
              return result; */

            string Result1 = "";
            string Result2 = "";
            string Result3 = "";
            string tablo = "person";
            try
            {
                
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "pexax.database.windows.net";
                builder.UserID = "pexax";
                builder.Password = "Xelyun12_";
                builder.InitialCatalog = "Beltlessx";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT");
                    sb.Append(string.Format("*FROM {0}", tablo));
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Result1 =  reader[1].ToString();
                                Result2 = reader[2].ToString();
                                Result3 = reader[3].ToString();

                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
