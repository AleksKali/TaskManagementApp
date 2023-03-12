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

namespace UserInterface.Dialogs
{
    public partial class TaskDetailDialog : Form
    {
        public TaskDetailDialog()
        {
            InitializeComponent();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {

            if (!(Controller.Instance.ValidateTaskData(tbTitle, rtbDescription)))
            {
                return;
            }
            else
            {
                Controller.Instance.UpdateTask(tbTaskId, cbProject, tbTitle, rtbDescription, cbAssignee, cbStatus, dtpDueDate);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void TaskDetailDialog_Load(object sender, EventArgs e)
        {
            Controller.Instance.ShowTaskDetails(tbTaskId, tbTitle, rtbDescription, cbAssignee, cbProject, dtpDueDate, cbStatus);
        }
    }
}
