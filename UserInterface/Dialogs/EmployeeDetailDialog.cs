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
    public partial class EmployeeDetailDialog : Form
    {
        public EmployeeDetailDialog()
        {
            InitializeComponent();
        }

        private void EmployeeDetailDialog_Load(object sender, EventArgs e)
        {
            Controller.Instance.LoadEmployeeData(tbId, tbFullName, tbEmail, tbPhone, dtpDateOfBirth, tbSalary);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!(Controller.Instance.ValidateEmployeeData(tbFullName, tbEmail, tbPhone, tbSalary))) {
                return;
            }
            else
            {
                Controller.Instance.UpdateEmployee(tbFullName, tbEmail, tbPhone, dtpDateOfBirth, tbSalary);
                this.DialogResult = DialogResult.OK;
            }
           
        }
    }
}
