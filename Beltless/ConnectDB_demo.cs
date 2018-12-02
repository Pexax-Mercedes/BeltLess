using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beltless
{
    class ConnectDB_demo
    {
        public static string name= "";
        public static string weight="";
        public static string speed="";
        public static string carModel="";
        public static string position = "";
        public static void ConnectAzure()
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
                                name = reader[1].ToString();
                                weight = reader[3].ToString();
                            
                            }
                        }
                    }


                    StringBuilder sb2 = new StringBuilder();
                    sb2.Append("SELECT");
                    sb2.Append("*FROM Situations ");
                    String sql2 = sb2.ToString();

                    using (SqlCommand command = new SqlCommand(sql2, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               speed= reader[0].ToString();
                               
                                
                            }
                        }
                    }



                    StringBuilder sb3 = new StringBuilder();
                    sb3.Append("SELECT");
                    sb3.Append("*FROM Cars ");
                    String sql3 = sb3.ToString();

                    using (SqlCommand command = new SqlCommand(sql3, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                carModel = reader[1].ToString();
               
                             
                            }
                        }
                    }

                    StringBuilder sb4 = new StringBuilder();
                    sb4.Append("SELECT");
                    sb4.Append("*FROM Cars ");
                    String sql4 = sb4.ToString();

                    using (SqlCommand command = new SqlCommand(sql4, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                              position= "Sağa";


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
