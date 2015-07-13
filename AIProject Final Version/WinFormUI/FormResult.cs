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
    public partial class FormResult : Form
    {
    public FormResult()
        {
            InitializeComponent();
        }

        private void dataGridViewSchedule_Click(object sender, EventArgs e)
        {

            if (Management.Shifts[0].EmployeesInShift.Count>0)
            {
                dataGridViewEmployeesPerShift.DataSource = Management.Shifts[dataGridViewSchedule.CurrentRow.Index].EmployeesInShift;
                labelEmployees.ResetText();
                labelEmployees.Text = labelEmployees.Text + Management.Shifts[dataGridViewSchedule.CurrentRow.Index].ShiftName;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                buttonGenerate.Enabled = false;
                this.UseWaitCursor = true;//from the Form/Window instance
                Application.DoEvents();//messages pumped to update controls
                if(FormSettings.IsModelCreated==false)
                {
                    EmployeesRoster.GenerateRoster(90000);
                }
                if(checkBoxGoal.Checked)
                {
                    EmployeesRoster.AddGoal();
                }
                dataGridViewEmployeesPerShift.DataSource = null;              
                EmployeesRoster.GenerateSolution();
                textBoxRunTime.Text = (EmployeesRoster._Report.TotalTime / 1000).ToString() +"sec";
                labelEmployees.Visible = true;
                labelShifts.Visible = true;
                dataGridViewEmployeesPerShift.Visible = true;
                dataGridViewSchedule.Visible = true;
                dataGridViewSchedule.DataSource = Management.Shifts;
                dataGridViewEmployeesPerShift.DataSource = Management.Shifts[0].EmployeesInShift;
                if (EmployeesRoster._Report.SolutionQuality != SolverQuality.Feasible)
                {
                    MessageBox.Show("The Problem is infeasible or time limit ended");
                }

            }
            finally
            {
                buttonGenerate.Enabled = true;
                this.UseWaitCursor = false;
                labelRunTime.Visible = true;
                textBoxRunTime.Visible = true;
                Management.Table.ProbabiltyOfWorking(20);
            }
        }

        private void checkValuesForContraints()
        {
            if (FormSettings.IndexTwoDaysInARow == FormSettings.IndexConflictWorker1 || FormSettings.IndexConflictWorker1 == FormSettings.IndexconflictWorker2 ||
                FormSettings.IndexconflictWorker2 == FormSettings.IndexOneDayWeekend)
            {
                FormSettings.IndexTwoDaysInARow = 0;
                FormSettings.IndexConflictWorker1 = 1;
                FormSettings.IndexOneDayWeekend = 2;
                FormSettings.IndexconflictWorker2 = 10;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmployeesPerShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
