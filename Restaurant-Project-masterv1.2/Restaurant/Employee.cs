using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    //Abstract class to be used by more specific classes
    public abstract class Employee
    {
        //Properties that describe employees
        public int EmployeeID { get; set; }
        public string EmployeePassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
