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
        TableStatus tableStatus = TableStatus.Open;

        public void SeatCustomers()
        {
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

        enum TableStatus
        {
            Open = 0,
            Occupied = 1,
            Dirty = 2
        }
    }
}
