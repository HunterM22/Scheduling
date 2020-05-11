using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SchedulingApplication
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
            AATypeCombobox.Items.Add("Scrum");
            AATypeCombobox.Items.Add("Presentation");

            //Fill customer combo box
            DataTable ct = new DataTable();
            string connStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection con = new MySqlConnection(connStrg))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("select * from customer", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    AACustomerComboBox.DataSource = ct;
                    AACustomerComboBox.DisplayMember = "customerName";
                }
                con.Close();

            }

        }
           
        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
           
        }

        private void AACancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void AASaveButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                //con string
                string con = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";

                //insert qry 
                string Query = "insert into appointment(customerId,userId,type,start,end,createDate,createdBy)     " +
                    "values('" + Globals.CustComboID + "','" + Globals.UserID + "','" + Globals.ApptTypeCombo + "','" + AAStartTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss") + "','" + AAEndTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss") + "','" +  DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','" + Globals.UserID + "');";
                //connection object and string  
                MySqlConnection con2 = new MySqlConnection(con);
                //command -handle the query and connection object.  
                MySqlCommand comm = new MySqlCommand(Query, con2);
                MySqlDataReader rdr;
                con2.Open();
                rdr = comm.ExecuteReader();
                MessageBox.Show("Data Saved");
                while (rdr.Read())
                {
                }
                con2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add appointment.", "Error");
            }

            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void AACustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void AACustomerComboBox_Click(object sender, EventArgs e)
        {
            
        }

        private void AAStartTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AATypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AATypeCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            Globals.ApptTypeCombo = AATypeCombobox.Text;
        }

        private void AACustomerComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void AACustomerComboBox_DropDownClosed(object sender, EventArgs e)
        {
            
            string cmbslct = AACustomerComboBox.GetItemText(AACustomerComboBox.SelectedItem);

            string mconnStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection cmn = new MySqlConnection(mconnStrg))
            {
                cmn.Open();
                MySqlCommand mmmd = new MySqlCommand("SELECT customerId from customer where customerName = '"+ cmbslct +"';", cmn);
                MySqlDataAdapter mapt = new MySqlDataAdapter(mmmd);
                DataTable mdm = new DataTable();
                mapt.Fill(mdm);

                if (mdm.Rows.Count > 0)
                {
                    int idc = (int)mdm.Rows[0][0];
                    Globals.CustComboID = idc;

                }
                cmn.Close();
                
            }

        }
    }
}
