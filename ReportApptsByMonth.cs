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

            using (MySqlConnection cn = new MySqlConnection(Globals.connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }

            //Get Feb appt count
            using (MySqlConnection con = new MySqlConnection(Globals.connStr))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-02%' AND type = 'Scrum';", con);
                MySqlDataAdapter adpt = new MySqlDataAdapter(cmmd);
                DataTable df = new DataTable();
                adpt.Fill(df);

                string febscrumcount = df.Rows[0][0].ToString();
                febTB.Text = febscrumcount;
                con.Close();
            }

            using (MySqlConnection pcon = new MySqlConnection(Globals.connStr))
            {
                pcon.Open();
                MySqlCommand pcmmd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-02%' AND type = 'Presentation';", pcon);
                MySqlDataAdapter padpt = new MySqlDataAdapter(pcmmd);
                DataTable pdf = new DataTable();
                padpt.Fill(pdf);

                string febprescount = pdf.Rows[0][0].ToString();
                FebPresTB.Text = febprescount;
                pcon.Close();

            }

            //Get March appt count
            using (MySqlConnection on = new MySqlConnection(Globals.connStr))
            {
                on.Open();
                MySqlCommand mmd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-03%' AND type = 'Scrum';", on);
                MySqlDataAdapter apt = new MySqlDataAdapter(mmd);
                DataTable dm = new DataTable();
                apt.Fill(dm);

                string marapptcount = dm.Rows[0][0].ToString();
                MarTB.Text = marapptcount;
                on.Close();
            }

            using (MySqlConnection pon = new MySqlConnection(Globals.connStr))
            {
                pon.Open();
                MySqlCommand pmmd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-03%' AND type = 'Presentation';", pon);
                MySqlDataAdapter pdpt = new MySqlDataAdapter(pmmd);
                DataTable ppf = new DataTable();
                pdpt.Fill(ppf);

                string marprescount = ppf.Rows[0][0].ToString();
                MarPresTB.Text = marprescount;
                pon.Close();
            }

            //Get Apr appt count
            using (MySqlConnection aon = new MySqlConnection(Globals.connStr))
            {
                aon.Open();
                MySqlCommand ammd = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-04%' AND type = 'Scrum';", aon);
                MySqlDataAdapter aapt = new MySqlDataAdapter(ammd);
                DataTable adm = new DataTable();
                aapt.Fill(adm);

                string aprapptcount = adm.Rows[0][0].ToString();
                AprTB.Text = aprapptcount;
                aon.Close();
            }

            using (MySqlConnection apon = new MySqlConnection(Globals.connStr))
            {
                apon.Open();
                MySqlCommand papr = new MySqlCommand("SELECT COUNT(*) FROM appointment WHERE start LIKE '2019-04%' AND type = 'Presentation';", apon);
                MySqlDataAdapter aprt = new MySqlDataAdapter(papr);
                DataTable arp = new DataTable();
                aprt.Fill(arp);

                string aprprescount = arp.Rows[0][0].ToString();
                AprPresTB.Text = aprprescount;
                apon.Close();
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

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void MarTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void febTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MarPresTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
