using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIProject
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Proficiency Proficiency { get; set; }

        public int MaxShiftsPerWeek { get; set; }

        public int MinShiftsPerWeek { get; set; }
       
        public int[] Availablity{ get; set; }

        public int Cost { get; set; }

        public Employee(string i_Name, int i_ID, int i_MaxShiftsPerWeek, int i_MinShiftsPerWeek, Proficiency i_Proficiency, int i_Cost)
        {
            ID = i_ID;
            Name = i_Name;
            MinShiftsPerWeek = i_MinShiftsPerWeek;
            MaxShiftsPerWeek = i_MaxShiftsPerWeek;
            if (MinShiftsPerWeek > MaxShiftsPerWeek)
            {
                int temp = MaxShiftsPerWeek;

                MaxShiftsPerWeek = MinShiftsPerWeek;
                MinShiftsPerWeek = temp;
            }

            Proficiency = i_Proficiency;
            Cost = i_Cost;
        }

        public Employee()
        { }
    }
}
