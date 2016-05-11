using BusinessLayer.BusinessLogic;
using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestEmployees();
            //TestMenuItems();
            TestClockEmployeeInOut();
            Console.ReadKey();
        }

        static void  TestClockEmployeeInOut()
        {
            bool a = EmployeeTimeClockLogic.ClockIn(1);
            bool b = EmployeeTimeClockLogic.ClockIn(1);
            bool c = EmployeeTimeClockLogic.ClockOut(1);
            bool d = EmployeeTimeClockLogic.ClockOut(1);
        }

        static void TestEmployees()
        {
            Console.WriteLine("\n---Testing Employees---");
            List<EmployeeVM> employees = EmployeeLogic.Get();
            if (employees.Count > 0)
            {
                foreach (EmployeeVM employeeVM in employees)
                {
                    Console.WriteLine("ID: " + employeeVM.ID);
                    Console.WriteLine("UserName: " + employeeVM.UserName);
                    Console.WriteLine("Firstname: " + employeeVM.FirstName);
                    Console.WriteLine("LastName: " + employeeVM.LastName);
                }
            }

            EmployeeLogic.Create("BobJones", "Bob", "Jones", "password");
            var employee = EmployeeLogic.Get("BobJones");
            EmployeeLogic.AddUserToRole(employee.ID, BusinessLayer.Roles.Manager);
        }

        public static void TestMenuItems()
        {
            Console.WriteLine("\n---Testing FoodItems---");
            List<MenuItemVM> menuItems = MenuItemLogic.Get();
            if (menuItems.Count > 0)
            {
                foreach (MenuItemVM menuItem in menuItems)
                {
                    Console.WriteLine("ID: " + menuItem.ID);
                    Console.WriteLine("Title: " + menuItem.Title);
                    Console.WriteLine("Description: " + menuItem.Description);
                    Console.WriteLine("CurrentPrice: " + menuItem.CurrentPrice);
                    Console.WriteLine("Available: " + menuItem.Available);
                }
            }
            Console.WriteLine("\n---Updating Burger---");
            //Get burger out of list
            var burger = menuItems.Where(e => e.Title == "Hamburger").FirstOrDefault();
            //Set burgers new value
            burger.Available = false;
            //Update burger in database
            MenuItemLogic.Update(burger);
            //Read new burger passing burger's ID in
            var newBurger = MenuItemLogic.Get(burger.ID);
            //Write out new data
            Console.WriteLine("---Burger is now unavailable---");
            Console.WriteLine("ID: " + newBurger.ID);
            Console.WriteLine("Title: " + newBurger.Title);
            Console.WriteLine("Description: " + newBurger.Description);
            Console.WriteLine("CurrentPrice: " + newBurger.CurrentPrice);
            Console.WriteLine("Available: " + newBurger.Available);
            //Change burger back to available
            burger.Available = true;
            //Update burger in DB again
            MenuItemLogic.Update(burger);
            //Read burger from database again
            newBurger = MenuItemLogic.Get(burger.ID);
            //Write out data again
            Console.WriteLine("---Burger is now available---");
            Console.WriteLine("ID: " + newBurger.ID);
            Console.WriteLine("Title: " + newBurger.Title);
            Console.WriteLine("Description: " + newBurger.Description);
            Console.WriteLine("CurrentPrice: " + newBurger.CurrentPrice);
            Console.WriteLine("Available: " + newBurger.Available);

            //Delete burger
            MenuItemLogic.Delete(newBurger.ID);
            Console.WriteLine("---Burger deleted---");
            //Recreate burger
            MenuItemLogic.Create("Hamburger", "Darn good burnter", 5.25m, true);
            Console.WriteLine("---Burger created---");
        }
    }
}
