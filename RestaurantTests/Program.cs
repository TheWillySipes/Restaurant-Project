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
            var test = EmployeeVM.GetEmployees();
            if (test.Count > 0)
            {
                foreach (var e in test)
                {
                    Console.WriteLine("ID: " + e.ID);
                    Console.WriteLine("UserName: " + e.UserName);
                    Console.WriteLine("Firstname: " + e.FirstName);
                    Console.WriteLine("LastName: " + e.LastName);
                }
            }
        }
    }
}
