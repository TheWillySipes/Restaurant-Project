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
        public CashOutForm()
        {
            InitializeComponent();
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
            //random number set to simulate transaction 
            Random rng = new Random();
            decimal total = rng.Next(0,100);
            Object selectedItem = cbTableList.SelectedItem;

            string output = "";
            output += " \n";
            output += "Total: $" + total;
            MessageBox.Show(selectedItem.ToString() + output);

            waitStaff.Show();
            this.Hide();
        }
    }
}
