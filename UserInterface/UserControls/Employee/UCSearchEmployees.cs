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

namespace UserInterface.UserControls.Employee
{
    public partial class UCSearchEmployees : UserControl
    {
        public UCSearchEmployees()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            Controller.Instance.SetEmployeeDataGridView(dgvSearchEmployees);
        }

        private void tbEmployeeName_TextChanged(object sender, EventArgs e)
        {
            
                Controller.Instance.SearchEmployees(dgvSearchEmployees, tbEmployeeName.Text); 
            
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            Controller.Instance.DeleteEmployee(dgvSearchEmployees);
            Controller.Instance.SetEmployeeDataGridView(dgvSearchEmployees);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (Controller.Instance.ShowEmployeeDetails(dgvSearchEmployees))
            {
                EmployeeDetailDialog edd = new EmployeeDetailDialog();
                edd.ShowDialog();
                DialogResult result = edd.DialogResult;
                if (result == DialogResult.OK)
                {
                    edd.Dispose();
                }
            }
            Controller.Instance.SetEmployeeDataGridView(dgvSearchEmployees);
        }
    }
}
