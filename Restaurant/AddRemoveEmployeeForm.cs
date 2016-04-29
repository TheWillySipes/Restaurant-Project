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
    public partial class AddRemoveEmployeeForm : Form
    {
        public AddRemoveEmployeeForm()
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
    }
}
