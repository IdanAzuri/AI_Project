using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIProject
{
    public class Shift
    {
        //private int m_MinEmployeesCapacity = 3;
        //private int m_MaxEmployeesCapacity = 3;
        private Capacity m_Chef = new Capacity();
        private Capacity m_Manager = new Capacity();
        private Capacity m_Waiter = new Capacity(2,2);

        public Capacity Chef
        {
            get { return m_Chef; }
            set { m_Chef = value; }
        }

        public Capacity Manager
        {
            get { return Manager; }
            set { Manager = value; }
        }

        public Capacity Waiter
        {
            get { return m_Waiter; }
            set { m_Waiter = value; }
        }
    }
}
