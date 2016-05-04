using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class FoodTableData
    {
        public static List<FoodTable> Get()
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.FoodTables.ToList();
            }
        }

        public static FoodTable Get(int tableId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.FoodTables.Where(e => e.ID == tableId).FirstOrDefault();
            }
        }

    }
}
