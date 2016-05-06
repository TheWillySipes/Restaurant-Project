using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessLayer.BusinessLogic;
using BusinessLayer.ViewModels;

namespace Restaurant
{
    public partial class ModifyEmployeeSubForm : Form
    {
        List<EmployeeVM> employees = EmployeeLogic.Get();

        //populate the dropdown with a list of all employees
        public ModifyEmployeeSubForm()
        {
            InitializeComponent();
            RefreshList();
        }

        //populate text fields with the properties of selected employees
        private void lstEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeVM employee = lstEmployeeList.SelectedItem as EmployeeVM;
            txtUsername.Text = employees[lstEmployeeList.SelectedIndex].UserName;
            txtFirstName.Text = employees[lstEmployeeList.SelectedIndex].FirstName;
            txtLastName.Text = employees[lstEmployeeList.SelectedIndex].LastName;
            txtPassword.Text = employees[lstEmployeeList.SelectedIndex].Password;

            EmployeeLogic.GetUserRoles(lstEmployeeList.SelectedIndex);
            chkHost.Checked = EmployeeLogic.IsInRole(employee.ID , Roles.Host);
            chkWaiter.Checked = EmployeeLogic.IsInRole(employee.ID, Roles.WaitStaff);
            chkCook.Checked = EmployeeLogic.IsInRole(employee.ID, Roles.Cook);
            chkBusser.Checked = EmployeeLogic.IsInRole(employee.ID, Roles.BusBoy);
            chkManager.Checked = EmployeeLogic.IsInRole(employee.ID, Roles.Manager);
        }

        //click button to update database with current information
        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            EmployeeVM employee = lstEmployeeList.SelectedItem as EmployeeVM;
            employee.UserName = txtUsername.Text;
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Password = txtPassword.Text;

            if (chkHost.Checked == true)
            {
                EmployeeLogic.AddUserToRole(employee.ID, Roles.Host);
            }
            else { EmployeeLogic.RemoveUserFromRole(employee.ID, Roles.Host); }


            if (chkWaiter.Checked == true)
            {
                EmployeeLogic.AddUserToRole(employee.ID, Roles.WaitStaff);
            }
            else { EmployeeLogic.RemoveUserFromRole(employee.ID, Roles.WaitStaff); }

            if (chkCook.Checked == true)
            {
                EmployeeLogic.AddUserToRole(employee.ID, Roles.Cook);
            }
            else { EmployeeLogic.RemoveUserFromRole(employee.ID, Roles.Cook); }

            if (chkBusser.Checked == true)
            {
                EmployeeLogic.AddUserToRole(employee.ID, Roles.BusBoy);
            }
            else { EmployeeLogic.RemoveUserFromRole(employee.ID, Roles.BusBoy); }

            if (chkManager.Checked == true)
            {
                EmployeeLogic.AddUserToRole(employee.ID, Roles.Manager);
            }
            else { EmployeeLogic.RemoveUserFromRole(employee.ID, Roles.Manager); }


            EmployeeLogic.UpdateEmployee(employee);
            RefreshList();

            MessageBox.Show("Employee List Updated!");

        }

        //deletes employee record
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            EmployeeVM employee = lstEmployeeList.SelectedItem as EmployeeVM;

            //EmployeeLogic.DeleteEmployee(employee.ID);

            MessageBox.Show("This option has been disabled for your user level.  Please contact the system administrator.");
            RefreshList();

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            ManagerRoleTasks managerTasks = new ManagerRoleTasks();
            managerTasks.Show();
            this.Close();

        }

        //Refresh dropdown list and clear all fields
        public void RefreshList()
        {
            lstEmployeeList.Items.Clear();
            txtUsername.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();

            chkHost.Checked = false;
            chkWaiter.Checked = false;
            chkCook.Checked = false;
            chkBusser.Checked = false;
            chkManager.Checked = false;


            employees = EmployeeLogic.GetEmployees();
            foreach (var employee in employees)
            {
                lstEmployeeList.Items.Add(employee);
            }

            lstEmployeeList.DisplayMember = "FirstName";
            

        }




    }
}
