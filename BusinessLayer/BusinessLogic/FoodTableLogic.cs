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
        /// Get all food tables
        /// </summary>
        /// <returns></returns>
        public static List<FoodTableVM> GetOpenTables()
        {
            List<FoodTableVM> tables = new List<FoodTableVM>();
            foreach(FoodTable foodTable in FoodTableData.Get())
            {
                if ((TableStatus)foodTable.Status == TableStatus.Open)
                {
                    tables.Add(DataModelToVM(foodTable));
                }
            }
            return tables;
        }

        /// <summary>
        /// Set a table to occupied (will allow if table is currently "Open")
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public static bool SetTableOccupied(int tableId)
        {
            var foodTable = FoodTableData.Get(tableId);
            if (foodTable == null)
                return false;
            if ((TableStatus)foodTable.Status == TableStatus.Open)
            {
                foodTable.Status = (int)TableStatus.Occupied;
                FoodTableData.Update(foodTable);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve tables that have a ticket open
        /// </summary>
        /// <returns></returns>
        public static List<FoodTableVM> GetTablesWithOpenTickets()
        {
            List<FoodTableVM> tables = new List<FoodTableVM>();
            foreach (FoodTable foodTable in FoodTableData.Get())
            {
                if ((TableStatus)foodTable.Status == TableStatus.Occupied)
                {
                    var openTicket = TicketLogic.GetOpenTicket(foodTable.ID);
                    if(openTicket != null)
                    {
                        tables.Add(DataModelToVM(foodTable));
                    }
                }
            }
            return tables;
        }

        /// <summary>
        /// Retrieve tables that are still waiting on cooks to finish
        /// </summary>
        /// <returns></returns>
        public static List<FoodTableVM> GetTablesWithUncookedTickets()
        {
            List<FoodTableVM> tables = new List<FoodTableVM>();
            foreach (FoodTable foodTable in FoodTableData.Get())
            {
                if ((TableStatus)foodTable.Status == TableStatus.Occupied)
                {
                    var openTicket = TicketLogic.GetOpenTicket(foodTable.ID);
                    if (openTicket != null && openTicket.TimeCompleted == null)
                    {
                        tables.Add(DataModelToVM(foodTable));
                    }
                }
            }
            return tables;
        }

        /// <summary>
        /// Retrieve tables that food has been cooked for
        /// </summary>
        /// <returns></returns>
        public static List<FoodTableVM> GetTablesWithCookedTickets()
        {
            List<FoodTableVM> tables = new List<FoodTableVM>();
            foreach (FoodTable foodTable in FoodTableData.Get())
            {
                if ((TableStatus)foodTable.Status == TableStatus.Occupied)
                {
                    var openTicket = TicketLogic.GetOpenTicket(foodTable.ID);
                    if (openTicket != null && openTicket.TimeCompleted != null)
                    {
                        tables.Add(DataModelToVM(foodTable));
                    }
                }
            }
            return tables;
        }

        /// <summary>
        /// Retrieve tables that do not have open tickets but are occupied
        /// </summary>
        /// <returns></returns>
        public static List<FoodTableVM> GetTablesWithoutOpenTickets()
        {
            List<FoodTableVM> tables = new List<FoodTableVM>();
            foreach (FoodTable foodTable in FoodTableData.Get())
            {
                if ((TableStatus)foodTable.Status == TableStatus.Occupied)
                {
                    var openTicket = TicketLogic.GetOpenTicket(foodTable.ID);
                    if (openTicket == null)
                    {
                        tables.Add(DataModelToVM(foodTable));
                    }
                }
            }
            return tables;
        }

        /// <summary>
        /// Retrieve dirty tables that need cleaning
        /// </summary>
        /// <returns></returns>
        public static List<FoodTableVM> GetDirtyTables()
        {
            List<FoodTableVM> tables = new List<FoodTableVM>();
            foreach (FoodTable foodTable in FoodTableData.Get())
            {
                if ((TableStatus)foodTable.Status == TableStatus.Dirty)
                {
                    tables.Add(DataModelToVM(foodTable));
                }
            }
            return tables;
        }

        /// <summary>
        /// Get currently occupied tables
        /// </summary>
        /// <returns></returns>
        public static List<FoodTableVM> GetOccupiedTables()
        {
            List<FoodTableVM> tables = new List<FoodTableVM>();
            foreach (FoodTable foodTable in FoodTableData.Get())
            {
                if ((TableStatus)foodTable.Status == TableStatus.Occupied)
                {
                    tables.Add(DataModelToVM(foodTable));
                }
            }
            return tables;
        }

        /// <summary>
        /// Set table back to open (Only allows if table status is currently "Dirty)
        /// </summary>
        /// <param name="tableId"></param>
        /// <returns></returns>
        public static bool SetTableOpen(int tableId)
        {
            var foodTable = FoodTableData.Get(tableId);
            if (foodTable == null)
                return false;
            if ((TableStatus)foodTable.Status == TableStatus.Dirty)
            {
                foodTable.Status = (int)TableStatus.Open;
                FoodTableData.Update(foodTable);
                return true;
            }
            return false;
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
