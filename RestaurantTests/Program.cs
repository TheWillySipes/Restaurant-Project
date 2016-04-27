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
            TestBusinessLayer();
            Console.ReadKey();
        }

        static void TestBusinessLayer()
        {
            List<EmployeeVM> test = EmployeeLogic.GetEmployees();
            if (test.Count > 0)
            {
                foreach (EmployeeVM employeeVM in test)
                {
                    Console.WriteLine("ID: " + employeeVM.ID);
                    Console.WriteLine("UserName: " + employeeVM.UserName);
                    Console.WriteLine("Firstname: " + employeeVM.FirstName);
                    Console.WriteLine("LastName: " + employeeVM.LastName);
                }
            }
        }
    }
}
