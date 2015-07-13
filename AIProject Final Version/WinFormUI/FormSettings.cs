using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIProject;
using Microsoft.SolverFoundation.Services;

namespace WinFormUI
{
    public partial class FormSettings : Form
    {
        private int m_TimeLimit;
        private int m_Probability;
        public static int IndexConflictWorker1 { get; set; }
        public static int IndexconflictWorker2 { get; set; }
        public static int IndexOneDayWeekend { get; set; }
        public static int IndexTwoDaysInARow { get; set; }
        public static LocalSearchMoveSelection CSPMoveSelection { get; set; }
        public static TreeSearchValueSelection CSPValueSelection { get; set; }
        public static TreeSearchVariableSelection CSPVariableSelection { get; set; }
        public static ConstraintProgrammingAlgorithm CSPAlgorithm { get; set; }
        public static int ShiftNameIndex { get; set; }
        public static int EmployeeNameIndex { get; set; }
        public static bool IsModelCreated { get; set; }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            initializeHeuristicsComboBox();
            initiazlieContraintsComboBox();
            initiazlieEmployeeComboBox();
            initiazlieShiftsComboBox();
            comboBoxDefaultValues();
        }

        private void initiazlieShiftsComboBox()
        {
            comboBoxShifts.Items.Clear();

            int i = 0;
            foreach (Shift shift in Management.Shifts)
            {
                comboBoxShifts.Items.Add(shift.ShiftName);
                i++;
            }

            textBoxMaxCapacitiy.Text = Management.Shifts[0].MaxCapacity.ToString();
            textBoxMinCapacitiy.Text = Management.Shifts[0].MinCapacity.ToString();
        }

        private void initiazlieEmployeeComboBox()
        {
            comboBoxEmployeeName.Items.Clear();

            int i = 0;
            foreach (Employee employee in Management.Employees)
            {
                comboBoxEmployeeName.Items.Add(employee.Name);
                i++;
            }
        }

        private void initiazlieContraintsComboBox()
        {
            comboBox2DaysInARow.Items.Clear();
            comboBoxConflictWorker1.Items.Clear();
            comboBoxConflictWorker2.Items.Clear();
            comboBoxOneDayWeekend.Items.Clear();

            int i = 0;
            foreach (Employee employee in Management.Employees)
            {
                comboBox2DaysInARow.Items.Add(employee.Name);
                comboBoxConflictWorker1.Items.Add(employee.Name);
                comboBoxConflictWorker2.Items.Add(employee.Name);
                comboBoxOneDayWeekend.Items.Add(employee.Name);
                i++;
            }
            checkBox2DaysInRow.AutoCheck = true;
        }

        private void initializeHeuristicsComboBox()
        {
            comboBoxValueHeuristic.Items.Clear();
            comboBoxVariableHeuristic.Items.Clear();
            comboBoxMoveSelection.Items.Clear();
            comboBoxAlgorithm.Items.Clear();

            foreach (TreeSearchVariableSelection name in Enum.GetValues(typeof(TreeSearchVariableSelection)))
            {
                comboBoxVariableHeuristic.Items.Add(name);
            }

            foreach (TreeSearchValueSelection name in Enum.GetValues(typeof(TreeSearchValueSelection)))
            {
                comboBoxValueHeuristic.Items.Add(name);
            }

            foreach (LocalSearchMoveSelection name in Enum.GetValues(typeof(LocalSearchMoveSelection)))
            {
                comboBoxMoveSelection.Items.Add(name);
            }

            foreach (ConstraintProgrammingAlgorithm name in Enum.GetValues(typeof(ConstraintProgrammingAlgorithm)))
            {
                comboBoxAlgorithm.Items.Add(name);
            }
        }

