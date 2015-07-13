using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIProject
{
    public class WeekleyRosterTable
    {
        private static int m_NumberOfEmployees;

        public int[,] Table { get; private set; }

        public WeekleyRosterTable(int i_NummOfEmployees)
        {
            m_NumberOfEmployees = i_NummOfEmployees;
            Table = new int[m_NumberOfEmployees, Constants.k_Days * Constants.k_ShiftPerDay];
            ProbabiltyOfWorking(9);
        }

        public void ProbabiltyOfWorking(int i_Probability)
        {
            for (int i = 0; i < m_NumberOfEmployees; i++)
            {
                for (int j = 0; j < Constants.k_Days * Constants.k_ShiftPerDay; j++)
                {
                    Random rnd = new Random();
                    int randomNum = rnd.Next(0, i_Probability);
                    switch (randomNum)
                    {
                        case 0:
                            Table[i, j] = 0; break;
                        default: Table[i, j] = 1; break;
                    }
                }
            }
        }

        public int this[int i_RowIndex, int i_ColIndex]
        {
            get { return Table[i_RowIndex, i_ColIndex]; }
            set { Table[i_RowIndex, i_ColIndex] = value; }
        }
    }
}