using BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class GlobalData
    {
        private static GlobalData instance;
        private GlobalData() { }
        public EmployeeVM Employee { get; private set; }

        public static GlobalData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GlobalData();
                }
                return instance;
            }
        }

        public void SetLoggedInEmployee(EmployeeVM employee)
        {
            Employee = employee;
        }

    }
}
