using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    class FoodTable
    {
        //Primary Key in Database
        public int FoodTableId { get; set; }
        //Table Status (Enum)
        public TableStatus TableStatus { get; set; }

        /// <summary>
        /// Set ticket Status
        /// </summary>
        /// <param name="status"></param>

        public Ticket Ticket { get; set; }

        /// <summary>
        /// Set Table Status
        /// </summary>
        /// <param name="status"></param>
        public void AssignTable(TableStatus status)
        {
            TableStatus = status;
        }

        //Get table status
        public TableStatus GetTableStatus()
        {
            if (TableStatus == TableStatus.Open)
            {
                Console.WriteLine("Table is available");
            }
            else if (TableStatus == TableStatus.Occupied)
            {
                Console.WriteLine("Table is occupied");
            }
            else if (TableStatus == TableStatus.Dirty)
            {
                Console.WriteLine("Table is dirty");
            }
            return TableStatus;
        }

        //Get Ticket status
        public void TicketStatus(Ticket status)
        {
            Ticket = status;
        }

        public Ticket GetTicketStatus()
        {
            if (Ticket == Ticket.TicketOpen)
            {
                Console.WriteLine("The ticket is open");
            }
            else if (Ticket == Ticket.TicketClose)
            {
                Console.WriteLine("The ticket is closed");
            }
           
            return Ticket;
        }
    }
}
