using BusinessLayer.ViewModels;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
    public static class TicketLogic
    {
        /// <summary>
        /// Get ticket for a specific table
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="onlyShowOpenTickets"></param>
        /// <returns></returns>
        public static TicketVM Get(int tableId)
        {
            DataLayer.Ticket ticket = TicketData.Get(tableId);
            if(ticket != null)
            {
                return DataModelToVM(ticket);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get ticket total
        /// </summary>
        /// <param name="ticketId"></param>
        /// <returns></returns>
        public static decimal GetTicketTotal(int ticketId)
        {
            List<TicketsMenuItem> ticketsMenuItems = TicketsMenuItemsData.GetAllTicketMenuItems(ticketId);
            decimal total = 0m;
            foreach(TicketsMenuItem menuItem in ticketsMenuItems)
            {
                total += menuItem.PricePaid;
            }
            return total;
        }

        /// <summary>
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public static bool TicketIsCooked(int tableId)
        {
            DataLayer.Ticket ticket = TicketData.Get(tableId);
            if(ticket == null)
            {
                return false;
            }
            else
            {
                if(ticket.TicketClosed == true || ticket.TimeCompleted != null)
                {
                    return false;
                }
                else
                {
                    ticket.TimeCompleted = DateTime.Now;
                    TicketData.Update(ticket);
                    return true;
                }
            }
        }

        /// <summary>
        /// If ticket is not already closed, close ticket
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public static bool CloseTableTicket(int tableId)
        {
            DataLayer.Ticket ticket = TicketData.Get(tableId);
            if(ticket.TimeCompleted == null)
            {
                ticket.TimeCompleted = DateTime.Now;
                return TicketData.Update(ticket);
            }
            return false;
        }

        /// <summary>
        /// Create a new ticket for a table
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns>Returns false if there is already an open ticket for a table</returns>
        public static bool Create(int tableId)
        {
            DataLayer.Ticket ticket = TicketData.Get(tableId);
            if(ticket.TimeCompleted != null)
            {
                return TicketData.Create(tableId);
            }
            return false;
        }

        private static DataLayer.Ticket VMToDataModel(TicketVM ticketVM)
        {
            return new DataLayer.Ticket()
            {
                ID = ticketVM.ID,
                TableID = ticketVM.TableID,
                TimePlaced = ticketVM.TimePlaced,
                TimeCompleted = ticketVM.TimeCompleted,
                TicketClosed = ticketVM.TicketClosed
            };
        }

        private static TicketVM DataModelToVM(DataLayer.Ticket ticketDataModel)
        {
            return new TicketVM()
            {
                ID = ticketDataModel.ID,
                TableID = ticketDataModel.TableID,
                TimePlaced = ticketDataModel.TimePlaced,
                TimeCompleted = ticketDataModel.TimeCompleted,
                TicketClosed = ticketDataModel.TicketClosed
            };
        }
    }
}
