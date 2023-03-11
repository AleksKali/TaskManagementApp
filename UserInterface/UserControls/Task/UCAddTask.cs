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

namespace UserInterface.UserControls.Task
{
    public partial class UCAddTask : UserControl
    {
        public UCAddTask()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            
                Controller.Instance.LoadTaskData(cbAssignee, cbProject);
           
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            Controller.Instance.AddTask(tbTitle, rtbDescription, cbProject, cbAssignee, dtpDueDate);
        }
    }
}
