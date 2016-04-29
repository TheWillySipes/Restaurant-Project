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
        public EmployeeActionSelector(EmployeeVM employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee, Roles.Manager))
            {
                MessageBox.Show("You are in the Manager role!");
            }
            else
            {
                MessageBox.Show("You are NOT in the Manager role!");
            }
        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee, Roles.WaitStaff))
            {
                MessageBox.Show("You are in the Waiter role!");
            }
            else
            {
                MessageBox.Show("You are NOT in the Waiter role!");
            }
        }

        private void btnCook_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee, Roles.Cook))
            {
                MessageBox.Show("You are in the Cook role!");
            }
            else
            {
                MessageBox.Show("You are NOT in the Cook role!");
            }
        }

        private void btnBusser_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee, Roles.BusBoy))
            {
                MessageBox.Show("You are in the Busser role!");
            }
            else
            {
                MessageBox.Show("You are NOT in the Busser role!");
            }
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            if (EmployeeLogic.IsInRole(Employee, Roles.Host))
            {
                MessageBox.Show("You are in the Host role!");
            }
            else
            {
                MessageBox.Show("You are NOT in the Host role!");
            }
        }
    }
}
