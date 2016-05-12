using BusinessLayer.BusinessLogic;
using BusinessLayer.ViewModels;
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
    public partial class OrderStatusForm : Form
    {
        //Get list of food tables on form initialization from the database
        List<FoodTableVM> foodTables = FoodTableLogic.GetTablesWithOpenTickets();

        public OrderStatusForm()
        {
            InitializeComponent();

            foreach(FoodTableVM foodTable in foodTables)
            {
                cmboFoodTable.Items.Add(foodTable);
            }
            cmboFoodTable.DisplayMember = "Info";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WaitStaffForm waitStaff = new WaitStaffForm();
            waitStaff.Show();
            this.Hide();
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            //Verify user selected a table, if not show error and return
            if(cmboFoodTable.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table");
                return;
            }
            //Get selected table from combo box
            FoodTableVM selectedTable = cmboFoodTable.SelectedItem as FoodTableVM;
            //Get ticket from database
            TicketVM ticket = TicketLogic.GetOpenTicket(selectedTable.ID);
            //If ticket is null, there were no tickets
            if(ticket != null)
            {
                if(ticket.TimeCompleted == null)
                {
                    //Order not completed yet, display what time order was placed
                    MessageBox.Show("Ticket not completed, order placed at:\n" + 
                        ticket.TimePlaced.ToShortTimeString());
                }
                else
                {
                    //Order was completed, display time completed
                    MessageBox.Show("Ticket not completed, order completed at:\n" +
                        ticket.TimeCompleted.Value.ToShortTimeString());
                }
            }
            else
            {
                //No order was found, display message
                MessageBox.Show("No orders found");
            }
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
