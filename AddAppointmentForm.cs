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
using Org.BouncyCastle.Asn1.Cms;

namespace SchedulingApplication
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
            AATypeCombobox.Items.Add("Scrum");
            AATypeCombobox.Items.Add("Presentation");

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

        private bool BizHourCheck()
        {
            var beginBusinessHours = new TimeSpan(8, 0, 0);
            var endBusinessHours = new TimeSpan(17, 0, 0);
            var appointmentBeginTime = AAStartTimePicker.Value.TimeOfDay;
            var appointmentEndTime = AAEndTimePicker.Value.TimeOfDay;

            if (appointmentBeginTime < beginBusinessHours || appointmentEndTime > endBusinessHours)
            {
                bizhourlabel.Text = "Appointment must be between 8am and 5pm.";
                return false;
            }

            return true;
        }

        private void AASaveButton_Click(object sender, EventArgs e)
        {
            if (!BizHourCheck())
            {
                bizhourlabel.Visible = true;
                return;
            }

            //Get Appt List
            DateTime AStart = new DateTime();
            DateTime AEnd = new DateTime();

            AStart = TimeZoneInfo.ConvertTimeToUtc(AAStartTimePicker.Value);
            AEnd = TimeZoneInfo.ConvertTimeToUtc(AAEndTimePicker.Value);

            DataTable dt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DateTime bStart = Convert.ToDateTime(dt.Rows[i]["start"]);
                        DateTime bEnd = Convert.ToDateTime(dt.Rows[i]["end"]);
                        if (AStart < bEnd && bStart < AEnd)
                        {
                            MessageBox.Show("Scheduling Conflict: Overlapping meeting times. Please Try Again.");
                            return;


                        }
                        cn.Close();
                    }
                }

                try
                {
                    //con string
                    string con = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";

                    //insert qry 
                    string Query = "insert into appointment(customerId,userId,type,start,end,createDate,createdBy)     " +
                        "values('" + Globals.CustComboID + "','" + Globals.UserID + "','" + Globals.ApptTypeCombo + "','" + TimeZoneInfo.ConvertTimeToUtc(AAStartTimePicker.Value).ToString("yyyy-MM-dd HH:mm:ss") + "','" + TimeZoneInfo.ConvertTimeToUtc(AAEndTimePicker.Value).ToString("yyyy-MM-dd HH:mm:ss") + "','" + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "','" + Globals.CurrUserName + "');";
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
                catch (Exception)
                {
                    MessageBox.Show("Could not add appointment.", "Error");
                    return;
                }

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
            //Fill customer combo box
            DataTable ct = new DataTable();
            string connStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
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

            string mconnStrg = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None;Convert Zero Datetime=true";
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
