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
        List<FoodTableVM> foodtables = FoodTableLogic.Get();  
        public BusserForm()
        {
            InitializeComponent();

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
            this.Close();
        }
    }
}
