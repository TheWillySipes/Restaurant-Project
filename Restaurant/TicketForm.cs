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
        //Get list of food tables from database
        List<FoodTableVM> tables;
        //Get list of menu items from database
        List<MenuItemVM> menuItems = MenuItemLogic.Get();

        public TicketForm()
        {
            InitializeComponent();
            refreshTables();

            //populate menu items combo box with menuItems initialized above
            foreach(MenuItemVM menuItem in menuItems)
            {
                cmboMenuItems.Items.Add(menuItem);
            }

            //same idea as line above
            cmboMenuItems.DisplayMember = "Title";
            listBoxMenuItems.DisplayMember = "Title";
        }

        private void btnRemoveSingleItem_Click(object sender, EventArgs e)
        {
            //Removing a single item from the tickets
            listBoxMenuItems.Items.Remove(listBoxMenuItems.SelectedItem);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if(listBoxMenuItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a menu item...");
                return;
            }
            //Removing all items from the ticket
            listBoxMenuItems.Items.Clear();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            ///Return and show message if no food items were selected
            if (listBoxMenuItems.Items.Count < 1)
            {
                MessageBox.Show("Please add menu items to the order");
                return;
            }
            //Return and show message if a food table is not selected from combo box
            if(cmboFoodTables.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table");
                return;
            }
            //Get FoodTableVM object from the combo box's selected item
            FoodTableVM selectedTable = cmboFoodTables.SelectedItem as FoodTableVM;
            //Create a new ticket with the table's ID (returns a ticket ID of the item created)
            TicketVM newTicket = null;
            if(TicketLogic.Create(selectedTable.ID))
            {
                newTicket = TicketLogic.GetOpenTicket(selectedTable.ID);
            }
            else
            {
                MessageBox.Show("Unable to create ticket, there may already be an existing ticket. Please close out any existing tickets for this table.");
                refreshTables();
                return;
            }
            //Get list of menu items selected from the list box ( .OfType casts the MenuItemVM back
            //  to a MenuItemVM object type
            List<MenuItemVM> menuItems = listBoxMenuItems.Items.OfType<MenuItemVM>().ToList();
            //Add menu items to the newly created ticket providing the ticket ID and the selected menu items
            TicketsMenuItemLogic.AddMenuItemsToTicket(newTicket.ID, menuItems);
            //Clear out the listbox to create a second order if needed
            listBoxMenuItems.Items.Clear();
            refreshTables();
            MessageBox.Show("Order sent to cooks");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WaitStaffForm waitForm = new WaitStaffForm();
            waitForm.Show();
            this.Hide();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Add selected item object to list box
            if (cmboMenuItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a menu item");
                return;
            }
            listBoxMenuItems.Items.Add(cmboMenuItems.SelectedItem);
        }


        private void refreshTables()
        {
            cmboFoodTables.Items.Clear();
            tables = FoodTableLogic.GetTablesWithoutOpenTickets();
            //populate food table combo box with tables initialized above
            foreach (FoodTableVM table in tables)
            {
                cmboFoodTables.Items.Add(table);
            }
            //Set display member of FoodTableVM's Info property (see FoodTableVM class)
            cmboFoodTables.DisplayMember = "Info";
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