        private void comboBoxDefaultValues()
        {
            comboBoxValueHeuristic.SelectedIndex = 0;
            comboBoxVariableHeuristic.SelectedIndex = 0;
            comboBoxMoveSelection.SelectedIndex = 0;
            comboBoxAlgorithm.SelectedIndex = 0;

            comboBox2DaysInARow.SelectedIndex = 3;
            comboBoxConflictWorker1.SelectedIndex = 0;
            comboBoxConflictWorker2.SelectedIndex = 1;
            comboBoxOneDayWeekend.SelectedIndex = 2;

            comboBoxShifts.SelectedIndex = 0;
            comboBoxEmployeeName.SelectedIndex = 0;
        }

        private void formSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkBox2DaysInRow.Checked && checkBoxConflictConstraint.Checked && checkBoxWeekendConstraint.Checked)
            {
                if (comboBox2DaysInARow.SelectedItem != null && comboBoxConflictWorker1.SelectedItem != null &&
          comboBoxConflictWorker2.SelectedItem != null && comboBoxOneDayWeekend.SelectedItem != null)
                {
                    getValuesFromConstraintsComboBoxes();

                    if (IndexTwoDaysInARow == IndexConflictWorker1 || IndexConflictWorker1 == IndexconflictWorker2 ||
                        IndexconflictWorker2 == IndexTwoDaysInARow)
                    {
                        buttonSaveChanges.Enabled = false;
                    }
                    else
                    {
                        buttonSaveChanges.Enabled = true;
                    }
                }
            }
        }

        private void updateEmployee()
        {
            int max,min;
            int.TryParse(textBoxEmpMaxAvailability.Text,out max);
            int.TryParse(textBoxEmpMinAvailability.Text, out min);

            Management.Employees[EmployeeNameIndex].MaxShiftsPerWeek = max;
            Management.Employees[EmployeeNameIndex].MinShiftsPerWeek = min;
        }

        private void updateShift()
        {
            int max, min;
            int.TryParse(textBoxMaxCapacitiy.Text, out max);
            int.TryParse(textBoxMinCapacitiy.Text, out min);

            Management.Shifts[ShiftNameIndex].MaxCapacity = max;
            Management.Shifts[ShiftNameIndex].MinCapacity = min;
        }

        private void getValuesFromConstraintsComboBoxes()
        {
            IndexTwoDaysInARow = comboBox2DaysInARow.SelectedIndex;
            IndexConflictWorker1 = comboBoxConflictWorker1.SelectedIndex;
            IndexconflictWorker2 = comboBoxConflictWorker2.SelectedIndex;
            IndexOneDayWeekend = comboBoxOneDayWeekend.SelectedIndex;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            IsModelCreated = true;
            checkValuesForContraints();
            getValuesForHeuristics();
            int.TryParse(textBoxLimitTime.Text, out m_TimeLimit);
            calulateAvailabiltyProbability();
            updateEmployee();
            updateShift();
            EmployeesRoster.GenerateRoster(m_TimeLimit);
            addConstraint();
            addHeuristics();
            MessageBox.Show("Changes has setted");
            this.Close();
        }

        private void getValuesForHeuristics()
        {
            CSPMoveSelection = (LocalSearchMoveSelection)Enum.Parse(typeof(LocalSearchMoveSelection),
                comboBoxMoveSelection.Text.ToString());
            CSPAlgorithm = (ConstraintProgrammingAlgorithm)Enum.Parse(typeof(ConstraintProgrammingAlgorithm),
               comboBoxAlgorithm.Text.ToString());
            CSPValueSelection = (TreeSearchValueSelection)Enum.Parse(typeof(TreeSearchValueSelection),
               comboBoxValueHeuristic.Text.ToString());
            CSPVariableSelection = (TreeSearchVariableSelection)Enum.Parse(typeof(TreeSearchVariableSelection),
          comboBoxVariableHeuristic.Text.ToString());
        }

        private void calulateAvailabiltyProbability()
        {
            int.TryParse(comboBoxProbability.Text, out m_Probability);
            switch(m_Probability)
            {
                case 85: m_Probability = 9; break;
                case 100: m_Probability = 100; break;
                case 66: m_Probability=4;break;
                default: m_Probability = 20; break;
            }
            Management.Table.ProbabiltyOfWorking(m_Probability);
        }

        private void checkValuesForContraints()
        {
            if (IndexTwoDaysInARow == IndexConflictWorker1 || IndexConflictWorker1 == IndexconflictWorker2 ||
                IndexconflictWorker2 == IndexOneDayWeekend)
            {
                IndexTwoDaysInARow = 0;
                IndexConflictWorker1 = 1;
                IndexOneDayWeekend = 2;
                IndexconflictWorker2 = 10;
            }
        }
      
        private void addHeuristics()
        {
            EmployeesRoster.ChooseAlgorithm(CSPAlgorithm);
            EmployeesRoster.ChooseMoveHeuristic(CSPMoveSelection);
            EmployeesRoster.ChooseValueHeuristic(CSPValueSelection);
            EmployeesRoster.ChooseVariableHeurstic(CSPVariableSelection);
        }

        private void addConstraint()
        {
            if(checkBoxNightAndDay.Checked)
            {
                EmployeesRoster.AddNightMorningConstraint();
            }
            if(checkBoxNightOrFriday.Checked)
            {
                EmployeesRoster.AddNightOrFridayConstraint();
            }
            if(checkBoxOneManager.Checked)
            {
                EmployeesRoster.AddOneManagerConstraint();
            }
            if(checkBoxProficiency.Checked)
            {
                EmployeesRoster.AddAllProficienciesConstraint();

            }
            if(checkBoxWeekendConstraint.Checked)
            {
                EmployeesRoster.AddWeekendConstraint(IndexOneDayWeekend);
            }
            if(checkBox2DaysInRow.Checked)
            {
                EmployeesRoster.Add2DaysARowConstraint(IndexTwoDaysInARow);
            }
            if(checkBoxConflictConstraint.Checked)
            {
                EmployeesRoster.AddConflictConstraint(IndexConflictWorker1, IndexconflictWorker2);
            }
       }

        private void buttonSaveShiftChanges_Click(object sender, EventArgs e)
        {
            updateShift();
            MessageBox.Show("Shift changes has setted");
        }

        private void buttonSaveEmployeeChanges_Click(object sender, EventArgs e)
        {
            updateEmployee();
            MessageBox.Show("Employee changes has setted");
        }

        private void buttonMoreConstraints_Click(object sender, EventArgs e)
        {
            if (panelHeuristics.Visible)
            {
                panelConstraints.Height = panelConstraints.Height * 2;
                panelHeuristics.Visible = false;
                buttonMoreConstraints.Location = new Point(337, 430);
                buttonMoreConstraints.Text = "Less Constraints";
            }
            else
            {
                panelHeuristics.Visible = true;
                panelConstraints.Height = panelConstraints.Height / 2;
                buttonMoreConstraints.Location = new Point(337, 196);
                buttonMoreConstraints.Text = "More Constraints";
            }
        }

        private void comboBoxShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmployeeName.SelectedIndex>=0)
            {
                textBoxMaxCapacitiy.Text = Management.Shifts[comboBoxShifts.SelectedIndex].MaxCapacity.ToString();
                textBoxMinCapacitiy.Text = Management.Shifts[comboBoxShifts.SelectedIndex].MinCapacity.ToString();
            }
        }

        private void comboBoxEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmployeeName.SelectedIndex >= 0)
            {
                textBoxEmpMaxAvailability.Text = Management.Employees[comboBoxEmployeeName.SelectedIndex].MaxShiftsPerWeek.ToString();
                textBoxEmpMinAvailability.Text = Management.Employees[comboBoxEmployeeName.SelectedIndex].MinShiftsPerWeek.ToString();
            }
        }

        private void comboBoxConflictWorker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConflictWorker2.SelectedIndex < Management.Employees.Count - 1)
            {
                comboBoxConflictWorker2.SelectedIndex = comboBoxConflictWorker1.SelectedIndex + 1;
            }
            else
            {
                comboBoxConflictWorker2.SelectedIndex = 0;
            }
        }
    }
}
