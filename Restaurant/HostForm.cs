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
    public partial class HostForm : Form
    {
        public static int currentCustomers { get; set; }
        public HostForm()
        {
            InitializeComponent();
            
        }
        HostStaff hostStaff = new HostStaff();
        private void submitCustomers_Click(object sender, EventArgs e)
        {
            string customersRaw = customerNumber.Text;
            int currentCustomers = 0;
            currentCustomers = int.Parse(customerNumber.Text);

            //if (int.TryParse(customersRaw, out currentCustomers))
            //{
            //    //Parse Successful
            //    hostStaff.SeatCustomers(currentCustomers);
            //}
            //else
            //{
            //    //Parse Unsuccessful
            //}
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeActionSelector actionSelector = new EmployeeActionSelector();
            actionSelector.Show();
            this.Close();
        }
    }
}
