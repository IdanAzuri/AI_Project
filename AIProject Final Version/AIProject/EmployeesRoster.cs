using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SolverFoundation.Services;

namespace AIProject
{
    public static class EmployeesRoster
    {
        private static Model m_Model;
        private static Decision[,] m_DecisionList;
        private static SolverContext m_Context = SolverContext.GetContext();
        private static ConstraintProgrammingDirective m_CSPDirective;
        public static Report _Report { get; private set; }

        public static void CreateModel()
        {
            m_Context.ClearModel();
            m_Model = m_Context.CreateModel();

            DecisionFactory decisionFactory = new DecisionFactory(Management.Employees.Count);
            m_DecisionList = decisionFactory.BuildDecisions();
            addDecisions();
        }
        public static void GenerateRoster(int i_TimeLimit)
        {
            CreateModel();
            m_CSPDirective = new ConstraintProgrammingDirective();
            m_CSPDirective.TimeLimit = i_TimeLimit;
            ////default constraints
            AddMinEmployeePerShiftConstraint();
            AddMaxEmployeePerShiftConstraint();
            AddMinShiftPerEmployeeConstraint();
            AddMaxShiftPerEmployeeConstraint();
            AddAvailabilityConstraint();
            AddOneDayConstraint();
        }
        public static StringBuilder GenerateSolution()
        {
            Solution solutionReport = m_Context.Solve(m_CSPDirective);
            _Report = solutionReport.GetReport();

            foreach (Shift shift in Management.Shifts)
            {
                shift.EmployeesInShift.Clear();
            }

            int[,] solution = convertDecicionsToIntegers();
            StringBuilder shiftsStringBuildr = new StringBuilder();
            string reportString = _Report.ToString();
            for (int i = 0; i < solution.GetLength(0); i++)
            {
                for (int j = 0; j < solution.GetLength(1); j++)
                {
                    if (solution[i, j] == 1)
                    {
                        Management.Shifts[j].EmployeesInShift.Add(Management.Employees[i]);
                    }
                }
                shiftsStringBuildr.AppendLine();
            }
            System.IO.File.WriteAllText(@"C:\\Temp\REPORT.txt", reportString);
            return shiftsStringBuildr;
        }


        ////Heuristics
        public static void ChooseVariableHeurstic(TreeSearchVariableSelection i_UserInput)
        {
            m_CSPDirective.VariableSelection = i_UserInput;
        }

        public static void ChooseValueHeuristic(TreeSearchValueSelection i_UserInput)
        {
            m_CSPDirective.ValueSelection = i_UserInput;
        }

        public static void ChooseMoveHeuristic(LocalSearchMoveSelection i_UserInput)
        {
            m_CSPDirective.MoveSelection = i_UserInput;
        }

        public static void ChooseAlgorithm(ConstraintProgrammingAlgorithm i_UserInput)
        {
            m_CSPDirective.Algorithm = i_UserInput;
        }

        ////Goal
        public static void AddGoal()
        {
            m_Model.AddGoal("goal", GoalKind.Minimize, Model.Sum(costPerShift()));
        }

        ////Constraints
        public static void AddAllProficienciesConstraint()
        {
            for (int shift = 0; shift < m_DecisionList.GetLength(1); shift++)
            {
                m_Model.AddConstraint("AllProficienciesConstraint" + shift, Model.And(Model.Sum(getProficiencyPerShift(shift, Proficiency.Chef)) >= 1,
                   Model.Sum(getProficiencyPerShift(shift, Proficiency.Manger)) >= 1,
                   Model.Sum(getProficiencyPerShift(shift, Proficiency.Waiter)) >= 1));
            }
        }

        public static void AddNightOrFridayConstraint()
        {
            for (int employee = 0; employee < m_DecisionList.GetLength(0); employee++)
            {
                m_Model.AddConstraint("NightsOrFridayConstraint" + employee, Model.Implies(Model.Sum(getNightsPerEmployee(employee)) >= 3, Model.Sum(m_DecisionList[employee, 15], m_DecisionList[employee, 16], m_DecisionList[employee, 17]) == 0));
            }
        }

        public static void AddMaxEmployeePerShiftConstraint()
        {
            for (int i = 0; i < m_DecisionList.GetLength(1); i++)
            {
                m_Model.AddConstraints("Constraint_MaxCapacity" + (i + 1), Model.Sum(getShift(i)) <= Management.Shifts[i].MaxCapacity);
            }
        }

