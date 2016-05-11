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
    public partial class CashOutForm : Form
    {
        WaitStaffForm waitStaff = new WaitStaffForm();
        List<FoodTableVM> foodTables;
        public CashOutForm()
        {
            InitializeComponent();
            UpdateDropDown();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           // WaitStaffForm waitStaff = new WaitStaffForm();
            waitStaff.checkclockin = true;
            waitStaff.Show();
            this.Hide();
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            FoodTableVM foodTable = cbTableList.SelectedItem as FoodTableVM;
            if (foodTable != null)
            {
                TicketVM ticket = TicketLogic.GetOpenTicket(foodTable.ID);
                if (ticket == null)
                {
                    return;
                }

                List<TicketsMenuItemVM> items = TicketsMenuItemLogic.GetTicketsMenuItems(ticket.ID);
                string output = "";
                decimal ticketValue = 0;
                foreach (var item in items)
                {
                    output += "\n" + item.MenuItemTitle + "$" + item.PricePaid;
                    ticketValue += item.PricePaid;
                }
                output += "\n\n" + DateTime.Now.ToString();
                output += "\nTotal Cost: $" + ticketValue.ToString();
                MessageBox.Show(output);

                TicketLogic.CloseTableTicket(ticket.TableID);
                UpdateDropDown();
            }
            else
            {
                MessageBox.Show("No ticket for this table!");
            }
        }

        public void UpdateDropDown()
        {
            cbTableList.Items.Clear();
            cbTableList.SelectedIndex = -1;
            foodTables = FoodTableLogic.GetTablesWithCookedTickets();
            foreach (FoodTableVM foodTable in foodTables)
            {
                cbTableList.Items.Add(foodTable);
            }
            cbTableList.DisplayMember = "Info";
        }
    }
}
