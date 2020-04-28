using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApplication
{
    public class Appointment
    {
        public int ApptID { get; set; }
        public int CustID { get; set; }
        public int UserID { get; set; }
        public string ApptType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate {get; set;}
        public string LastUpdateBy { get; set; }


        public Appointment(int apptID, int custID, int userID, string apptType, DateTime startTime, DateTime endTime, 
            DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            ApptID = apptID;
            CustID = custID;
            UserID = userID;
            ApptType = apptType;
            StartTime = startTime;
            EndTime = endTime;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;

        }
    }
}
