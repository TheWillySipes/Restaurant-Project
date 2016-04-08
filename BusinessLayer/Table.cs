using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Table
    {
        public List<Ticket> Tickets { get; set; }

        public Table()
        {
            Tickets = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}
