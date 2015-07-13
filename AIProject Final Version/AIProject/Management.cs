using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIProject
{
    public static class Management
    {
        public static List<Shift> Shifts { get; private set; }
        public static List<Employee> Employees { get; private set; }
        public static WeekleyRosterTable Table { get; private set; }

        static Management()
        {
           employeeInitialize();
           shiftInitialize();
           Table = new WeekleyRosterTable(Employees.Count);         
        }

        private static void shiftInitialize()
        {
            Shifts = new List<Shift>(Constants.k_NumOfShifts);
            for(int i=0;i<Constants.k_NumOfShifts;i++)
            {
                Shifts.Add(new Shift());
                switch(i/3)
                {
                    case 0: Shifts[i].ShiftName = " Sunday"; break;
                    case 1: Shifts[i].ShiftName = " Monday"; break;
                    case 2: Shifts[i].ShiftName = " Tuesday"; break;
                    case 3: Shifts[i].ShiftName = " Wednesday"; break;
                    case 4: Shifts[i].ShiftName = " Thursday"; break;
                    case 5: Shifts[i].ShiftName = " Friday"; break;
                    case 6: Shifts[i].ShiftName = " Saturday"; break;
                }
                switch (i % 3)
                {
                    case 0: Shifts[i].ShiftName += " Morning "; break;
                    case 1: Shifts[i].ShiftName += " Noon "; break;
                    case 2: Shifts[i].ShiftName += " evening "; break;
                }
            }
            Shifts[0].MinCapacity = 3;
            Shifts[0].MaxCapacity = 12;
            Shifts[Constants.k_NumOfShifts - 1].MinCapacity = 3;
        }

        private static void employeeInitialize()
        {
            Employees = new List<Employee>(19);
            Employees.Add(new Employee("Idan", 12345, 3, 10,Proficiency.Manger, 25));
            Employees.Add(new Employee("Oz", 12344, 3, 12, Proficiency.Chef, 27));
            Employees.Add(new Employee("Gil", 12343,4, 8, Proficiency.Manger, 30));
            Employees.Add(new Employee("Ben", 12342, 5, 15,Proficiency.Waiter, 30));
            Employees.Add(new Employee("David", 12341, 3, 15, Proficiency.Waiter, 27));
            Employees.Add(new Employee("Odelia", 12340, 3, 12, Proficiency.Waiter, 25));
            Employees.Add(new Employee("Dani", 30286, 2, 10, Proficiency.Chef, 26));
            Employees.Add(new Employee("Oded", 30284, 3, 6, Proficiency.Waiter, 30));
            Employees.Add(new Employee("Yoav", 123410, 2, 7, Proficiency.Manger, 28));
            Employees.Add(new Employee("Guy", 123402, 3, 6, Proficiency.Chef, 25));
            Employees.Add(new Employee("Vered", 302861, 4, 5, Proficiency.Chef, 27));
            Employees.Add(new Employee("Inbar", 302862, 2, 7, Proficiency.Chef, 28));
            Employees.Add(new Employee("Daniel", 123403, 2, 7, Proficiency.Manger, 26));
            Employees.Add(new Employee("Steve", 302867, 1, 3, Proficiency.Waiter, 25));
            Employees.Add(new Employee("Alex", 302868, 2, 5, Proficiency.Chef, 30));
            Employees.Add(new Employee("Dana", 302862, 4, 10, Proficiency.Manger, 29));
            Employees.Add(new Employee("Gal", 123403, 5, 5, Proficiency.Waiter, 25));
            Employees.Add(new Employee("Shani", 302867, 5, 10, Proficiency.Waiter, 26));
            Employees.Add(new Employee("Yossi", 302868, 4, 11, Proficiency.Chef, 30));
        }

        public static void NewInitialize()
        {
            Table = new WeekleyRosterTable(Employees.Count);         
        }
    }
}
