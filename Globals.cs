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

        public static string CustCombo { get; set; }
        public static int ApptId { get; set; }

        public static int CustComboID { get; set; }

        public static int UserID = 1;

        public static string CurrUserName = "test";

        public static string ApptTypeCombo { get; set; }

        public static int CtryID { get; set; }
        public static int CtyID { get; set; }
        public static int AddID { get;set; }


    }
}