        public static void AddMinEmployeePerShiftConstraint()
        {
            for (int i = 0; i < m_DecisionList.GetLength(1); i++)
            {
                m_Model.AddConstraints("Constraint_MinCapacity" + (i + 1), Model.Sum(getShift(i)) >= Management.Shifts[i].MinCapacity);
            }
        }

        public static void AddMaxShiftPerEmployeeConstraint()
        {
            for (int i = 0; i < m_DecisionList.GetLength(0); i++)
            {
                m_Model.AddConstraints("Constraint_EmpMaxShifts" + (i + 1), Model.Sum(getEmployee(i)) <= Management.Employees[i].MaxShiftsPerWeek);
            }
        }

        public static void AddMinShiftPerEmployeeConstraint()
        {
            for (int i = 0; i < m_DecisionList.GetLength(0); i++)
            {
                m_Model.AddConstraints("Constraint_EmpMinShifts" + (i + 1), Model.Sum(getEmployee(i)) >= Management.Employees[i].MinShiftsPerWeek);
            }
        }

        public static void AddOneDayConstraint()
        {
            for (int employee = 0; employee < m_DecisionList.GetLength(0); employee++)
            {
                for (int day = 0; day < m_DecisionList.GetLength(1); day += Constants.k_ShiftPerDay)
                {
                    m_Model.AddConstraints("_" + (employee + 1) + "ConstraintOneEmployeePerDay" + (day + 1), Model.Sum(getDayForEmployee(employee, day)) <= 1);
                }
            }
        }

        public static void AddAvailabilityConstraint()
        {
            for (int employee = 0; employee < m_DecisionList.GetLength(0); employee++)
            {
                for (int shift = 0; shift < m_DecisionList.GetLength(1); shift++)
                {
                    m_Model.AddConstraint("_" + shift + "Constraint_Availability" + employee,
                        Model.Sum(m_DecisionList[employee, shift]) <= Management.Table[employee, shift]);
                }
            }
        }

        public static void AddOneManagerConstraint()
        {
            for (int employee = 0; employee < m_DecisionList.GetLength(0); employee++)
            {
                for (int shift = 0; shift < m_DecisionList.GetLength(1); shift++)
                {
                    if (Management.Employees[employee].Proficiency == Proficiency.Manger)
                    {
                        m_Model.AddConstraint("_" + (employee + 1) + "Constraint_Proficiency" + (shift + 1), Model.Implies(m_DecisionList[employee, shift] == 1,
                            Model.Sum(getManegerEmployeePerShift(shift, employee)) == 0));
                    }
                        
                }
            }
        }

        public static void AddConflictConstraint(int i_FirstEmployee, int i_SecondEmployee)
        {
            for (int shift = 0; shift < m_DecisionList.GetLength(1); shift++)
            {
                m_Model.AddConstraint("WorkersConflict" + shift, Model.Implies(m_DecisionList[i_FirstEmployee, shift] == 1, m_DecisionList[i_SecondEmployee, shift] == 0));
            }
        }

        public static void AddNightMorningConstraint()
        {
            for (int shift = 2; shift < m_DecisionList.GetLength(1) - 1; shift += 3)
            {
                for (int employee = 0; employee < m_DecisionList.GetLength(0); employee++)
                {
                    m_Model.AddConstraint("_" + shift + "nightMorning" + employee, Model.Or(Model.Not(m_DecisionList[employee, shift]), Model.Not(m_DecisionList[employee, shift + 1])));
                }
            }
        }

        public static void AddWeekendConstraint(int i_Employee)
        {
            int friday = Constants.k_NumOfShifts - (2 * Constants.k_ShiftPerDay);
            int saturday = Constants.k_NumOfShifts - Constants.k_ShiftPerDay;

            m_Model.AddConstraint("weekendOnce", Model.Implies(Model.Or(m_DecisionList[i_Employee, friday] == 1,
                m_DecisionList[i_Employee, friday + 1] == 1, m_DecisionList[i_Employee, friday + 2] == 1),
                Model.And(m_DecisionList[i_Employee, saturday] == 0, m_DecisionList[i_Employee, saturday + 1] == 0, m_DecisionList[i_Employee, saturday + 2] == 0)));
        }

