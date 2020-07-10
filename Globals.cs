using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApplication
{
    static class Globals
    {
        public static int CurrCustIndex { get; set; }
        public static int CurrApptIndex { get; set; }


        public static int CustComboID { get; set; }

        public static int UserID = 1;

        public static string CurrUserName = "test";

        public static string ApptTypeCombo { get; set; }


        public static int SelUser { get; set; }
        public static int CtyID { get; set; }
        public static int AddID { get; set; }
        public static int ApptId { get; set; }
        public static int CustID {get; set;}
        public static DateTime SelDate { get; set; }

        public static string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";





    }
}
