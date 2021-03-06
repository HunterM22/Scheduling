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
    public partial class ReportSchedByCons : Form
    {

        public delegate string UserConf(int user);
        int user = Globals.SelUser;

        public ReportSchedByCons()
        {
            InitializeComponent();
            dgvFormatter(dataGridView1);

        }

        private void ReportSchedByCons_Load(object sender, EventArgs e)
        {

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

        private void UserCB_DropDownClosed(object sender, EventArgs e)
        {
            string userslct = UserCB.GetItemText(UserCB.SelectedItem);

            using (MySqlConnection cmn = new MySqlConnection(Globals.connStr))
            {
                cmn.Open();
                MySqlCommand mmmd = new MySqlCommand("SELECT userId from user where userName = '" + userslct + "';", cmn);
                MySqlDataAdapter mapt = new MySqlDataAdapter(mmmd);
                DataTable mdm = new DataTable();
                mapt.Fill(mdm);

                if (mdm.Rows.Count > 0)
                {
                    int idc = (int)mdm.Rows[0][0];
                    Globals.SelUser = idc;

                }
                cmn.Close();
            }

            //Fill Appt Table with Selected User Appts
            DataTable at = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(Globals.connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, customerId, type, start, end FROM appointment where userId = '" + Globals.SelUser + "'", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                at.Load(reader);

                if (at.Rows.Count > 0)
                {
                    dataGridView1.DataSource = at;
                }
                cn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserCB_Click(object sender, EventArgs e)
        {
            //Fill user combo box
            DataTable ct = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Globals.connStr))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("select * from user", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    UserCB.DataSource = ct;
                    UserCB.DisplayMember = "userName";
                }
                con.Close();

            }
        }

        private void UserCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
