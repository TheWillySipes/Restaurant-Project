using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public enum TableStatus
    {
        Open = 0,
        Occupied = 1,
        Dirty = 2
    }

    public enum Roles
    {
        Manager = 0,
        WaitStaff = 1,
        Cook = 2,
        BusBoy = 3,
        Host = 4
    }
}

