using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    /// <summary>
    /// MenuItem View Model Object
    /// </summary>
    public class MenuItemVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
        public bool Available { get; set; }
    }
}