using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MenuItemData
    {
        /// <summary>
        /// Create new menu item
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        public static bool Create(MenuItem menuItem)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    context.MenuItems.Add(menuItem);
                    context.SaveChanges();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Get specific menu item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static MenuItem Read(int id)
        {
            MenuItem menuItem = null;
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    menuItem = context.MenuItems.Where(e => e.ID == id).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            return menuItem;
        }

        /// <summary>
        /// Get all menu items
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<MenuItem> Read()
        {
            List<MenuItem> menuItems = null;
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    menuItems = context.MenuItems.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            return menuItems;
        }

        /// <summary>
        /// Update a menu item
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        public static bool Update(MenuItem menuItem)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    context.MenuItems.Attach(menuItem);
                    context.Entry(menuItem).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Delete a menu item
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    var toDelete = context.MenuItems.Where(e => e.ID == id).FirstOrDefault();
                    context.MenuItems.Remove(toDelete);
                    context.Entry(toDelete).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
    }
}
