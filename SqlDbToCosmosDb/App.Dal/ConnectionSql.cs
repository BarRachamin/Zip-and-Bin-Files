using App.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Dal
{
    public class ConnectionSql
    {
        //Connection String
        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=Northwind;Data Source=localhost\\SQLEXPRESS";
            public delegate object SetDataReader_delegate(SqlDataReader reader);
            //Function that returns information from database and send the inforamtion to another function 


            public static object StartReadFromDB(string SqlQuery, SetDataReader_delegate Ptrfunc)
            {
                try
                {
                    object retHash = null;



                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        // Adapter
                        using (SqlCommand command = new SqlCommand(SqlQuery, connection))
                        {
                            connection.Open();
                            //Reader
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                retHash = Ptrfunc(reader);

                            }
                        }
                    }
                    return retHash;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;

                }
            }

        }
    }

