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
                List<FoodTableVM> tables = FoodTableLogic.Get();

        public CookStaffForm()
        {
            InitializeComponent();
            foreach (FoodTableVM table in tables)
            {
                comboBox1.Items.Add(table);

            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void completeButton_Click(object sender, EventArgs e)
        {

        }


    }
}
