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
        WaitStaffForm waitStaff = new WaitStaffForm();
        List<FoodTableVM> foodTables = FoodTableLogic.Get();
        public OrderStatusForm()
        {
            InitializeComponent();

            foreach(FoodTableVM foodTable in foodTables)
            {
                cmboFoodTable.Items.Add(foodTable);
            }
            cmboFoodTable.DisplayMember = "Info";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            waitStaff.checkclockin = true;
            waitStaff.Show();
            this.Hide();
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            //cmboFoodTables.SelectedItem as FoodTableVM
            //TicketLogic.Read();

            //Another random number generated to simulate order status 

            Random rng = new Random();
            int number = rng.Next(0, 100);
            string statusString = "";

            if (number >= 50)
            {
                statusString = "*IN PROGRESS*";
                
            }
            else
            {
                statusString = "DELIVERED!";
            }


            string output = "";
            Object selectedItem = cmboFoodTable.SelectedItem;

            output += "Order : " + statusString + "\n";
            output += "Entered: " + (DateTime.Now); // need to figure out how to tweak this

            MessageBox.Show(output);
        }
    }
}
