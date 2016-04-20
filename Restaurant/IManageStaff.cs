using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public interface IManageStaff : IBusStaff, IHostStaff, ICookStaff, IWaitStaff
    {
        


    }
}
