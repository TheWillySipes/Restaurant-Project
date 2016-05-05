using BusinessLayer;
using BusinessLayer.BusinessLogic;
using BusinessLayer.ViewModels;
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
    public partial class EmployeeActionSelector : Form
    {
        private EmployeeVM Employee { get; set; }
        //The following code of lines will track employee hours.
        Timer stopwatch = new Timer();
        public EmployeeActionSelector(EmployeeVM employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee.ID, Roles.Manager))
            {
                ManagerRoleTasks managerTasks = new ManagerRoleTasks();
                managerTasks.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are NOT in the Manager role!");
            }
        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee.ID, Roles.WaitStaff))
            {
                WaitStaffForm waitStaffForm = new WaitStaffForm();
                waitStaffForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are NOT in the Waiter role!");
            }
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee.ID, Roles.Cook))
            {
                CookStaffForm cookStaffForm = new CookStaffForm();
                cookStaffForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are NOT in the Cook role!");
            }
        }

        private void btnBusser_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee.ID, Roles.BusBoy))
            {
                BusserForm busserForm = new BusserForm();
                busserForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are NOT in the Busser role!");
            }
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee.ID, Roles.Host))
            {
                HostForm hostForm = new HostForm();
                hostForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are NOT in the Host role!");
            }
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {

        stopwatch.Interval = 1000; //in millisecond

            stopwatch.Tick += new EventHandler(this.time_track);

            //Starts time the employes clicks the "clockin" button
            stopwatch.Start();
            //This will be displayed when the employee clicks the "clockin" button
            MessageBox.Show("you have been successfully logged in at " + DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString());
         

        }
        private void time_track(object sender, EventArgs e)
        {
            //Property for time. and also it will display the current time

            double hr = DateTime.Now.Hour;
            double mm = DateTime.Now.Minute;
            double sec = DateTime.Now.Second;

            string time = "";

            if (hr < 10)
            {
                time += "0" + hr;

            }
            else
            {
                time += hr;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;

            }
            else
            {
                time += mm;
            }
            time += ":";

            if (sec < 10)
            {
                time += "0" + sec;

            }
            else
            {
                time += sec;
            }
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            MessageBox.Show("you have been successfully logged out at " + DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToShortDateString());

        }
    }
}
