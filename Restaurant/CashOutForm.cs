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
        List<FoodTableVM> foodTables = FoodTableLogic.Get();
        public CashOutForm()
        {
            InitializeComponent();
            foreach (FoodTableVM foodTable in foodTables)
            {
                cbTableList.Items.Add(foodTable);
            }
            cbTableList.DisplayMember = "Info";
        }

        private void btnPrev_Click(object sender, EventArgs e)
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
                TicketVM ticket = TicketLogic.Get(foodTable.ID);
                if (ticket == null)
                {
                    return;
                }

                List<TicketsMenuItemVM> items = TicketsMenuItemLogic.GetTicketsMenuItems(ticket.ID);
                foreach (var item in items)
                {

                }
                cbTableList.DisplayMember = "MenuItemTitle";
            }
            else
            {
                MessageBox.Show("No ticket for this table!");
            }
            
            this.Hide();
        }
    }
}
