using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ViewModels
{
    /// <summary>
    /// FoodTable View Model
    /// </summary>
    public class FoodTableVM
    {
        public int ID { get; set; }
        public TableStatus Status { get; set; }
        public string Info { get; set; }
    }
}
