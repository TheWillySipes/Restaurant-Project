using BusinessLayer.ViewModels;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
    /// <summary>
    /// All main MenuItem logic lives here
    /// </summary>
    public static class MenuItemLogic
    {
        /// <summary>
        /// Get all menu items
        /// </summary>
        /// <returns></returns>
        public static List<MenuItemVM> Get()
        {
            List<MenuItemVM> menuItems = new List<MenuItemVM>();
            foreach(MenuItem menuItem in MenuItemData.Read())
            {
                menuItems.Add(DataModelToVM(menuItem));
            }
            return menuItems;
        }

        /// <summary>
        /// Get one menu item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static MenuItemVM Get(int id)
        {
            return DataModelToVM(MenuItemData.Get(id));
        }

        /// <summary>
        /// Update a menu item
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        public static bool Update(MenuItemVM menuItem)
        {
            return MenuItemData.Update(VMToDataModel(menuItem));
        }
        
        /// <summary>
        /// Delete a menu item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            return MenuItemData.Delete(id);
        }

        /// <summary>
        /// Create new menu item
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        public static bool Create(string title, string description,  decimal currentPrice, bool available)
        {
            return MenuItemData.Create(title, description,  currentPrice, available);
        }
        
        /// <summary>
        /// private helper
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        private static MenuItem VMToDataModel(MenuItemVM menuItem)
        {
            return new MenuItem()
            {
                ID = menuItem.ID,
                Title = menuItem.Title,
                Description = menuItem.Description,
                CurrentPrice = menuItem.CurrentPrice,
                Available = menuItem.Available
            };
        }

        /// <summary>
        /// private helper
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns></returns>
        private static MenuItemVM DataModelToVM(MenuItem menuItem)
        {
            return new MenuItemVM()
            {
                ID = menuItem.ID,
                Title = menuItem.Title,
                Description = menuItem.Description,
                CurrentPrice = menuItem.CurrentPrice,
                Available = menuItem.Available
            };
        }
    }
}
