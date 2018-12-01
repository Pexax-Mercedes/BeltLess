using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Beltless
{
    class ConnectionToAzure
    {
       public static string  ConnectAzure()
        {
            string result = "";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "pexax.database.windows.net";
            builder.UserID = "pexax";
            builder.Password = "Xelyun12_";
            builder.InitialCatalog = "Beltlessx";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                string sql = "Select * from Person";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = reader[1].ToString();
                             
                        }
                    }
                }
                
            }
            return result;

        }
    }
}
