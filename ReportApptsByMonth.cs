using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication
{
    public partial class ReportApptsByMonth : Form
    {
        public ReportApptsByMonth()
        {
            InitializeComponent();
            dgvFormatter(dataGridView1);

            //Fill Appointment Table
            
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            MySqlConnection cn = new MySqlConnection(connStr);
            
            cn.Open();
            MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

            //Get Feb appt count
            string conStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            MySqlConnection con = new MySqlConnection(conStr);
            con.Open();
            MySqlCommand cmmd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-02%';",con);
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmmd);
            DataTable df = new DataTable();
            adpt.Fill(df);

            string febapptcount = df.Rows[0][0].ToString();
            febTB.Text = febapptcount;
            con.Close();

            //Get March appt count
            string onStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            MySqlConnection on = new MySqlConnection(onStr);
            on.Open();
            MySqlCommand mmd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-03%';", on);
            MySqlDataAdapter apt = new MySqlDataAdapter(mmd);
            DataTable dm = new DataTable();
            apt.Fill(dm);

            string marapptcount = dm.Rows[0][0].ToString();
            MarTB.Text = marapptcount;
            on.Close();

            //Get Apr appt count
            string aonStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            MySqlConnection aon = new MySqlConnection(aonStr);
            aon.Open();
            MySqlCommand ammd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-04%';", aon);
            MySqlDataAdapter aapt = new MySqlDataAdapter(ammd);
            DataTable adm = new DataTable();
            aapt.Fill(adm);

            string aprapptcount = adm.Rows[0][0].ToString();
            AprTB.Text = aprapptcount;
            aon.Close();

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

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports rform = new Reports();
            rform.ShowDialog();
        }

        private void MarTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void febTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
