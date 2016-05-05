using BusinessLayer.ViewModels;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
    public static class TicketsMenuItemLogic
    {
        /// <summary>
        /// Adds menu items to a ticket
        /// </summary>
        /// <param name="ticketId">Ticket id</param>
        /// <param name="menuItemIds">List of menu item's id's</param>
        public static void AddMenuItemsToTicket(int ticketId, List<MenuItemVM> menuItems)
        {
            foreach (MenuItemVM menuItem in menuItems)
            {
                TicketsMenuItemsData.Create(ticketId, menuItem.ID);
            }
        }

        public static List<TicketsMenuItemVM> GetTicketsMenuItems(int ticketId)
        {
            List<TicketsMenuItemVM> items = new List<TicketsMenuItemVM>();
            foreach(TicketsMenuItem ticketMenuItem in TicketsMenuItemsData.Get(ticketId))
            {
                items.Add(DataModelToVM(ticketMenuItem, MenuItemData.Read(ticketMenuItem.MenuItemID)));
            }
            return items;
        }


        private static TicketsMenuItem VMToDataModel(TicketsMenuItemVM ticketVM)
        {
            return new TicketsMenuItem()
            {
                TicketID = ticketVM.TicketID,
                MenuItemID = ticketVM.MenuItemID,
                PricePaid = ticketVM.PricePaid,
                Returned = ticketVM.Returned,
                ReturnReason = ticketVM.ReturnReason,
                ManagerComped = ticketVM.ManagerComped,
                CompedByUserID = ticketVM.CompedByUserID,
                ID = ticketVM.ID
            };
        }

        private static TicketsMenuItemVM DataModelToVM(TicketsMenuItem ticketsMenuItemDataModel, MenuItem menuItem)
        {
            return new TicketsMenuItemVM()
            {
                TicketID = ticketsMenuItemDataModel.TicketID,
                MenuItemID = ticketsMenuItemDataModel.MenuItemID,
                PricePaid = ticketsMenuItemDataModel.PricePaid,
                Returned = ticketsMenuItemDataModel.Returned,
                ReturnReason = ticketsMenuItemDataModel.ReturnReason,
                ManagerComped = ticketsMenuItemDataModel.ManagerComped,
                CompedByUserID = ticketsMenuItemDataModel.CompedByUserID,
                ID = ticketsMenuItemDataModel.ID,
                MenuItemTitle = menuItem.Title
            };
        }
    }
}
