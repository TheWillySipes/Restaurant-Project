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

        public static bool AuthenticateEmployee(int employeeId, string password)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var user = context.Users.Where(e => e.ID == employeeId && e.Password == password).FirstOrDefault();
                if (user == null)
                {
                    return false;
                }
                return true;
            }
        }

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

        public static bool Create(User user)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public static User Read(string employeeUserName)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Users.Where(e => e.UserName == employeeUserName).FirstOrDefault();
            }
        }

        public static User Read(int id)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Users.Where(e => e.ID == id).FirstOrDefault();
            }
        }

        public static List<User> Read()
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Users.ToList();
            }
        }

        public static void Update(User employee)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                context.Users.Attach(employee);
                context.Entry(employee).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static bool Delete(int id)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    var toDelete = context.Users.Where(e => e.ID == id).FirstOrDefault();
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
