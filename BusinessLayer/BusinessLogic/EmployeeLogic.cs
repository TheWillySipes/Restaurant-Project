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
        public static bool Create(EmployeeVM employee)
        {
            return UserData.Create(VMToDataModel(employee));
        }

        /// <summary>
        /// Check to see if a user is in a role
        /// </summary>
        /// <param name="employee">EmployeeVM Object</param>
        /// <param name="role">Role to check</param>
        /// <returns></returns>
        public static bool IsInRole(EmployeeVM employee, Roles role)
        {
            return UserData.IsInRole(employee.ID, (int)role);
        }

        /// <summary>
        /// Get all employees
        /// </summary>
        /// <returns></returns>
        public static List<EmployeeVM> GetEmployees()
        {
            List<EmployeeVM> employees = new List<EmployeeVM>();
            foreach(User u in UserData.Read())
            {
                employees.Add(DataModelToVM(u));
            }
            return employees;
        }

        /// <summary>
        /// Authenticate employee based on employee id (true - authentication successful, false - invalid credentials)
        /// </summary>
        /// <param name="employeeId">Employee's ID</param>
        /// <param name="password">Employee's Pssword</param>
        /// <returns></returns>
        public static bool AuthenticateEmployee(int employeeId, string password)
        {
            return UserData.AuthenticateEmployee(employeeId, password);
        }

        /// <summary>
        /// Authenticate employee based on username
        /// </summary>
        /// <param name="employeeUserName">Employee's username</param>
        /// <param name="password">Employee's password</param>
        /// <returns></returns>
        public static bool AuthenticateEmployee(string employeeUserName, string password)
        {
            return UserData.AuthenticateEmployee(employeeUserName, password);
        }

        /// <summary>
        /// Get specific employee
        /// </summary>
        /// <param name="employeeUserName">Employee's username</param>
        /// <returns></returns>
        public static EmployeeVM GetEmployee(string employeeUserName)
        {
            var employee = UserData.Read(employeeUserName);
            return DataModelToVM(employee);
        }

        /// <summary>
        /// Update employee's information
        /// </summary>
        /// <param name="employee"></param>
        public static void UpdateEmployee(EmployeeVM employee)
        {
            UserData.Update(VMToDataModel(employee));
        }

        /// <summary>
        /// Private employee helper (change view model to user data model object)
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Private employee helper (change user data object to employee view model object)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private static EmployeeVM DataModelToVM(User user)
        {
            return new EmployeeVM()
            {
                ID = user.ID,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }

    }
}
