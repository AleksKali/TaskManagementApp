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
    public partial class UCAddEmployee : UserControl
    {
        public UCAddEmployee()
        {
            InitializeComponent();
        }

       

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!(Controller.Instance.ValidateEmployeeData(tbFullName, tbEmail, tbPhone, tbSalary)))
            {
                return;
            }
            else
            {
                Controller.Instance.AddEmployee(tbFullName, tbEmail, tbPhone, dtpDateOfBirth, tbSalary);
                Controller.Instance.RefreshEFields(tbFullName, tbEmail, tbPhone, tbSalary);
            }
           
        }

       
    }
}
