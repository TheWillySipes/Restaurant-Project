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

        public ModifyEmployeeSubForm()
        {
            InitializeComponent();

            foreach (var employee in employees)
            {
                lstEmployeeList.Items.Add(employee.FirstName);
            }
            
        }

        private void lstEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsername.Text = employees[lstEmployeeList.SelectedIndex].UserName;
            txtFirstName.Text = employees[lstEmployeeList.SelectedIndex].FirstName;
            txtLastName.Text = employees[lstEmployeeList.SelectedIndex].LastName;
            txtPassword.Text = employees[lstEmployeeList.SelectedIndex].Password;

            //chkHost.Checked
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {

        }






    }
}
