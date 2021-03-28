using System;
using MySql.Data.MySqlClient;
// ReSharper disable All

namespace test
{
    public class Database
    {
        public static void Call()
        {
            const string connStr = "server=localhost;user=root;database=temp;port=3306;password=''";
            using var conn = new MySqlConnection(connStr);
            conn.Open();
            try
            {
                string sql = "SELECT * FROM movie";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]+" - "+rdr[1] + " - " + rdr[2]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
        }   
    }
}