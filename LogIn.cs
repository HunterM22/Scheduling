using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SchedulingApplication
{
    public partial class LogIn : Form
    {
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
                //HOW TO TRANSLATE ERROR MESSAGE?? = "Por favor revise sus credenciales.";
            }
        }

        
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            CultureInfo mx = CultureInfo.CurrentCulture;

            MySqlConnection mcon = new MySqlConnection(@"Host = 3.227.166.251; Port = 3306; Database = U06oGK; userid = U06oGK;
            password = 53688825246; SslMode = None; Convert Zero Datetime = True");
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
        }



        private void LogInExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
