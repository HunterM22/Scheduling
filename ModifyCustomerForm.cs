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
    public partial class ModifyCustomerForm : Form
    {
        public ModifyCustomerForm()
        {
            InitializeComponent();

            //Fill city combo box
            DataTable ct = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Globals.connStr))
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

      
            //Get customerName
            DataTable dt = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(Globals.connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from customer", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                string name = (string)dt.Rows[Globals.CurrCustIndex]["customerName"];
                MCNameTextbox.Text = name;
                cn.Close();
            }
            //Get address/zip/phone
            DataTable da = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(Globals.connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from address", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                da.Load(reader);

                string address = (string)da.Rows[Globals.CurrCustIndex]["address"];
                string zip = (string)da.Rows[Globals.CurrCustIndex]["postalCode"];
                string phone = (string)da.Rows[Globals.CurrCustIndex]["phone"];
                Globals.AddID = (int)da.Rows[Globals.CurrCustIndex]["addressId"];

                MCAddressTextbox.Text = address;
                MCZipTextbox.Text = zip;
                MCPhoneButton.Text = phone;
                cn.Close();
            }
            //Get city
            DataTable dc = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(Globals.connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from city", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dc.Load(reader);

                string city = (string)dc.Rows[Globals.CurrCustIndex]["city"];
                CityComboBox.Text = city;
                cn.Close();
            }
         
            ///Get City ID
            DataTable ic = new DataTable();
            using (MySqlConnection icn = new MySqlConnection(Globals.connStr))
            {
                icn.Open();
                MySqlCommand icmd = new MySqlCommand("select cityId from city where city = '"+ CityComboBox.Text +"';", icn);
                MySqlDataReader reader = icmd.ExecuteReader();
                ic.Load(reader);

                int cidc = (int)ic.Rows[0][0];
                Globals.CtyID = cidc;
                icn.Close();
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

            using (MySqlConnection cmn = new MySqlConnection(Globals.connStr))
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

        private void CityComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            ////
        }

        private void MCUpdateButton_Click(object sender, EventArgs e)
        {//SAVE UPDATES
            if (String.IsNullOrEmpty(MCNameTextbox.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (String.IsNullOrEmpty(MCAddressTextbox.Text))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }
            if (String.IsNullOrEmpty(MCZipTextbox.Text))
            {
                MessageBox.Show("Please enter a zip code.");
                return;
            }
            if (String.IsNullOrEmpty(MCPhoneButton.Text))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            string ctyslct = CityComboBox.GetItemText(CityComboBox.SelectedItem);
            try
            {
                //UPDATE ADDRESS/CITY/COUNTRY
                string Query = "Update address set address ='" + MCAddressTextbox.Text + "', cityId = '" + Globals.CtyID + "', postalCode = '" + MCZipTextbox.Text + "', phone = '" + MCPhoneButton.Text + "', lastUpdate ='" + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', lastUpdateBy= '" + Globals.CurrUserName + "' Where addressId = '" + Globals.AddID + "';";
                MySqlConnection con2 = new MySqlConnection(Globals.connStr);
                MySqlCommand comm = new MySqlCommand(Query, con2);
                con2.Open();
                comm.ExecuteNonQuery();
                con2.Close();

                //UPDATECUSTOMER
                string Queryx = "Update customer SET customerName = '" + MCNameTextbox.Text + "', lastUpdate ='" + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', lastUpdateBy= '" + Globals.CurrUserName + "' WHERE customerId = '" + Globals.CustID + "';";
                MySqlConnection con2x = new MySqlConnection(Globals.connStr);
                MySqlCommand commx = new MySqlCommand(Queryx, con2x);
                con2x.Open();
                commx.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not update customer.", "Error");
            }
                            
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MCNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MCNameTextbox.Text))
            {
                MCNameTextbox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MCNameTextbox.BackColor = System.Drawing.Color.White;
            }
        }

        private void MCAddressTextbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MCAddressTextbox.Text))
            {
                MCAddressTextbox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MCAddressTextbox.BackColor = System.Drawing.Color.White;
            }
        }

        private void MCZipTextbox_TextChanged(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[\d -]+");
            if (phoneNumpattern.IsMatch(MCZipTextbox.Text))
            {
                MCZipTextbox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                MCZipTextbox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void MCPhoneButton_TextChanged(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[\d -]+");
            if (phoneNumpattern.IsMatch(MCPhoneButton.Text))
            {
                MCPhoneButton.BackColor = System.Drawing.Color.White;
            }
            else
            {
                MCPhoneButton.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
