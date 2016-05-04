using BusinessLayer.ViewModels;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
    public static class EmployeeLogic
    {
        /// <summary>
        /// Create a new employee
        /// </summary>
        /// <param name="username"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Create(string username, string firstname, string lastname, string password)
        {
            User newUser = new User();
            newUser.UserName = username;
            newUser.FirstName = firstname;
            newUser.LastName = lastname;
            newUser.Password = password;
            return UserData.Create(newUser);
        }

        /// <summary>
        /// Get list roles that a user is currently in
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public static List<Roles> GetUserRoles(int employeeId)
        {
            List<Roles> roles = new List<Roles>();
            foreach(UsersRole role in UserData.GetUserRoles(employeeId))
            {
                roles.Add((Roles)role.RoleID);
            }
            return roles;
        }

        /// <summary>
        /// Check to see if a user is in a role
        /// </summary>
        /// <param name="employee">EmployeeVM Object</param>
        /// <param name="role">Role to check</param>
        /// <returns></returns>
        public static bool IsInRole(int employeeId, Roles role)
        {
            return UserData.IsInRole(employeeId, (int)role);
        }

        /// <summary>
        /// Add a user to a role
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public static bool AddUserToRole(int employeeId, Roles role)
        {
            return UserData.AddUserToRole(employeeId, (int)role);
        }

        /// <summary>
        /// Remove user from role
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public static bool RemoveUserFromRoles(int employeeId, Roles role)
        {
            return UserData.RemoveUserFromRole(employeeId, (int)role);
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
        /// 
        /// </summary>
        /// <param name="employeeVM"></param>
        public static void UpdateEmployee(EmployeeVM employeeVM)
        {
            UserData.Update(VMToDataModel(employeeVM));
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
                LastName = employee.LastName,
                Password = employee.Password
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
                LastName = user.LastName,
                Password = user.Password
            };
        }

    }
}
