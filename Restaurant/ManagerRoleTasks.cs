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
    public partial class ManagerRoleTasks : Form
    {
        public ManagerRoleTasks()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmployeeSubForm addEmployee = new AddEmployeeSubForm();
            addEmployee.Show();
            this.Hide();
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            RemoveEmployeeSubForm removeEmployee = new RemoveEmployeeSubForm();
            removeEmployee.Show();
            this.Hide();

        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            ModifyEmployeeSubForm modifyEmployee = new ModifyEmployeeSubForm();
            modifyEmployee.Show();
            this.Hide();

        }
    }
}
