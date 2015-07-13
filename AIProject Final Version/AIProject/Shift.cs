using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIProject
{
    public class Shift
    {
        private int m_MinEmployeesCapacity = 4;
        private int m_MaxEmployeesCapacity = 15;

        public string ShiftName { get; set; }

        public List<Employee> EmployeesInShift { get; set; }

        public Shift()
        {
            EmployeesInShift = new List<Employee>(m_MinEmployeesCapacity);
        }

        public int MinCapacity
        {
            get { return m_MinEmployeesCapacity; }
            set { m_MinEmployeesCapacity = value; }
        }
        public int MaxCapacity
        {
            get { return m_MaxEmployeesCapacity; }
            set { m_MaxEmployeesCapacity = value; }
        }
    }
}
