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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();

        }
        //remove with database
        
        public string ticket { get; set; }
        public string ticketA = "";
        List<string> tickets = new List<string>();
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Adding items to the ticket
            listBox2.Items.Add(listBox1.SelectedItem);
        }

        private void btnRemoveSingleItem_Click(object sender, EventArgs e)
        {
            //Removing a single item from the tickets
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //Removing all items from the ticket
            listBox2.Items.Clear();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //Creating ticket to be sent to cooks
            ticketA = listBox2.Text.ToString();
            MessageBox.Show(ticketA+" \n SENT TO COOKS");

            //send to database instead of list
            ticket.Add(ticketA);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            WaitStaffForm waitForm = new WaitStaffForm();
            waitForm.checkclockin = true;
            waitForm.Show();
        }
    }
}
