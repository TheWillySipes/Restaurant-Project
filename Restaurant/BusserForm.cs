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
    public partial class BusserForm : Form
    {
        List<FoodTableVM> foodtables; 
        public BusserForm()
        {
            InitializeComponent();
            RefreshComboBox();
        }

        private void btnFloorStatus_Click(object sender, EventArgs e)
        {
            FloorStatus floorstatus = new FloorStatus(new BusserForm());
            floorstatus.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeActionSelector actionSelector = new EmployeeActionSelector();
            actionSelector.Show();
            this.Hide();
        }

        public void RefreshComboBox()
        {
            comboBox1.Items.Clear();
            foodtables = FoodTableLogic.GetDirtyTables();
            foreach (FoodTableVM table in foodtables)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table.");
                RefreshComboBox();
                return;
            }
            FoodTableVM foodTable = comboBox1.SelectedItem as FoodTableVM;
            if(FoodTableLogic.SetTableOpen(foodTable.ID))
            {
                MessageBox.Show("Thanks for cleaning!");
            }else
            {
                MessageBox.Show("Unable to change table status, notify IT");
            }
            RefreshComboBox();
        }
    }
}
