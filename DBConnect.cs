using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchedulingApplication
{
    class DBConnect
    {
        private MySqlConnection connection;

        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString;
            connectionString = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";

            connection = new MySqlConnection(connectionString);
        }


        private static int userID;
        private static string userName;
        public static string dataString = "server=52.206.157.109;database=U05lxQ;uid=U05lxQ;pwd=53688540778; convert zero datetime=True";


        public static string getDataString()
        {
            return dataString;
        }
        public static int getCurrentUserId()
        {
            return userID;
        }

        public static void setCurrentUserId(int currentUserId)
        {
            userID = currentUserId;
        }

        public static string getCurrentUserName()
        {
            return userName;

        }
        public static void setCurrentUserName(string currentUserName)
        {
            userName = currentUserName;
        }
        public static DateTime getDateTime()
        {
            return DateTime.Now.ToUniversalTime();

        }
    }
}
