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


            //Fill Appointment Table
            DataTable dt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

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
            /////////////X
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

        }

        private void DashWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {

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
                ModifyAppointmentForm MA = new ModifyAppointmentForm();
                MA.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no customers to modify.", "Error");
            }
        }

        private void DBDeleteApptButton_Click(object sender, EventArgs e)
        {
            try
            {
                int xyz = DashboardApptDGV.SelectedRows[0].Index;
                string M2 = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
                string Query = "delete from appointment where appointmentId= '"+ xyz +"';";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void DBDeleteCust_Click(object sender, EventArgs e)
        {

        }

        private void DBViewReportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports rpts = new Reports();
            rpts.ShowDialog();
        }
    }
}
