using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace MySQL_CT
{
    public class MySQL
    {
        private static  MySqlConnection mConn;

        public static void Connect(string Hostname, string Username, string Database, string Port = "3306", string Password = "")
        {
            try
            {
                string Query = $"Server={Hostname}; Port={Port}; Database={Database}; Uid={Username}; Pwd= {Password}";
                mConn = new MySqlConnection(Query);

                mConn.Open();

                if (mConn.State == ConnectionState.Open)
                {
                    Log.Write("MySQL connected successfully!");
                }
                else
                {
                    Log.Write("MySQL connected unsuccessfully!");
                }
            }
            catch(Exception ex)
            {
                Log.Write($"MySQL Error: {ex.Message}");
            }
        }
    }
}
