using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Auth_Token.src
{
    public class Database
    {
        private static MySqlConnection conn;
        private static Database singleton;

        public static Database GetInstance()
        {
            if(singleton == null)
            {
                singleton = new Database();
            }
            return singleton;
        }

        private Database()
        {
            try
            {
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;uid=mihai;" +
                                      "pwd=password;database=learnthecomputer";
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Query(string query)
        {

            try
            {
                var stm = "SELECT * FROM lessons";
                var command = new MySqlCommand(stm, conn);

                using MySqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("{0} {1} {2} ", rdr.GetInt32(0), rdr.GetString(3), rdr.GetString(5));
                }

                rdr.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
