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

           
        }

        //private void MAApptIDLabel_Click(object sender, EventArgs e)
        //{

        //}

        private void ModifyAppointmentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MACancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard db = new Dashboard();
            db.ShowDialog();
        }

    }
}
