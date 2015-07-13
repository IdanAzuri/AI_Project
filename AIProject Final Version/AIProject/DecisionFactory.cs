using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SolverFoundation.Services;

namespace AIProject
{
    public class DecisionFactory
    {
        private Domain domain = Domain.Set(0,1);
        private readonly Decision[,] Decisions;

        public DecisionFactory(int i_NumberOfEmployees)
        {
            Decisions = new Decision[i_NumberOfEmployees, Constants.k_NumOfShifts];
        }

        public Decision[,] BuildDecisions()
        {
            for (int i = 0; i < Decisions.GetLength(0); i++)
            {
                for (int j = 0; j < Decisions.GetLength(1); j++)
                {
                    Decisions[i, j] = new Decision(domain, "_" + i + "Decision" + j);
                }
            }

            return Decisions;
        }
    }
}
