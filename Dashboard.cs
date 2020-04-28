﻿using MySql.Data.MySqlClient;
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
            

            //Inventory.CurrPartIndex = e.RowIndex;
            //Inventory.CurrentPart = Inventory.AllParts[Inventory.CurrPartIndex];
        }

        private void DashboardApptDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ///////xx///////
        }

        private void DashboardCustDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DBExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}