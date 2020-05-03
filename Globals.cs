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

        public static Customer CurrentCust { get; set; }
        public static Appointment CurrentAppt { get; set; }

    }
}
