using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataAccessObject
    {
        //Singleton
        private static DataAccessObject instance;
        private DataAccessObject() { }
        public static DataAccessObject Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAccessObject();
                }
                return instance;
            }
        }
        //End of singleton

        //User data access
        public List<User> GetEmployees()
        {
            using(RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Users.ToList();
            }
        }

        public bool IsInRole(int employeeId, int role)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var usersRoles = context.UsersRoles.Where(e => e.UserID == employeeId && e.RoleID == role).FirstOrDefault();
                if(usersRoles == null)
                {
                    return false;
                }
                return true;
            }
        }

        public bool AuthenticateEmployee(int employeeId, string password)
        {
            using(RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var user = context.Users.Where(e => e.ID == employeeId && e.Password == password).FirstOrDefault();
                if (user == null)
                {
                    return false;
                }
                return true;
            }
        }

        public bool AuthenticateEmployee(string employeeUserName, string password)
        {
            using(RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                var user = context.Users.Where(e => e.UserName == employeeUserName && e.Password == password).FirstOrDefault();
                if(user == null)
                {
                    return false;
                }
                return true;
            }
        }

        public User GetEmployee(string employeeUserName)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                return context.Users.Where(e => e.UserName == employeeUserName).FirstOrDefault();
            }
        }

        public void UpdateEmployee(User employee)
        {
            using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
            {
                context.Users.Attach(employee);
                context.Entry(employee).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
