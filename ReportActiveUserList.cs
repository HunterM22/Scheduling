﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication
{
    public partial class ReportActiveUserList : Form
    {
        public ReportActiveUserList()
        {
            InitializeComponent();
            dgvFormatter(dataGridView1);

            //Fill Table
            DataTable ct = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Globals.connStr))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("select userId, userName, createDate, createdBy, lastUpdate, lastUpdateBy from user where active =1;", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    dataGridView1.DataSource = ct;
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
