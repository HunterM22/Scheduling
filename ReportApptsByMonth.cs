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

            
            groupBox1.Text = "Report: Number of each type, by month:\r\n\r\n";
            string[] Months = new string[] { "February", "March", "April" };

            foreach (string month in Months)
            {
                groupBox1.Text = groupBox1.Text + month + "\r\n";
                int February = 0;
                int March = 0;
                int April = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (month == Months[((DateTime)row["start"]).Month])
                    {
                        if (row["start"].ToString() == "February")
                        {
                            February++;
                        }
                        if (row["start"].ToString() == "March")
                        {
                            March++;
                        }
                        if (row["start"].ToString() == "April")
                        {
                            April++;
                        }
                    }
                }
                groupBox1.Text = groupBox1.Text +
                    "\tFebruary\t\t" + February + "\r\n" +
                    "\tMarch\t\t" + March + "\r\n" +
                    "\tApril\t\t" + April + "\r\n";
                

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
            Reports rform = new Reports();
            rform.ShowDialog();
        }
    }
}
