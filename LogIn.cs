using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SchedulingApplication
{
    public partial class LogIn : Form
    {
        public delegate string GreetingsDelegate(string name);
        string name = Globals.CurrUserName;

        public LogIn()
        {
            InitializeComponent();
                                   

            CultureInfo mx = CultureInfo.CurrentCulture;

            if (mx.TwoLetterISOLanguageName == "es")
            {
                label1.Text = "Bienvenido, inicia sesion.";
                LogInUsernameLabel.Text = "Nombre de usuario";
                LogInPasswordLabel.Text = "Contrasena";
                LogInButton.Text = "Iniciar sesion";
                LogInExitButton.Text = "Salida";
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            CultureInfo mx = CultureInfo.CurrentCulture;

            MySqlConnection mcon = new MySqlConnection(Globals.connStr);
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();

            adapter = new MySqlDataAdapter("Select * From user where userName = '" + LogInUsernameTextBox.Text + "' and password = '" + LogInPasswordTextBox.Text + "'", mcon);
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                if (mx.TwoLetterISOLanguageName == "es")
                {
                    MessageBox.Show("Verifique su nombre de usuario / contraseña e intente nuevamente.");
                }
                else
                {
                    MessageBox.Show("Please check your username/password and try again.");
                }
            }
            else
            {
                this.Hide();
                Dashboard showDB = new Dashboard();
                showDB.ShowDialog();
            }
            mcon.Close();

            //Log File//
            try
            {
                using (StreamWriter writer = new StreamWriter("log.txt", true))
                {
                    writer.WriteLine(LogInUsernameTextBox.Text + " " + DateTime.Now.ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The file could not be read:");
            }

            Check_Appointment();



        }

        public void Check_Appointment()
        {
            DateTime Now = Convert.ToDateTime(DateTime.UtcNow);
            DateTime NowF = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);
            DataTable dp = new DataTable();
            using (MySqlConnection can = new MySqlConnection(Globals.connStr))
            {
                can.Open();
                MySqlCommand acmd = new MySqlCommand("Select * from appointment where userId = '" + Globals.UserID + "' AND start between '" + Now.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + NowF.ToString("yyyy-MM-dd HH:mm:ss") + "'", can);
                MySqlDataReader areader = acmd.ExecuteReader();
                dp.Load(areader);
                if (dp.Rows.Count > 0)
                {
                    MessageBox.Show("You have an appointment within the next 15 minutes.", "Alert!");
                }
                can.Close();
            }

        }


        private void LogInExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
