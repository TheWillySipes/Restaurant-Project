using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TicketData
    {
        public static bool Create(int tableId)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    Ticket newTicket = new Ticket();
                    newTicket.TableID = tableId;
                    newTicket.TimePlaced = DateTime.Now;
                    context.Tickets.Add(newTicket);
                    context.SaveChanges();
                    return true;
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public static Ticket Get(int tableId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Tickets.Where(e => e.ID == tableId).OrderByDescending(e => e.TimePlaced).FirstOrDefault();
            }
        }

        public static bool Update(Ticket ticket)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    context.Tickets.Attach(ticket);
                    context.Entry(ticket).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }catch(Exception)
            {
                return false;
            }
        }

    }
}
