using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static bool Update(FoodTable foodTable)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    context.FoodTables.Attach(foodTable);
                    context.Entry(foodTable).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
        }

    }
}
