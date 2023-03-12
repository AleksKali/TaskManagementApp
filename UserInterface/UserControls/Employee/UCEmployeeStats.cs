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

namespace UserInterface.UserControls.Employee
{
    public partial class UCEmployeeStats : UserControl
    {
        public UCEmployeeStats()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Controller.Instance.GetTopEmployees(dgvTopEmployees);
        }

        

    }
}
