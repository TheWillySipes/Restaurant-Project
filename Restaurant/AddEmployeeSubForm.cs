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
using BusinessLayer.ViewModels;
using BusinessLayer.BusinessLogic;


namespace Restaurant
{
    public partial class AddEmployeeSubForm : Form
    {
        public AddEmployeeSubForm()
        {
            InitializeComponent();
        }


        //instruction message for this screen
        public void AddEmployeeSubForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Enter the employee's information and click Create Employee.  To modify an employee's information or assigned roles, click Modify Employee.");
        }

        //create new employee record in the database using text box input
        public void btnGenEmployeeID_Click(object sender, EventArgs e)
        {
            //EmployeeLogic.AddEmployee is placeholder
            bool successful = EmployeeLogic.Create(txtUsername.Text, txtFirstName.Text, txtLastName.Text, txtPassword.Text);

            if (successful == true)
            {
                MessageBox.Show("Successfully added employee.");

            }
            else
            {
                MessageBox.Show("Employee Add failed.");
            }
        }

        //launch the modify employee screen
        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            ModifyEmployeeSubForm modifyEmployee = new ModifyEmployeeSubForm();
            modifyEmployee.Show();
            this.Hide();

        }

        //return to previous screen
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerRoleTasks managerTasks = new ManagerRoleTasks();
            managerTasks.Show();
            this.Close();
            
        }


        //Override when user tries to close window, open new instance of login form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            GlobalData.Instance.LoginForm.Show();
            this.Hide();
            this.Dispose();
        }

    }
}
