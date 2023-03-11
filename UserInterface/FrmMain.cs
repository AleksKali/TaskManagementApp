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
using UserInterface.UserControls.Task;

namespace UserInterface
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
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

        private void searchTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new UCSearchTasks());
        }
    }
}
