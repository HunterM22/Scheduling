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
        public Dashboard()
        {
            InitializeComponent();

            dgvFormatter(DashboardCustDGV);
            dgvFormatter(DashboardApptDGV);

            monthCalendar1.MaxSelectionCount = 1;
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            monthCalendar1.AddBoldedDate(currentDate);



            //Fill Appointment Table
            DataTable dt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                //string temp = (dt.Rows[1]["type"]).ToString();//get values from row based on current index

                if (dt.Rows.Count > 0)
                {
                    DashboardApptDGV.DataSource = dt;
                }
                cn.Close();

            }
            //Fill Customer Table
            DataTable ct = new DataTable();
            string connStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
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

        private void DashMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 31;
        }

        public void DashWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 7;
            monthCalendar1.RemoveAllBoldedDates();
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
           

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
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
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
                string M2 = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
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
            string connSt = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
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
            string cnnStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
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
                string M2 = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
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
            string connSt = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
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
            Reports rpts = new Reports();
            rpts.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
