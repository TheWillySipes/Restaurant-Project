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

namespace Restaurant
{
    public partial class ModifyEmployeeSubForm : Form
    {
        public ModifyEmployeeSubForm()
        {
            InitializeComponent();
            var employees = EmployeeLogic.GetEmployees();
            foreach (var employee in employees)
            {
                lstEmployeeList.Items.Add(employee.FirstName);
            }
            
        }

        private void lstEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {

        }

        private void chkboxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //public void ModifyEmployeeSubForm_Load(object sender, );


    }
}
