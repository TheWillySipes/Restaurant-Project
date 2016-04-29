using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public enum TableStatus
    {
        Open = 0,
        Occupied = 1,
        Dirty = 2
    }

    public enum Roles
    {
        Host = 1,
        WaitStaff = 2,
        Cook = 3,
        BusBoy = 4,
        Manager = 5
    }

    public enum Ticket
    {
        TicketOpen = 0,
        TicketClose = 1
    }

    public enum OrderStatus
    {
        //delivered to table
        Delivered = 0,
        //still being prepared
        NotDelivered = 1,
        //order received by CookStaff
        CooksReceived = 2,
        //order cooking complete, ready for delivery
        CooksComplete = 3
    }
}

