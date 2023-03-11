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
using UserInterface.Dialogs;

namespace UserInterface.UserControls.Task
{
    public partial class UCSearchTasks : UserControl
    {
        public UCSearchTasks()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Controller.Instance.SetTaskDataGridView(dgvSearchTasks);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (Controller.Instance.ShowTaskDetailDialog(dgvSearchTasks))
            {
                TaskDetailDialog tdd = new TaskDetailDialog();
                tdd.ShowDialog();
                DialogResult result = tdd.DialogResult;
                if (result == DialogResult.OK)
                {
                    tdd.Dispose();
                }
            }
            Controller.Instance.SetTaskDataGridView(dgvSearchTasks);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*
              Controller.Instance.DeleteEmployee(dgvSearchEmployees);
            Controller.Instance.SetEmployeeDataGridView(dgvSearchEmployees);
             */
        }

        private void tbTaskTitle_TextChanged(object sender, EventArgs e)
        {
            Controller.Instance.SearchTasks(dgvSearchTasks, tbTaskTitle);
        }
    }
}
