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
    public partial class CookStaffForm : Form
    {
        List<FoodTableVM> tables = FoodTableLogic.GetTablesWithUncookedTickets();

        public CookStaffForm()
        {
            InitializeComponent();
            foreach (FoodTableVM table in tables)
            {
                comboBox1.Items.Add(table);
            }
            comboBox1.DisplayMember = "Info";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeActionSelector actionSelector = new EmployeeActionSelector();
            actionSelector.Show();
            this.Close();
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
                MessageBox.Show("Cooks will be notified!");
            }
            else
            {
                MessageBox.Show("Unable to mark ticket as completed.");
            }
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
