﻿using BusinessLayer.BusinessLogic;
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

        List<FoodTableVM> foodTables;
        public CashOutForm()
        {
            InitializeComponent();
            UpdateDropDown();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WaitStaffForm waitStaff = new WaitStaffForm();
            waitStaff.Show();
            this.Hide();
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            if(cbTableList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table");
                UpdateDropDown();
                return;
            }
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
                    output += "\n" + item.MenuItemTitle + " $" + item.PricePaid;
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
