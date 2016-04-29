using BusinessLayer.ViewModels;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
    public class EmployeeLogic
    {
        public static bool IsInRole(EmployeeVM employee, Roles role)
        {
            return DataAccessObject.Instance.IsInRole(employee.ID, (int)role);
        }

        public static List<EmployeeVM> GetEmployees()
        {
            return EmployeesToVM(DataAccessObject.Instance.GetEmployees());
        }

        public static bool AuthenticateEmployee(int employeeId, string password)
        {
            return DataAccessObject.Instance.AuthenticateEmployee(employeeId, password);
        }

        public static bool AuthenticateEmployee(string employeeUserName, string password)
        {
            return DataAccessObject.Instance.AuthenticateEmployee(employeeUserName, password);
        }

        public static EmployeeVM GetEmployee(string employeeUserName)
        {
            var employee = DataAccessObject.Instance.GetEmployee(employeeUserName);
            return VMToDataModel(employee);
        }

        public static void UpdateEmployee(EmployeeVM employee)
        {
            DataAccessObject.Instance.UpdateEmployee(VMToDataModel(employee));
        }

        private static User VMToDataModel(EmployeeVM employee)
        {
            return new User()
            {
                ID = employee.ID,
                UserName = employee.UserName,
                FirstName = employee.FirstName,
                LastName = employee.LastName
            };
        }

        private static EmployeeVM VMToDataModel(User user)
        {
            return new EmployeeVM()
            {
                ID = user.ID,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }


        private static List<EmployeeVM> EmployeesToVM(List<User> users)
        {
            List<EmployeeVM> returndata = new List<EmployeeVM>();
            foreach (User u in users)
            {
                returndata.Add(new EmployeeVM
                {
                    ID = u.ID,
                    UserName = u.UserName,
                    FirstName = u.FirstName,
                    LastName = u.LastName
                });
            }
            return returndata;
        }
    }
}
