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
            if(FoodTableLogic.SetTableOccupied(selectedTable.ID))
            {
                MessageBox.Show("Table Assigned");
                HostForm2 actionSelector = new HostForm2();
                actionSelector.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Table was not assigned.");
                return;
            }
            RefreshDD();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeActionSelector actionSelector = new EmployeeActionSelector();
            actionSelector.Show();
            this.Hide();
        }
        private void RefreshDD()
        {
            //referesh list
            comboBox1.Items.Clear();
            tables = FoodTableLogic.GetOpenTables();
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
