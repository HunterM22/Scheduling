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
                      

            //Fill Appointment Table
            DataTable xt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                xt.Load(reader);
                if (xt.Rows.Count > 0)
                {
                    for (int idx = 0; idx < xt.Rows.Count; idx++)
                    {
                        xt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)xt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                        xt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)xt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                    }
                    DashboardApptDGV.DataSource = xt;
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
        //public void Check_Appointment()
        //{
        //    DateTime Now = Convert.ToDateTime(DateTime.UtcNow);
        //    DateTime NowF = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);
        //    DataTable dp = new DataTable();
        //    string connSt = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
        //    using (MySqlConnection can = new MySqlConnection(connSt))
        //    {
        //        can.Open();
        //        MySqlCommand acmd = new MySqlCommand("Select * from appointment where userId = '" + Globals.UserID + "' AND start between '" + Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + NowF.ToString("yyyy-MM-dd HH:mm:ss") + "'", can);
        //        MySqlDataReader areader = acmd.ExecuteReader();
        //        dp.Load(areader);
        //        if (dp.Rows.Count > 0)
        //        {
        //            MessageBox.Show("You have an appointment within the next 15 minutes.", "Alert!");
        //        }
        //        can.Close();
        //    }
        //}



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
            
        }

        private void handleDay()
        {
            monthCalendar1.MaxSelectionCount = 1;
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            start = currentDate;
            end = currentDate.AddDays(1);
            monthCalendar1.SetSelectionRange(start, end);

            //Daily appts to DGV
            DataTable da = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection acn = new MySqlConnection(connStr))
            {
                acn.Open();
                MySqlCommand cmdv = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment where start BETWEEN '" + TimeZoneInfo.ConvertTimeToUtc(start).ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + TimeZoneInfo.ConvertTimeToUtc(end).ToString("yyyy-MM-dd HH:mm:ss") + "';", acn);
                MySqlDataReader reader = cmdv.ExecuteReader();
                da.Load(reader);
                if (da.Rows.Count > 0)
                {
                    DashboardApptDGV.DataSource = da;
                    for (int idx = 0; idx < da.Rows.Count; idx++)
                    {
                        da.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)da.Rows[idx]["start"], TimeZoneInfo.Local).ToString("yyyy-MM-dd HH:mm:ss");
                        da.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)da.Rows[idx]["end"], TimeZoneInfo.Local).ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }
                else if (da.Rows.Count < 1)
                {
                    MessageBox.Show("No appointments found for the day selected.");
                }
                acn.Close();
            }

        }
        private void handleWeek()
        {
            monthCalendar1.MaxSelectionCount = 7;
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            start = currentDate;
            end = currentDate.AddDays(7);
            monthCalendar1.SetSelectionRange(start, end);

            //Weekly appts to DGV
            DataTable dv = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))                                                                                        
            {
                cn.Open();
                MySqlCommand cmdv = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment where start BETWEEN '"+ TimeZoneInfo.ConvertTimeToUtc(start).ToString("yyyy-MM-dd HH:mm:ss")+ "' and '"+ TimeZoneInfo.ConvertTimeToUtc(end).ToString("yyyy-MM-dd HH:mm:ss") + "';", cn);
                MySqlDataReader reader = cmdv.ExecuteReader();
                dv.Load(reader);
                if (dv.Rows.Count > 0)
                {
                    DashboardApptDGV.DataSource = dv;
                    for (int idx = 0; idx < dv.Rows.Count; idx++)
                    {
                        dv.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dv.Rows[idx]["start"], TimeZoneInfo.Local).ToString("yyyy-MM-dd HH:mm:ss");
                        dv.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dv.Rows[idx]["end"], TimeZoneInfo.Local).ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }
                else if (dv.Rows.Count < 1)
                {
                    MessageBox.Show("No appointments found for the week selected.");
                }
                cn.Close();
            }
        }

        private void handleMonth()
        {
            monthCalendar1.MaxSelectionCount = 31;
            DateTime Mstart = new DateTime();
            DateTime Mend = new DateTime();
            Mstart = currentDate;
            Mend = currentDate.AddDays(31);
            monthCalendar1.SetSelectionRange(Mstart, Mend);

            //Monthly appts to DGV
            DataTable dh = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection hcn = new MySqlConnection(connStr))
            {
                hcn.Open();
                MySqlCommand cmdv = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment where start BETWEEN '" + TimeZoneInfo.ConvertTimeToUtc(Mstart).ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + TimeZoneInfo.ConvertTimeToUtc(Mend).ToString("yyyy-MM-dd HH:mm:ss") + "';", hcn);
                MySqlDataReader reader = cmdv.ExecuteReader();
                dh.Load(reader);
                if (dh.Rows.Count > 0)
                {
                    DashboardApptDGV.DataSource = dh;
                    for (int idx = 0; idx < dh.Rows.Count; idx++)
                    {
                        dh.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dh.Rows[idx]["start"], TimeZoneInfo.Local).ToString("yyyy-MM-dd HH:mm:ss");
                        dh.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dh.Rows[idx]["end"], TimeZoneInfo.Local).ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }
                else if (dh.Rows.Count < 1)
                {
                    MessageBox.Show("No appointments found for the month selected.");
                }
                hcn.Close();
            }

        }


        private void DashMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //handleMonth();
        }

        public void DashWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            //handleWeek();

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
           
        }

        private void DashboardCustDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
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

        private void ActiveUserReport_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ReportActiveUserList rpt = new ReportActiveUserList();
            //rpt.ShowDialog();
        }

        private void SchedByConsReportButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ReportSchedByCons sched = new ReportSchedByCons();
            //sched.ShowDialog();

        }

        private void SchedByConsReportButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ReportSchedByCons sched = new ReportSchedByCons();
            sched.ShowDialog();

        }

        private void RepActiveUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportActiveUserList rpt = new ReportActiveUserList();
            rpt.ShowDialog();
        }

        private void ApptSearchButton_Click(object sender, EventArgs e)
        {
            string ad = ApptSearchBox.Text;

            DataTable za = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmmd = new MySqlCommand("SELECT appointmentId, customerId, type, start, end FROM appointment where appointmentId = '" + ad + "'", cn);
                MySqlDataReader rder = cmmd.ExecuteReader();
                za.Load(rder);

                if (za.Rows.Count > 0)
                {
                    DashboardApptDGV.DataSource = za;
                }
                cn.Close();
            }

        }

        private void CustSearchButton_Click(object sender, EventArgs e)
        {
            string tb = CustSearchBox.Text;

            DataTable zt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT customerId, customerName, lastUpdateBy FROM customer where customerId = '" + tb + "'", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                zt.Load(reader);

                if (zt.Rows.Count > 0)
                {
                    DashboardCustDGV.DataSource = zt;
                }
                cn.Close();
            }

        }

        private void ApptSearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ClearApptsButton_Click(object sender, EventArgs e)
        {
            DataTable xt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                xt.Load(reader);
                if (xt.Rows.Count > 0)
                {
                    for (int idx = 0; idx < xt.Rows.Count; idx++)
                    {
                        xt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)xt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                        xt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)xt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                    }
                    DashboardApptDGV.DataSource = xt;
                }
                cn.Close();

                ApptSearchBox.Text = "";
            }

        }

        private void ClearCustButton_Click(object sender, EventArgs e)
        {
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

                CustSearchBox.Text = "";

            }
        }
    }
}
