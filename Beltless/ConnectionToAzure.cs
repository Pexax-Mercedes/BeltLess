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
        public static void ConnectAzure(ListBox lb)
        {
            string Result = "";

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
                    sb.Append("*FROM Person ");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               Result =  reader[1].ToString();
                                lb.Items.Add(Result);
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
