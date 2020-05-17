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
            string connStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
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

            /////////PREFILL FORM/////////////////
            
            //Get customerName
            DataTable dt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))
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
            string connSt = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connSt))
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
            string connS = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connS))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from city", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dc.Load(reader);

                string city = (string)dc.Rows[Globals.CurrCustIndex]["city"];
                CityComboBox.Text = city;
                cn.Close();
            }
            /////////END PREFILL//////////




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

            string mconnStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
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

        private void CityComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            //Fill city combo box
            DataTable ct = new DataTable();
            string connStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection con = new MySqlConnection(connStrg))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("select * from city", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    CityComboBox.DataSource = ct;
                    CityComboBox.DisplayMember = "customerName";
                }
                con.Close();

            }
        }

        private void MCUpdateButton_Click(object sender, EventArgs e)
        {//SAVE UPDATES
            string ctyslct = CityComboBox.GetItemText(CityComboBox.SelectedItem);
            try
            {
                //UPDATE ADDRESS/CITY/COUNTRY
                string con = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
                string Query = "Update address set address ='" + MCAddressTextbox.Text + "', cityId = '" + ctyslct + "', postalCode = '" + MCZipTextbox.Text + "', phone = '" + MCPhoneButton.Text + "', lastUpdate ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', lastUpdateBy= '" + Globals.CurrUserName + "' Where addressId = '" + Globals.AddID + "';";
                MySqlConnection con2 = new MySqlConnection(con);
                MySqlCommand comm = new MySqlCommand(Query, con2);
                con2.Open();
                comm.ExecuteNonQuery();
                con2.Close();

                //UPDATECUSTOMER
                string conx = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
                string Queryx = "Update customer SET customerName = '" + MCNameTextbox.Text + "', lastUpdate ='" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', lastUpdateBy= '" + Globals.CurrUserName + "' WHERE customerId = '" + Globals.CustID + "';";
                //connection object and string  
                MySqlConnection con2x = new MySqlConnection(conx);
                //command -handle the query and connection object.  
                MySqlCommand commx = new MySqlCommand(Queryx, con2x);
                con2x.Open();
                commx.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
            }
            catch (Exception )
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
            if (String.IsNullOrEmpty(MCZipTextbox.Text))
            {
                MCZipTextbox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MCZipTextbox.BackColor = System.Drawing.Color.White;
            }
        }

        private void MCPhoneButton_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MCPhoneButton.Text))
            {
                MCPhoneButton.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                MCPhoneButton.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
