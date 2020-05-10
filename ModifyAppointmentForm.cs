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
    public partial class ModifyAppointmentForm : Form
    {
        public ModifyAppointmentForm()
        {
            InitializeComponent();

            //Fill appt type combo box
            MATypeCombobox.Items.Add("Scrum");
            MATypeCombobox.Items.Add("Presentation");


            //Populate fields
            DataTable dt = new DataTable();
            string connStr = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                string type = (string)dt.Rows[Globals.CurrApptIndex]["type"]; ////
                DateTime start = (DateTime)dt.Rows[Globals.CurrApptIndex]["start"];
                DateTime end = (DateTime)dt.Rows[Globals.CurrApptIndex]["end"];

                //MACustomerIDCombo.Text = cusId.ToString();
                MATypeCombobox.Text = type;
                MAStartTimePicker.Value = (DateTime)start;
                MAEndTimePicker.Value = (DateTime)end;

            }

            //private void MAApptIDLabel_Click(object sender, EventArgs e)
            //{

            //}
        }

        private void ModifyAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void MACancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void MAUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //con string
                string con = @"Host=3.227.166.251;Port=3306;Database=U06oGK;userid=U06oGK;password=53688825246;SslMode=None";
                MySqlConnection con2 = new MySqlConnection(con);
                con2.Open();
                //update qry 
                string Query = "Update appointment Set type = '" + Globals.ApptTypeCombo.ToString()+"', start = '" + MAStartTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', end = '" + MAEndTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss") + "', lastUpdate = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', lastUpdateBy = '" + Globals.UserID + "' WHERE appointmentId = '" + Globals.CurrApptIndex + "';";
                //command -handle the query and connection object.  
                MySqlCommand comm = new MySqlCommand(Query, con2);
                comm.ExecuteNonQuery();
                MySqlDataReader rdr;
                rdr = comm.ExecuteReader();

                MessageBox.Show("Data Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update appointment.", "Error");
            }

            this.Hide();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

        private void MATypeCombobox_Click(object sender, EventArgs e)
        {
            Globals.ApptTypeCombo = MATypeCombobox.Text;
            //Globals.CurrCustIndex = e.RowIndex;
        }

    }
}