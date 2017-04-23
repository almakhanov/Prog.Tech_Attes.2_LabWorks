using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Tutorial
{
    public class User
    {
        //database stuff
        const string SERVER = "192.168.137.1";
        const string DATABASE = "tut_db";
        const string UID = "root";
        const string PASSWORD = "";
        static MySqlConnection dbConn;

        public int Id;
        public string Username;
        public string Password;

        public User(int id, string u, string p)
        {
            Id = id;
            Username = u;
            Password = p;
        }

        public static void InitializeDB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = SERVER;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.Database = DATABASE;

            string connString = builder.ToString();

            builder = null;

            Console.WriteLine(connString);

            dbConn = new MySqlConnection(connString);

            Application.ApplicationExit += (sender, args) => {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }



    }
}
