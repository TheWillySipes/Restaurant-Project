using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TicketData
    {
        public static int Create(int tableId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                Ticket newTicket = new Ticket();
                newTicket.TableID = tableId;
                newTicket.TimePlaced = DateTime.Now;
                context.Tickets.Add(newTicket);
                context.SaveChanges();
                return newTicket.ID;
            }
        }

        public static Ticket GetMostRecentTicket(int tableId, bool onlyOpenTickets)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Tickets.Where(e => e.ID == tableId).OrderByDescending(e => e.TimePlaced).FirstOrDefault();
            }
        }

        public static Ticket Read(int tableId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Tickets.Where(e => e.ID == tableId).FirstOrDefault();
            }
        }

        //public static bool AddMenuItemToTicket(int ticketId, List<MenuItem> menuItems)
        //{
        //    using(RestaurantApplicationEntities context = new RestaurantApplicationEntities())
        //    {
        //        foreach(MenuItem menuItem in menuItems)
        //        {
        //            TicketsMenuItem toAdd = new TicketsMenuItem();
        //            toAdd.
        //            context.TicketsMenuItems.Add()
        //        }
        //    }
        //}

    }
}
