using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltless
{
    class Conected
    {
        public static int[] ConnectAzure()
        {
            List<int> list = new List<int>();
            string result = "";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "pexax.database.windows.net";
            builder.UserID = "pexax";
            builder.Password = "Xelyun12_";
            builder.InitialCatalog = "Beltlessx";
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                string sql = "select Speed from Situations";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Convert.ToInt32(reader[0]));
                        }
                    }
                }

            }
            
            int[] array = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }
}
