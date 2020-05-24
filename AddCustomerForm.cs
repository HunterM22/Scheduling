using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
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
                    CityCombobox.DataSource = ct;
                    CityCombobox.DisplayMember = "city";
                }
                con.Close();

            }
        }

        private void ACCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void ACAddButton_Click(object sender, EventArgs e)
        {//SAVE NEW CUSTOMER
            if (String.IsNullOrEmpty(ACNameTextbox.Text))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (String.IsNullOrEmpty(ACAddressTextbox.Text))
            {
                MessageBox.Show("Please enter an address.");
                return;
            }
            if (String.IsNullOrEmpty(ACZipTextbox.Text))
            {
                MessageBox.Show("Please enter a zip code.");
                return;
            }
            if (String.IsNullOrEmpty(ACPhoneTextBox.Text))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

                try
                {
                    //Get City ID
                    string ctd = CityCombobox.GetItemText(CityCombobox.SelectedItem);

                    string mconnStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
                    using (MySqlConnection comn = new MySqlConnection(mconnStrg))
                    {
                        comn.Open();
                        MySqlCommand mmd = new MySqlCommand("SELECT cityId from city where city = '" + ctd + "';", comn);
                        MySqlDataAdapter apt = new MySqlDataAdapter(mmd);
                        DataTable md = new DataTable();
                        apt.Fill(md);

                        if (md.Rows.Count > 0)
                        {
                            int idc = (int)md.Rows[0][0];
                            Globals.CtyID = idc;

                        }
                        comn.Close();

                    }

                    //insert ADDRESS/CITY/COUNTRY
                    string con = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
                    string Query = "Insert into address(address,cityId,postalCode,phone,createDate,createdBy) " +
                        "Values('" + ACAddressTextbox.Text + "','" + Globals.CtyID + "','" + ACZipTextbox.Text + "','" + ACPhoneTextBox.Text + "','" + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "','" + Globals.CurrUserName + "');";
                    MySqlConnection con2 = new MySqlConnection(con);
                    MySqlCommand comm = new MySqlCommand(Query, con2);
                    MySqlDataReader rdr;
                    con2.Open();
                    rdr = comm.ExecuteReader();
                    con2.Close();

                    //get ADDRESS ID
                    string mconStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
                    MySqlConnection cmn = new MySqlConnection(mconStrg);
                    MySqlCommand mmmd = new MySqlCommand("SELECT addressId from address where phone = '" + ACPhoneTextBox.Text + "';", cmn);
                    MySqlDataAdapter mapt = new MySqlDataAdapter(mmmd);
                    cmn.Open();
                    DataTable mdm = new DataTable();
                    mapt.Fill(mdm);

                    if (mdm.Rows.Count > 0)
                    {
                        int idc = (int)mdm.Rows[0][0];
                        Globals.AddID = idc;

                    }
                    cmn.Close();


                    //insert into CUSTOMER
                    //con string
                    string conx = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
                    string Queryx = "Insert into customer(customerName,addressId,active,createDate,createdBy)" +
                        "Values('" + ACNameTextbox.Text + "','" + Globals.AddID + "','1','" + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "','" + Globals.CurrUserName + "');";
                    //connection object and string  
                    MySqlConnection con2x = new MySqlConnection(conx);
                    //command -handle the query and connection object.  
                    MySqlCommand commx = new MySqlCommand(Queryx, con2x);
                    MySqlDataReader rdrx;
                    con2x.Open();
                    rdrx = commx.ExecuteReader();
                    MessageBox.Show("Data Saved");
                    while (rdrx.Read())
                    {
                    }
                    con2x.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Customer could not be added.", "Error");
                }

                        
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

    

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void CityCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////////
        }

        private void CityCombobox_DropDownClosed(object sender, EventArgs e)
        {
            string ctyslct = CityCombobox.GetItemText(CityCombobox.SelectedItem);

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
            
        }

        private void ACNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ACNameTextbox.Text))
            {
                ACNameTextbox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                ACNameTextbox.BackColor = System.Drawing.Color.White;
            }
        }

            private void ACNameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void ACZipTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ACAddressTextbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ACAddressTextbox.Text))
            {
                ACAddressTextbox.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                ACAddressTextbox.BackColor = System.Drawing.Color.White;
                
            }
        }

        private void ACZipTextbox_TextChanged(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[\d -]+");
            if (phoneNumpattern.IsMatch(ACZipTextbox.Text))
            {
                ACZipTextbox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                ACZipTextbox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ACPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[\d -]+");
            if (phoneNumpattern.IsMatch(ACPhoneTextBox.Text))
            {
                ACPhoneTextBox.BackColor = System.Drawing.Color.White;
            }
            else
            {
                ACPhoneTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}

