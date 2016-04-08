using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Ticket
    {
        public List<MenuItem> MenuItems { get; set; }

        public Ticket()
        {
            MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem item)
        {
            MenuItems.Add(item);
        }
    }
}
