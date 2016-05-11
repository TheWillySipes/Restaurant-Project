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
        /// <summary>
        /// Create a new ticket for specified food table id
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get most recent ticket for a table
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public static Ticket Get(int tableId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Tickets.Where(e => e.ID == tableId).OrderByDescending(e => e.TimePlaced).FirstOrDefault();
            }
        }

        /// <summary>
        /// Get currently open ticket for a table
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public static Ticket GetOpenTicket(int tableId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Tickets.Where(e => e.TableID == tableId && e.TicketClosed == false).OrderByDescending(e => e.ID).FirstOrDefault();
            }
        }

        /// <summary>
        /// Update a ticket
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
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
