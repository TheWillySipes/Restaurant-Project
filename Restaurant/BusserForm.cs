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
            FloorStatus floorstatus = new FloorStatus();
            floorstatus.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
