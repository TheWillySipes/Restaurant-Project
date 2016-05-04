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
        /// Get tickets for a specific table
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="onlyShowOpenTickets"></param>
        /// <returns></returns>
        public static List<TicketVM> Read(int tableId, bool onlyShowOpenTickets)
        {
            List<TicketVM> tickets = new List<TicketVM>();
            foreach (DataLayer.Ticket ticket in TicketData.Read(tableId, onlyShowOpenTickets))
            {
                tickets.Add(DataModelToVM(ticket));
            }
            return tickets;
        }

        /// <summary>
        /// Get tickets for a specific table
        /// </summary>
        /// <param name="tableId"></param>
        /// <param name="onlyShowOpenTickets"></param>
        /// <returns></returns>
        public static TicketVM Read(int tableId)
        {
            return DataModelToVM(TicketData.Read(tableId));
        }

        /// <summary>
        /// Create a new ticket for a table
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns>Returns ticket ID</returns>
        public static int Create(int tableId)
        {
            return TicketData.Create(tableId);
        }

        private static DataLayer.Ticket VMToDataModel(TicketVM ticketVM)
        {
            return new DataLayer.Ticket()
            {
                ID = ticketVM.ID,
                TableID = ticketVM.TableID,
                TimePlaced = ticketVM.TimePlaced,
                TimeCompleted = ticketVM.TimeCompleted
            };
        }

        private static TicketVM DataModelToVM(DataLayer.Ticket ticketDataModel)
        {
            return new TicketVM()
            {
                ID = ticketDataModel.ID,
                TableID = ticketDataModel.TableID,
                TimePlaced = ticketDataModel.TimePlaced,
                TimeCompleted = ticketDataModel.TimeCompleted
            };
        }
    }
}
