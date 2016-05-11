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
    public partial class HostForm : Form
    {
        public static int currentCustomers { get; set; }
        List<FoodTableVM> tables = FoodTableLogic.GetOpenTables();
        public HostForm()
        {
            InitializeComponent();
            RefreshDD();


          
        }
        HostStaff hostStaff = new HostStaff();
        
        private void submitCustomers_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table...");
                return;
            }
            //Get FoodTableVM object from the combo box's selected item
            FoodTableVM selectedTable = comboBox1.SelectedItem as FoodTableVM;
            //Create a new ticket with the table's ID (returns a ticket ID of the item created)
            TicketVM newTicket = null;
            if(FoodTableLogic.SetTableOccupied(selectedTable.ID))
            {
                MessageBox.Show("Table Assigned");
                EmployeeActionSelector actionSelector = new EmployeeActionSelector();
                actionSelector.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Table was not assigned.");
                return;
            }
            RefreshDD();
            //refresh drop down
            
            
            
            
            
            
            /////old code, replaced by Willy
        //    string customersRaw = customerNumber.Text;
        //    int currentCustomers = 0;
//            currentCustomers = int.Parse(customerNumber.Text);

            //if (int.TryParse(customersRaw, out currentCustomers))
            //{
            //    //Parse Successful
            //    hostStaff.SeatCustomers(currentCustomers);
            //}
            //else
            //{
            //    //Parse Unsuccessful
            //}
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeActionSelector actionSelector = new EmployeeActionSelector();
            actionSelector.Show();
            this.Close();
        }
        private void RefreshDD()
        {
            //referesh list
            tables = FoodTableLogic.GetOpenTables();
            foreach (FoodTableVM table in tables)
            {

                comboBox1.Items.Add(table);
            }
            comboBox1.DisplayMember = "Info";

        }
    }
}