        public static void Add2DaysARowConstraint(int i_Employee)
        {
            for (int shift = 0; shift < m_DecisionList.GetLength(1) - (2 * Constants.k_ShiftPerDay); shift += Constants.k_ShiftPerDay)
            {
                m_Model.AddConstraint("_" + i_Employee + "consecutive" + shift, Model.Implies(Model.And(Model.Sum(getDayForEmployee(i_Employee, shift)) == 1,
                    Model.Sum(getDayForEmployee(i_Employee, shift + Constants.k_ShiftPerDay)) == 1),
                    Model.Sum(getDayForEmployee(i_Employee, shift + (2 * Constants.k_ShiftPerDay))) == 0));
            }
        }

        private static void addDecisions()
        {
            for (int i = 0; i < m_DecisionList.GetLength(0); i++)
            {
                for (int j = 0; j < m_DecisionList.GetLength(1); j++)
                {
                    m_Model.AddDecision(m_DecisionList[i, j]);
                }
            }
        }

        private static Term[] costPerShift()
        {
            Term[] t = new Term[m_DecisionList.GetLength(1)];

            for (int shift = 0; shift < m_DecisionList.GetLength(1); shift++)
            {
                t[shift] = 0;
                for (int employee = 0; employee < m_DecisionList.GetLength(0); employee++)
                {
                    t[shift] += m_DecisionList[employee, shift] * Management.Employees[employee].Cost;
                }
            }

            return t;
        }

        private static Term[] getProficiencyPerShift(int i_Shift, Proficiency i_Proficiency)
        {
            List<Term> profList = new List<Term>();
            profList.Add(0);

            for (int i = 0; i < m_DecisionList.GetLength(0); i++)
            {
                if (Management.Employees[i].Proficiency == i_Proficiency)
                {
                    profList.Add(m_DecisionList[i, i_Shift]);
                }
            }

            return profList.ToArray();
        }

        private static Term[] getNightsPerEmployee(int i_Employee)
        {
            Term[] nights = new Term[Constants.k_Days - 1];
            int k = 0;

            for (int i = 2; i < m_DecisionList.GetLength(1) - 6; i += Constants.k_ShiftPerDay)
            {
                nights[k] = m_DecisionList[i_Employee, i];
                k++;
            }

            nights[k] = m_DecisionList[i_Employee, Constants.k_NumOfShifts - 1];

            return nights;
        }

        private static Term[] getManegerEmployeePerShift(int i_Col, int i_RowCurrentEmployee)
        {
            List<Term> colManeger = new List<Term>();
            colManeger.Add(0);

            for (int i = 0; i < m_DecisionList.GetLength(0); i++)
            {
                if (i_RowCurrentEmployee != i)
                {
                    if (Management.Employees[i].Proficiency == Proficiency.Manger)
                    {
                        colManeger.Add(m_DecisionList[i, i_Col]);
                    }
                }
            }

            return colManeger.ToArray();
        }

        private static Term[] getEmployee(int i_Row)
        {
            Term[] row = new Term[m_DecisionList.GetLength(1)];

            for (int i = 0; i < m_DecisionList.GetLength(1); i++)
            {
                row[i] = m_DecisionList[i_Row, i];
            }

            return row;
        }

        private static Term[] getDayForEmployee(int i_Employee, int i_FirstShiftInADay)
        {
            Term[] day = new Term[Constants.k_ShiftPerDay];

            for (int j = i_FirstShiftInADay; j < i_FirstShiftInADay + Constants.k_ShiftPerDay; j++)
            {
                day[j - i_FirstShiftInADay] = m_DecisionList[i_Employee, j];
            }

            return day;
        }

        private static int[,] convertDecicionsToIntegers()
        {
            int[,] results = new int[m_DecisionList.GetLength(0), m_DecisionList.GetLength(1)];

            for (int i = 0; i < m_DecisionList.GetLength(0); i++)
            {
                for (int j = 0; j < m_DecisionList.GetLength(1); j++)
                {
                    results[i, j] = Convert.ToInt32(m_DecisionList[i, j].ToString());
                }
            }

            return results;
        }

        private static Term[] getShift(int i_Col)
        {
            Term[] col = new Term[m_DecisionList.GetLength(0)];
            for (int i = 0; i < m_DecisionList.GetLength(0); i++)
            {
                col[i] = m_DecisionList[i, i_Col];
            }

            return col;
        }
    }
}
