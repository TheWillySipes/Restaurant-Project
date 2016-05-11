using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserTimeClockEntryData
    {
        public static UserTimeClockEntry GetMostRecentEntry(int userId)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    var timeClockEntry = context.UserTimeClockEntries
                        .Where(e => e.UserID == userId)
                        .OrderByDescending(e => e.ClockIn)
                        .FirstOrDefault();
                    return timeClockEntry;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static void Create(int userId)
        {
            UserTimeClockEntry utce = new UserTimeClockEntry()
            {
                UserID = userId,
                Date = DateTime.Today,
                ClockIn = DateTime.Now,
            };
            try{
                using(RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    context.UserTimeClockEntries.Add(utce);
                    context.SaveChanges();
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void Update(UserTimeClockEntry updateEntry)
        {
            try
            {
                using (RestaurantApplicationEntities context = new RestaurantApplicationEntities())
                {
                    context.UserTimeClockEntries.Attach(updateEntry);
                    context.Entry(updateEntry).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
