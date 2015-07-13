using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIProject
{
   [Flags]
    public enum Proficiency
    {
        NotAssigned = 1,
        Manger = 2,
        Waiter = 4,
        Chef = 8
    }
}
