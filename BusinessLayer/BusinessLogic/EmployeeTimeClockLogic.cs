using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessLogic
{
    public class EmployeeTimeClockLogic
    {
        /// <summary>
        /// Clock an employee in
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>True - Clock in successful, False - Clock in unsuccessful</returns>
        public static bool ClockIn(int employeeId)
        {
            var checkExistingEntries = DataLayer.UserTimeClockEntryData.GetMostRecentEntry(employeeId);
            if(checkExistingEntries == null)
            {
                DataLayer.UserTimeClockEntryData.Create(employeeId);
                return true;
            }
            if (checkExistingEntries.ClockOut == null && checkExistingEntries.Date == DateTime.Today)
            {
                return false;
            }
            else
            {
                DataLayer.UserTimeClockEntryData.Create(employeeId);
                return true;
            }
        }

        /// <summary>
        /// Clock an employee out
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns>False - Clock out unsuccessful, True - clock out successful</returns>
        public static bool ClockOut(int employeeId)
        {
            var checkExistingEntries = DataLayer.UserTimeClockEntryData.GetMostRecentEntry(employeeId);
            if (checkExistingEntries != null)
            {
                if (checkExistingEntries.ClockOut == null)
                {
                    checkExistingEntries.ClockOut = DateTime.Now;
                    DataLayer.UserTimeClockEntryData.Update(checkExistingEntries);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
