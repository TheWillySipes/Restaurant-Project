using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    
    public class HostStaff : Employee
    {
        public int CurrentCustomers { get; set; }
        TableStatus tableStatus = TableStatus.Open;

        int trackCustomers = 0;

        public void SeatCustomers(int customers)
        {

            //Application.Run(new HostForm());
            //int currentCustomers = HostForm.currentCustomers;
            int currentCustomers = customers;
            trackCustomers += currentCustomers;

            if(currentCustomers >= 4)
            {
                //large table
                MessageBox.Show("The customers will be seated at a large table.");
            }
            else if (currentCustomers >= 1 && currentCustomers <= 2)
            {
                //small table
                MessageBox.Show("The customers will be seated at a small table.");
            }
            if (tableStatus == TableStatus.Open)
            {
                DialogResult result1 = MessageBox.Show("This table is avaliable, seat customer here?", "Seat customer?", MessageBoxButtons.YesNoCancel);
                if(result1 == DialogResult.Yes)
                {
                    MessageBox.Show("This table will now be listed as occupied.");
                    tableStatus = TableStatus.Occupied;
                }
                else
                {
                    MessageBox.Show("Please choose a different table.");
                }
            }
            else if(tableStatus == TableStatus.Dirty)
            {
                MessageBox.Show("This table is waiting to be cleaned, please choose a different table");
            }
            else if(tableStatus == TableStatus.Occupied)
            {
                MessageBox.Show("Customers are currently sitting at this table, please choose a different table");
            }
        }
    }
}
