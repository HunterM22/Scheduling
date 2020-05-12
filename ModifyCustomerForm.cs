using MySql.Data.MySqlClient;
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
    public partial class ModifyCustomerForm : Form
    {
        public ModifyCustomerForm()
        {
            InitializeComponent();

            //Fill city combo box
            DataTable ct = new DataTable();
            string connStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection con = new MySqlConnection(connStrg))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("select * from city", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    CityComboBox.DataSource = ct;
                    CityComboBox.DisplayMember = "city";
                }
                con.Close();

            }

            //Fill country combo box
            DataTable cr = new DataTable();
            string conStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection con = new MySqlConnection(conStrg))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from country", con);
                MySqlDataReader creader = cmd.ExecuteReader();
                cr.Load(creader);

                if (cr.Rows.Count > 0)
                {
                    CountryComboBox.DataSource = cr;
                    CountryComboBox.DisplayMember = "country";
                }
                con.Close();

            }
        }

        private void MCCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void CityComboBox_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void CountryComboBox_DropDownClosed(object sender, EventArgs e)
        {

        }
    }
}
