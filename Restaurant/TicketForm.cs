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
    public partial class TicketForm : Form
    {
        List<FoodTableVM> tables = FoodTableLogic.Get();
        List<MenuItemVM> menuItems = MenuItemLogic.Read();

        public TicketForm()
        {
            InitializeComponent();
            foreach(FoodTableVM table in tables)
            {
                cmboFoodTables.Items.Add(table);
            }
            foreach(MenuItemVM menuItem in menuItems)
            {
                cmboMenuItems.Items.Add(menuItem);
            }

            cmboFoodTables.DisplayMember = "Info";
            cmboFoodTables.ValueMember = "ID";

            cmboMenuItems.DisplayMember = "Title";
            cmboMenuItems.ValueMember = "ID";

            listBoxMenuItems.DisplayMember = "Title";
            listBoxMenuItems.ValueMember = "ID";
        }

        private void btnRemoveSingleItem_Click(object sender, EventArgs e)
        {
            //Removing a single item from the tickets
            listBoxMenuItems.Items.Remove(listBoxMenuItems.SelectedItem);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //Removing all items from the ticket
            listBoxMenuItems.Items.Clear();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //TODO: Add logic to send order to business logic
            //Creating ticket to be sent to cooks
            MessageBox.Show("SENT TO COOKS");
            //int ticketId = TicketLogic.Create((int)cmboFoodTables.SelectedValue);
            //foreach(var item in listBoxMenuItems.Items.Cast<TicketsMenuItemVM>)
            //{

            //}
            //TicketsMenuItemLogic.AddMenuItemsToTicket()
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            WaitStaffForm waitForm = new WaitStaffForm();
            waitForm.checkclockin = true;
            waitForm.Show();
        }

        private void cmboFoodTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox2.Items.Clear();
            //TicketVM ticket = TicketLogic.Read(tables[cmboFoodTables.SelectedIndex].ID);
            //List<TicketsMenuItemVM> ticketsMenuItems = TicketsMenuItemLogic.GetTicketsMenuItems(ticket.ID);
            //foreach(TicketsMenuItemVM item in ticketsMenuItems)
            //{
            //    listBox2.Items.Add(item.MenuItemTitle);
            //}
            listBoxMenuItems.Items.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            listBoxMenuItems.Items.Add(menuItems[cmboMenuItems.SelectedIndex]);
        }

    }
}
