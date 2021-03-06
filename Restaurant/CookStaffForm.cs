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
    public partial class CookStaffForm : Form
    {
        List<FoodTableVM> tables;

        public CookStaffForm()
        {
            InitializeComponent();
            RefreshComboBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeActionSelector actionSelector = new EmployeeActionSelector();
            actionSelector.Show();
            this.Hide();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table");
                return;
            }
            FoodTableVM foodTable = comboBox1.SelectedItem as FoodTableVM;
            if(TicketLogic.TicketIsCooked(foodTable.ID))
            {
                MessageBox.Show("Wait staff will now see order is complete.");
            }
            else
            {
                MessageBox.Show("Unable to mark ticket as completed.");
            }
            RefreshComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

           FoodTableVM foodTable = comboBox1.SelectedItem as FoodTableVM;
            if (foodTable !=  null)
            {
                TicketVM ticket = TicketLogic.GetOpenTicket(foodTable.ID);
                if (ticket == null)
                {
                    return;
                }

                List<TicketsMenuItemVM> items = TicketsMenuItemLogic.GetTicketsMenuItems(ticket.ID);
                foreach (var item in items)
                {
                    listBox1.Items.Add(item);
                }
                listBox1.DisplayMember = "MenuItemTitle";
            }
            else
            {
                MessageBox.Show("No ticket for this table!");
            }

        }

        public void RefreshComboBox()
        {
            comboBox1.Items.Clear();
            listBox1.Items.Clear();
            tables = FoodTableLogic.GetTablesWithUncookedTickets();
            foreach (FoodTableVM table in tables)
            {
                comboBox1.Items.Add(table);
            }
            comboBox1.DisplayMember = "Info";

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
