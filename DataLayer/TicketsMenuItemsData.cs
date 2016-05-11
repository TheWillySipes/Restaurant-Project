using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TicketsMenuItemsData
    {
        /// <summary>
        /// Create a new TicketsMenuItem record (Adds a menu item to an existing ticket)
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="menuItemId"></param>
        /// <returns></returns>
        public static bool Create(int ticketId, int menuItemId)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    MenuItem menuItem = context.MenuItems.Where(e => e.ID == menuItemId).FirstOrDefault();
                    TicketsMenuItem addMenuItemToTicket = new TicketsMenuItem();
                    addMenuItemToTicket.ManagerComped = false;
                    addMenuItemToTicket.MenuItemID = menuItemId;
                    addMenuItemToTicket.PricePaid = menuItem.CurrentPrice;
                    addMenuItemToTicket.Returned = false;
                    addMenuItemToTicket.TicketID = ticketId;
                    addMenuItemToTicket.ReturnReason = "";
                    context.TicketsMenuItems.Add(addMenuItemToTicket);
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
        /// Get all menu items on a ticket
        /// </summary>
        /// <param name="ticketId"></param>
        /// <returns></returns>
        public static List<TicketsMenuItem> GetAllTicketMenuItems(int ticketId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.TicketsMenuItems.Where(e => e.TicketID == ticketId).ToList();
            }
        }

    }
}
