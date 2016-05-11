using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    /// <summary>
    /// Ticket View Model
    /// </summary>
    public class TicketVM
    {
        public int ID { get; set; }
        public int TableID { get; set; }
        public System.DateTime TimePlaced { get; set; }
        public Nullable<System.DateTime> TimeCompleted { get; set; }
        public bool TicketClosed { get; set; }
    }
}
