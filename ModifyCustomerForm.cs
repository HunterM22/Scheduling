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

            //Populate fields
            DataTable dt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                //string name =
                //string address =
                //string city =
                //string zip = 
                //string phone = 

                //MCNameTextbox.Text = name;
                //MCAddressTextbox.Text = address;
                //CityComboBox
                //MCZipTextbox.Text = zip;
                //MCPhoneButton.Text = phone;

                //-----------Sample-------------//
                //string type = (string)dt.Rows[Globals.CurrApptIndex]["type"];
                //DateTime start = (DateTime)dt.Rows[Globals.CurrApptIndex]["start"];
                //DateTime end = (DateTime)dt.Rows[Globals.CurrApptIndex]["end"];
                //Globals.ApptId = (int)dt.Rows[Globals.CurrApptIndex]["appointmentId"];


                //MATypeCombobox.Text = type;
                //MAStartTimePicker.Value = (DateTime)start;
                //MAEndTimePicker.Value = (DateTime)end;


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
            string ctyslct = CityComboBox.GetItemText(CityComboBox.SelectedItem);

            string mconnStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection cmn = new MySqlConnection(mconnStrg))
            {
                cmn.Open();
                MySqlCommand mmmd = new MySqlCommand("SELECT cityId from city where city = '" + ctyslct + "';", cmn);
                MySqlDataAdapter mapt = new MySqlDataAdapter(mmmd);
                DataTable mdm = new DataTable();
                mapt.Fill(mdm);

                if (mdm.Rows.Count > 0)
                {
                    int idc = (int)mdm.Rows[0][0];
                    Globals.CtyID = idc;

                }
                cmn.Close();

            }
        }

        private void CountryComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ///xxxxx///
        }
    }
}
