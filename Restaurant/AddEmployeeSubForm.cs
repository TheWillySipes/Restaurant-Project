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


namespace Restaurant
{
    public partial class AddEmployeeSubForm : Form
    {
        public AddEmployeeSubForm()
        {
            InitializeComponent();
        }



        public void AddEmployeeSubForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the employee's information and click Create Employee.  To modify an employee's information or assigned roles, click Modify Employee.");
        }

        //create new employee record in the database using text box input
        public void btnGenEmployeeID_Click(object sender, EventArgs e)
        {
            //EmployeeLogic.AddEmployee is placeholder
            EmployeeVM addNewEmployee = EmployeeLogic.AddEmployee(txtUsername.Text, txtFirstName.Text, txtLastName.Text);
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            ModifyEmployeeSubForm modifyEmployee = new ModifyEmployeeSubForm();
            modifyEmployee.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }








    }
}
