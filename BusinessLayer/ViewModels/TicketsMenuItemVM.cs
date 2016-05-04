using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    public class TicketsMenuItemVM
    {
        public int TicketID { get; set; }
        public int MenuItemID { get; set; }
        public string MenuItemTitle { get; set; }
        public decimal PricePaid { get; set; }
        public bool Returned { get; set; }
        public string ReturnReason { get; set; }
        public bool ManagerComped { get; set; }
        public Nullable<int> CompedByUserID { get; set; }
        public int ID { get; set; }
    }
}
