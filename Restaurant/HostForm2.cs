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
    public partial class HostForm2 : Form
    {
        public HostForm2()
        {
            InitializeComponent();
        }

        private void btnFloorStatus_Click(object sender, EventArgs e)
        {
            FloorStatus floor = new FloorStatus();
            floor.Show();
            this.Hide();
        }

        private void btnSeatCustomer_Click(object sender, EventArgs e)
        {
            HostForm hostForm1 = new HostForm();
            hostForm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeActionSelector eaSelect = new EmployeeActionSelector();
            eaSelect.Show();

        }
    }
}
