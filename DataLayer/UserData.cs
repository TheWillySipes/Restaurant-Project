using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    /// <summary>
    /// Data access for Users
    /// </summary>
    public class UserData
    {
        /// <summary>
        /// Add user to a new role
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public static bool AddUserToRole(int employeeId, int role)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var usersRoles = context.UsersRoles.Where(e => e.UserID == employeeId && e.RoleID == role).FirstOrDefault();
                if (usersRoles == null)
                {
                    var userRole = new UsersRole(){UserID = employeeId, RoleID = role};
                    context.UsersRoles.Add(userRole);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Remove a user from a role
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public static bool RemoveUserFromRole(int employeeId, int role)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var toDelete = context.UsersRoles.Where(e => e.UserID == employeeId && e.RoleID == role).FirstOrDefault();
                if (toDelete != null)
                {
                    context.UsersRoles.Remove(toDelete);
                    context.Entry(toDelete).State = EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Get all roles a user is in
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public static List<UsersRole> GetUserRoles(int employeeId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var roles = context.UsersRoles.Where(e => e.UserID == employeeId).ToList();
                return roles;
            }
        }

        /// <summary>
        /// See if a user is in a specific role
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public static bool IsInRole(int employeeId, int role)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var usersRoles = context.UsersRoles.Where(e => e.UserID == employeeId && e.RoleID == role).FirstOrDefault();
                if (usersRoles == null)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Authenticate user with userId and password
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool AuthenticateEmployee(int userId, string password)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var user = context.Users.Where(e => e.ID == userId && e.Password == password).FirstOrDefault();
                if (user == null)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Authenticate user with username and password
        /// </summary>
        /// <param name="employeeUserName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool AuthenticateEmployee(string employeeUserName, string password)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var user = context.Users.Where(e => e.UserName == employeeUserName && e.Password == password).FirstOrDefault();
                if (user == null)
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Create(User user)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    var checkExisting = context.Users.Where(e => e.UserName == user.UserName).FirstOrDefault();
                    if(checkExisting == null)
                    {
                        context.Users.Add(user);
                        context.SaveChanges();
                    }
                    else
                    {
                        return false; //username already exists in database
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Get user by username
        /// </summary>
        /// <param name="employeeUserName"></param>
        /// <returns></returns>
        public static User Get(string employeeUserName)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Users.Where(e => e.UserName == employeeUserName).FirstOrDefault();
            }
        }

        /// <summary>
        /// Get user by user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static User Get(int userId)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Users.Where(e => e.ID == userId).FirstOrDefault();
            }
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        public static List<User> Get()
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Users.ToList();
            }
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="employee"></param>
        public static void Update(User employee)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                context.Users.Attach(employee);
                context.Entry(employee).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool Delete(int userId)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    var toDelete = context.Users.Where(e => e.ID == userId).FirstOrDefault();
                    context.Users.Remove(toDelete);
                    context.Entry(toDelete).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
    }
}
