using BusinessLayer;
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
    public partial class WaitStaffForm : Form
    {
        public WaitStaffForm()
        {
            InitializeComponent();
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
           //Checking status of an order
            OrderStatusForm orderStatus = new OrderStatusForm();
            orderStatus.Show();
            this.Hide();
        }

        private void btnEnterOrder_Click(object sender, EventArgs e)
        {
            //Opens form to enter ticket order
            TicketForm ticketForm = new TicketForm();
            this.Hide();
            ticketForm.Show();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeActionSelector employeeAction = new EmployeeActionSelector();
            employeeAction.Show();
            this.Hide();
        }

        private void btnFloorStatus_Click(object sender, EventArgs e)
        {
            
            FloorStatus floorForm = new FloorStatus(new WaitStaffForm());
            floorForm.Show();
            this.Hide();
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            //Select table and cash out customers
            CashOutForm cashout = new CashOutForm();
            cashout.Show();
            this.Hide();
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
