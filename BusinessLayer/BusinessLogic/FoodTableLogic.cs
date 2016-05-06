using BusinessLayer.ViewModels;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
    public static class FoodTableLogic
    {
        /// <summary>
        /// Get all food tables
        /// </summary>
        /// <returns></returns>
        public static List<FoodTableVM> Get()
        {
            List<FoodTableVM> tables = new List<FoodTableVM>();
            foreach(FoodTable foodTable in FoodTableData.Get())
            {
                tables.Add(DataModelToVM(foodTable));
            }
            return tables;
        }


        /// <summary>
        /// Private employee helper (change view model to user data model object)
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        private static FoodTable VMToDataModel(FoodTableVM foodTable)
        {
            return new FoodTable()
            {
                ID = foodTable.ID,
                Info = foodTable.Info,
                Status = (int)foodTable.Status
            };
        }

        /// <summary>
        /// Private employee helper (change user data object to employee view model object)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private static FoodTableVM DataModelToVM(FoodTable foodTable)
        {
            return new FoodTableVM()
            {
                ID = foodTable.ID,
                Info = foodTable.Info,
                Status = (TableStatus)foodTable.Status
            };
        }
    }
}
