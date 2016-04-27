using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataAccessObject
    {
        //Connection string stored statically (bad practice...)
        private readonly string CONNECTION_STRING = "metadata=res://*/RestaurantEntities.csdl|res://*/RestaurantEntities.ssdl|res://*/RestaurantEntities.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=cis1.actx.edu;initial catalog=RestaurantApplication;user id=db2;password=db20;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        
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
                var user = context.Users.Where(e => e.ID == employeeId && e.Password == e.Password);
                if (user == null)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
