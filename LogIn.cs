using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;


namespace SchedulingApplication
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();   
         }
                
        private void LogIn_Load(object sender, EventArgs e)
        {
                                 
        }

        public static System.Globalization.RegionInfo CurrentRegion { get; }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection(@"Host = 3.227.166.251; Port = 3306; Database = U06oGK; userid = U06oGK;
            password = 53688825246; SslMode = None; Convert Zero Datetime = True");
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new MySqlDataAdapter("Select * From user where userName = '" + LogInUsernameTextBox.Text + "' and password = '" + LogInPasswordTextBox.Text + "'", mcon);
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Please check your username/password and try again.");
            }
            else
            {
                this.Hide();
                Dashboard showDB = new Dashboard();
                showDB.ShowDialog();
            }
            mcon.Close();
        }


        
        private void LogInExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
