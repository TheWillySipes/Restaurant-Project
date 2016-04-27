using System;
using System.Collections.Generic;
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
    }
}
