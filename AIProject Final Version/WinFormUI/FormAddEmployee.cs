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
namespace WinFormUI
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool isVaildValues = true;
            string name = textBoxName.Text;
            int id, maxShifts, minShifts,salary;
            Proficiency proficiency;
            try
            {
                int.TryParse(textBoxID.Text, out id);
                int.TryParse(comboBoxMaxShifts.SelectedItem.ToString(), out maxShifts);
                int.TryParse(comboBoxMinShifts.Text, out minShifts);
                int.TryParse(textBoxSalary.Text, out salary);
                Enum.TryParse(comboBoxProficiency.Text, out proficiency);
                string msg = string.Empty;


                if (string.IsNullOrEmpty(name))
                {
                    msg = String.Format("Name field is null");
                    isVaildValues = false;
                    textBoxName.Focus();
                }
                else if (string.IsNullOrEmpty(textBoxID.Text))
                {
                    msg = String.Format("ID field is null");
                    isVaildValues = false;
                    textBoxID.Focus();
                }
                else if (!string.IsNullOrEmpty(textBoxID.Text) && textBoxID.Text!="0")
                {
                    foreach (Employee employees in Management.Employees)
                    {
                        if (employees.ID == id)
                        {
                            msg = "This ID already Exist or contains letters";
                        }
                    }
                }
                if (minShifts > maxShifts)
                {
                    msg = String.Format("Max Shifts must be greater than Min Shifts");
                    isVaildValues = false;
                    comboBoxMaxShifts.Focus();
                }
                  if (!(salary>=25 && salary<100))
                {
                    msg = String.Format("Salary must be in range 25-100");
                    isVaildValues = false;
                    textBoxSalary.Focus();
                }
                if (!string.IsNullOrEmpty(msg))
                {
                    MessageBox.Show(msg);
                }
                else if (isVaildValues)
                {
                    if (isVaildValues)
                    {
                        Management.Employees.Add(new Employee(name, id, maxShifts, minShifts, proficiency, salary));
                        Management.NewInitialize();
                        msg = string.Format("{0} is successfuly added!", name);
                        MessageBox.Show(msg);
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            comboBoxMinShifts.SelectedIndex = 0;
            comboBoxMaxShifts.SelectedIndex = 1;
            comboBoxProficiency.SelectedIndex = 1;
        }
    }
}
