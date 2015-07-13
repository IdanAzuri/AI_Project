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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonShowEmployees_Click(object sender, EventArgs e)
        {
            FormShowEmployees EmployeesForm = new FormShowEmployees();
            EmployeesForm.ShowDialog();
        }

        private void buttonAddEmployees_Click(object sender, EventArgs e)
        {
            new FormAddEmployee().ShowDialog();
        }

        private void buttonGenerateRoster_Click(object sender, EventArgs e)
        {
            new FormResult().ShowDialog();
        }
    }
}
