using ApplicationLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.UserControls.Employee;
using UserInterface.UserControls.Project;
using UserInterface.UserControls.Task;

namespace UserInterface
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            ChangePanel(new UCTopEmployees());
        }

       

        public void ChangePanel(UserControl userControl) 
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }

        private void createEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCAddEmployee());
        }

        private void searchEmpoyeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCSearchEmployees());

        }

        private void createTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCAddTask());
        }

        private void searchTasksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePanel(new UCSearchTasks());

        }

        private void projectStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCProjectStatus());
        }

        private void projectSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCProjectSize());
        }

        private void employeeStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCTopEmployees());
        }

        

        private void employeeKPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCEmployeeKPI());
        }
    }
}
