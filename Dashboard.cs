using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication
{
    public partial class Dashboard : Form
    {
        DateTime currentDate = new DateTime();
        public Dashboard()
        {
            InitializeComponent();
            dgvFormatter(DashboardCustDGV);
            dgvFormatter(DashboardApptDGV);
            Check_Appointment();

            //Fill Appointment Table
            DataTable dt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    DashboardApptDGV.DataSource = dt;
                    for (int idx = 0; idx < dt.Rows.Count; idx++)
                    {
                        dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                        dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                    }   
                }
                cn.Close();

            }
            //Fill Customer Table
            DataTable ct = new DataTable();
            string connStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection con = new MySqlConnection(connStrg))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("select customerId, customerName, lastUpdate from customer", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    DashboardCustDGV.DataSource = ct;
                }
                con.Close();

            }
        }
        public void Check_Appointment()
        {
            DateTime Now = DateTime.UtcNow;
            DateTime NowF = DateTime.UtcNow.AddMinutes(15);
            DataTable dp = new DataTable();
            string connSt = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection can = new MySqlConnection(connSt))
            {
                can.Open();
                MySqlCommand acmd = new MySqlCommand("Select * from appointment where userId = '" + Globals.UserID + "' AND start between '" + Now.ToString("yyyy-MM-dd hh:mm:ss") + "' and '" + NowF.ToString("yyyy-MM-dd hh:mm:ss") + "'", can);
                MySqlDataReader areader = acmd.ExecuteReader();
                dp.Load(areader);
                if (dp.Rows.Count > 0)
                {
                    MessageBox.Show("You have an appointment within the next 15 minutes.", "Alert!");
                }
                can.Close();
            }
        }



        public static void dgvFormatter(DataGridView dgvStyle)
        {//DGV PROPERTIES
            dgvStyle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStyle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStyle.MultiSelect = false;
            dgvStyle.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dgvStyle.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dgvStyle.ReadOnly = true;

        }
        private void DBCustLabel_Click(object sender, EventArgs e)
        {

        }

        private void DashboardApptDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Globals.CurrApptIndex = e.RowIndex;
        }

        private void DashboardApptDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /////////////
        }

        private void DashboardCustDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Globals.CurrCustIndex = e.RowIndex;

            DataTable ct = new DataTable();
            string connStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection con = new MySqlConnection(connStrg))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("select * from customer", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    int cxid = (int)ct.Rows[Globals.CurrCustIndex]["customerId"];
                    Globals.CustID = cxid;
                }
                con.Close();

            }



        }

        private void DBExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DBAddApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointmentForm apptform = new AddAppointmentForm();
            apptform.ShowDialog();
        }

        private void DBEAddCustButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerForm custform = new AddCustomerForm();
            custform.ShowDialog();
        }

        private void SelectedDate(object sender, DateRangeEventArgs e)
        {
            currentDate = e.Start;
            if (DashMonthRadioButton.Checked)
            {
                handleMonth();
            }
            else
            {
                if (DashWeekRadioButton.Checked)
                {
                    handleWeek();
                }
                else
                {
                    handleDay();
                }
            }
        }

        private void handleDay()
        {
            monthCalendar1.RemoveAllBoldedDates();
            monthCalendar1.AddBoldedDate(currentDate);
            monthCalendar1.UpdateBoldedDates();
            DataTable day = new DataTable();
            //string dconnStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            //using (MySqlConnection dcn = new MySqlConnection(dconnStr))
            //{
            //    dcn.Open();
            //    MySqlCommand dcmd = new MySqlCommand("SELECT * FROM appointment WHERE start Like '" + currentDate + "';);", dcn);                
            //    MySqlDataReader dreader = dcmd.ExecuteReader();
            //    day.Load(dreader);
            //    if (day.Rows.Count > 0)
            //    {
            //        DashboardApptDGV.DataSource = day;
            //    }
            //    dcn.Close();

            //}

        }
        private void handleWeek()
        {
            monthCalendar1.RemoveAllBoldedDates();
            int dow = (int)currentDate.DayOfWeek;
            string startDate = currentDate.AddDays(-dow).ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            for (int i = 0; i < 7; i++)
            {
                monthCalendar1.AddBoldedDate(tempDate.AddDays(i));
            }
            monthCalendar1.UpdateBoldedDates();
            string endDate = currentDate.AddDays(7 - dow).ToString();
            
            //getData("SELECT * FROM myTbl WHERE DT BETWEEN CDATE('" + startDate + "') AND CDATE('" + endDate + "');");
            //dgv.DataSource = dt;
        }

        private void handleMonth()
        {
           monthCalendar1.RemoveAllBoldedDates();
            int mo = currentDate.Month;
            int yr = currentDate.Year;
            int d = 0;
            string startDate = mo.ToString() + "/01/" + yr.ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            switch (mo)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    d = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;
                default:
                    d = 29;
                    break;
            }
            for (int i = 0; i < d; i++)
            {
                monthCalendar1.AddBoldedDate(tempDate.AddDays(i));
            }
            monthCalendar1.UpdateBoldedDates();
            string endDate = mo.ToString() + "/" + d.ToString() + "/" + yr.ToString();
            //getData("SELECT * FROM myTbl WHERE DT BETWEEN CDATE('" + startDate + "') AND CDATE('" + endDate + "');");
            //dgv.DataSource = dt;
        }



        private void DashMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            handleMonth();
        }

        public void DashWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            handleWeek();

        }

        private void DBModifyApptButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrApptIndex >= 0)
            {
                this.Hide();
                ModifyAppointmentForm MA = new ModifyAppointmentForm();
                MA.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no appointments to modify.", "Error");
            }
        }

        private void DBModifyCustButton_Click(object sender, EventArgs e)
        {
            if (Globals.CurrCustIndex >= 0)
            {
                this.Hide();
                ModifyCustomerForm MA = new ModifyCustomerForm();
                MA.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no customers to modify.", "Error");
            }
        }

        private void DBDeleteApptButton_Click(object sender, EventArgs e)
        {
            DataTable dd = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dd.Load(reader);

                cn.Close();
            }
            try
            {
                int xyz = (int)dd.Rows[Globals.CurrApptIndex]["appointmentId"];
                string M2 = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
                string Query = "delete from appointment where appointmentId= '" + xyz + "';";
                MySqlConnection Conn2 = new MySqlConnection(M2);
                MySqlCommand Command2 = new MySqlCommand(Query, Conn2);
                MySqlDataReader MyReader2;
                Conn2.Open();
                MyReader2 = Command2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                Conn2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Appointment could not be deleted", "Error");
            }

            DataTable dt = new DataTable();
            string connSt = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cnl = new MySqlConnection(connSt))
            {
                cnl.Open();
                MySqlCommand cmld = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cnl);
                MySqlDataReader reader = cmld.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    DashboardApptDGV.DataSource = dt;
                }
                cnl.Close();

            }
        }

        private void DBDeleteCust_Click(object sender, EventArgs e)
        {
            DataTable cd = new DataTable();
            string cnnStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection ccn = new MySqlConnection(cnnStr))
            {
                ccn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from customer", ccn);
                MySqlDataReader reader = cmd.ExecuteReader();
                cd.Load(reader);

                ccn.Close();
            }
            try
            {
                int abc = (int)cd.Rows[Globals.CurrCustIndex]["customerId"];
                string M2 = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
                string Query = "delete from customer where customerId= '" + abc + "';";
                MySqlConnection Cn2 = new MySqlConnection(M2);
                MySqlCommand Command2 = new MySqlCommand(Query, Cn2);
                MySqlDataReader MyReader2;
                Cn2.Open();
                MyReader2 = Command2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                Cn2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Customer could not be deleted", "Error");
            }

            DataTable ct = new DataTable();
            string connSt = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cnl = new MySqlConnection(connSt))
            {
                cnl.Open();
                MySqlCommand cmld = new MySqlCommand("select customerId, customerName, lastUpdate from customer", cnl);
                MySqlDataReader reader = cmld.ExecuteReader();
                ct.Load(reader);
                if (ct.Rows.Count > 0)
                {
                    DashboardCustDGV.DataSource = ct;
                }
                cnl.Close();
            }
        }

        private void DBViewReportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportApptsByMonth rpts = new ReportApptsByMonth();
            rpts.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            currentDate = e.Start;
        }

        private void DashboardCustDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            currentDate = e.Start;
        }

        private void ActiveUserReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportActiveUserList rpt = new ReportActiveUserList();
            rpt.ShowDialog();
        }

        private void SchedByConsReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportSchedByCons sched = new ReportSchedByCons();
            sched.ShowDialog();

        }
    }
}
