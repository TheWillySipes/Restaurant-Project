using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostStaff
{
    class Program
    {
        static void Main(string[] args)
        {

            FoodTable table = new FoodTable();
            table.AssignTable(TableStatus.Open);
            Console.ReadLine();

            
        }
    }
}
