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
            MATypeCombobox.Items.Add("Phone");
            MATypeCombobox.Items.Add("Online");

            //Populate fields
            DataTable dt = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(Globals.connStr))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("select appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                string type = (string)dt.Rows[Globals.CurrApptIndex]["type"];     
                DateTime start = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[Globals.CurrApptIndex]["start"], TimeZoneInfo.Local);
                DateTime end = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[Globals.CurrApptIndex]["end"], TimeZoneInfo.Local);
                Globals.ApptId = (int)dt.Rows[Globals.CurrApptIndex]["appointmentId"];

                MATypeCombobox.Text = type;
                MAStartTimePicker.Value = (DateTime)start;
                MAEndTimePicker.Value = (DateTime)end;

            }

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

        private bool BizHourCheck()
        {
            var beginBusinessHours = new TimeSpan(8, 0, 0);
            var endBusinessHours = new TimeSpan(17, 1, 0);
            var appointmentBeginTime = MAStartTimePicker.Value.TimeOfDay;
            var appointmentEndTime = MAEndTimePicker.Value.TimeOfDay;

            if (appointmentBeginTime < beginBusinessHours || appointmentEndTime > endBusinessHours)
            {
                bizhourlabel.Text = "Appointment must be between 8am and 5pm.";
                return false;
            }

            return true;
        }

        private void MAUpdateButton_Click(object sender, EventArgs e)
        {
            if (!BizHourCheck())
            {
                bizhourlabel.Visible = true;
                return;
            }

            //Get Appt List
            DateTime AStart = new DateTime();
            DateTime AEnd = new DateTime();

            AStart = TimeZoneInfo.ConvertTimeToUtc(MAStartTimePicker.Value);
            AEnd = TimeZoneInfo.ConvertTimeToUtc(MAEndTimePicker.Value);

            DataTable dt = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(Globals.connStr))
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
                    string type = MATypeCombobox.GetItemText(MATypeCombobox.SelectedItem);
                    
                    MySqlConnection Conn = new MySqlConnection(Globals.connStr);
                    string Query = "Update appointment Set type = '" + type + "', start = '" + TimeZoneInfo.ConvertTimeToUtc(MAStartTimePicker.Value).ToString("yyyy-MM-dd HH:mm:ss") + "', end = '" + TimeZoneInfo.ConvertTimeToUtc(MAEndTimePicker.Value).ToString("yyyy-MM-dd HH:mm:ss") + "', lastUpdate = '" + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', lastUpdateBy = '" + Globals.CurrUserName + "' WHERE appointmentId = '" + Globals.ApptId + "';";
                    MySqlCommand comm = new MySqlCommand(Query, Conn);
                    Conn.Open();
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                    Conn.Close();
                }
                catch
                {
                    MessageBox.Show("Could not update appointment.", "Error");
                }


                this.Hide();
                Dashboard db = new Dashboard();
                db.ShowDialog();
            }
        }

        private void MATypeCombobox_Click(object sender, EventArgs e)
        {
            Globals.ApptTypeCombo = MATypeCombobox.Text;
        }

        private void MATypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}