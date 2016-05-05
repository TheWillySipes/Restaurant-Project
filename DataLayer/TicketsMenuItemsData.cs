using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TicketsMenuItemsData
    {
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

        public static List<TicketsMenuItem> GetAllTicketMenuItems(int ticketId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.TicketsMenuItems.Where(e => e.TicketID == ticketId).ToList();
            }
        }

        public static List<TicketsMenuItem> Get(int ticketId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.TicketsMenuItems.Where(e => e.TicketID == ticketId).ToList();
            }
        }
    }
}
