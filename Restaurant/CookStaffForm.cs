using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class CookStaffForm : Form
    {

        public CookStaffForm()
        {
            InitializeComponent();
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {

           //Clocking in cook staff
            DateTime clockedInTime = DateTime.Now;
            MessageBox.Show("Cook Staff Clocked in: " + clockedInTime);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clocking out cook staff
            DateTime clockedOutTime = DateTime.Now;
            MessageBox.Show("Cook Staff Clocked out: " + clockedOutTime);
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();

        }
    }
}
