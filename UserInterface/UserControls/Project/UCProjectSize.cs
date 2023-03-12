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

namespace UserInterface.UserControls.Project
{
    public partial class UCProjectSize : UserControl
    {
        public UCProjectSize()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Controller.Instance.ShowSmallProjects(dgvProjectsSize);
        }

        private void rbSmallProjects_CheckedChanged(object sender, EventArgs e)
        {
            Controller.Instance.ShowSmallProjects(dgvProjectsSize);
        }

        private void rbMediumProjects_CheckedChanged(object sender, EventArgs e)
        {
            Controller.Instance.ShowMediumProjects(dgvProjectsSize);
        }
    

        private void rbLargeProjects_CheckedChanged(object sender, EventArgs e)
        {
            Controller.Instance.ShowLargeProjects(dgvProjectsSize);
        }

    }
}
