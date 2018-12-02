using Beltless.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beltless
{
    class Persons
    {
        List<Person> person_List = new List<Person>();
        List<Cars> Cars_List = new List<Cars>();
        List<Seat_Sensors> SeatSensor_List = new List<Seat_Sensors>();
        List<Crush_Positions> CrushPosition_List = new List<Crush_Positions>();
        List<Situations> Situations_List = new List<Situations>();


        public void Call_MyModel()
        {
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
                    sb.Append(string.Format("*FROM Person"));
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                person_List.Add(new Person(Convert.ToInt16(reader[0].ToString()), reader[1].ToString(), Convert.ToByte(reader[2].ToString()), float.Parse(reader[3].ToString())));
                            }
                        }
                    }
                }


                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT");
                    sb.Append(string.Format("*FROM Cars"));
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cars_List.Add(new Cars(Convert.ToInt32(reader[0].ToString()), reader[1].ToString()));
                            }
                        }
                    }
                }



                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT");
                    sb.Append(string.Format("*FROM Seat_Sensors"));
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string adb1 = reader[0].ToString();
                                string adb2 = reader[1].ToString();
                                string adb3 = reader[2].ToString();
                                string adb4 = reader[3].ToString();
                                string adb5 = reader[4].ToString();
                                string adb6 = reader[5].ToString();
                                SeatSensor_List.Add(new Seat_Sensors(Convert.ToByte(reader[0].ToString()),Convert.ToByte(reader[1].ToString()), Convert.ToByte(reader[2].ToString()), Convert.ToByte(reader[3].ToString()), Convert.ToInt32(reader[4].ToString()), Convert.ToInt32(reader[5].ToString())));
                            }
                        }
                    }
                }



                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT");
                    sb.Append(string.Format("*FROM Seat_Sensors"));
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SeatSensor_List.Add(new Seat_Sensors(Convert.ToByte(reader[0].ToString()), Convert.ToByte(reader[1].ToString()), Convert.ToByte(reader[2].ToString()), Convert.ToByte(reader[3].ToString()), Convert.ToInt32(reader[4].ToString()), Convert.ToInt32(reader[5].ToString())));
                            }
                        }
                    }
                }




                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT");
                    sb.Append(string.Format("*FROM Crush_Positions"));
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CrushPosition_List.Add(new Crush_Positions(Convert.ToBoolean(reader[0].ToString()), Convert.ToBoolean(reader[1].ToString()), Convert.ToBoolean(reader[2].ToString()), Convert.ToBoolean(reader[3].ToString()), Convert.ToBoolean(reader[4].ToString()), Convert.ToBoolean(reader[5].ToString()), Convert.ToInt32(reader[6].ToString())));
                            }
                        }
                    }
                }


                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT");
                    sb.Append(string.Format("*FROM Situations"));
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Situations_List.Add(new Situations(Convert.ToInt32(reader[0].ToString()), Convert.ToBoolean(reader[1].ToString()), Convert.ToInt32(reader[2].ToString())));
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

        //public void Call_Cars()
        //{
        //    try
        //    {

        //        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        //        builder.DataSource = "pexax.database.windows.net";
        //        builder.UserID = "pexax";
        //        builder.Password = "Xelyun12_";
        //        builder.InitialCatalog = "Beltlessx";

                
        //    }
        //    catch (SqlException e)
        //    {
        //        Console.WriteLine(e.ToString());
        //    }
        //}

    }
}
