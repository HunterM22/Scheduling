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
using System.Data.SqlClient;


namespace SchedulingApplication
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            //checkLanguage(CultureInfo.CurrentUICulture.LCID);
            ////English or Spanish (Mexico)

        }

        //private void checkLanguage(int LCID)
        //{
        //    if (LCID == 2058)
        //    {
        //        this.Text = "Iniciar sesión";
        //        label1.Text = "Bienvenido, por favor inicie sesión.";
        //        LogInUsernameLabel.Text = "Nombre de usuario";
        //        LogInPasswordLabel.Text = "contraseña";
        //        LogInButton.Text = "Iniciar sesión";
        //        LogInExitButton.Text = "Salida";
        //        //error = "El nombre de usuario o contraseña ingresados ​​no es válido.";
          
        //    }
        //}

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            



            this.Hide();
            Dashboard DB = new Dashboard();
            DB.ShowDialog();


        }

        private void LogInExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
