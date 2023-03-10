using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLogic
{
    public class Controller
    {
        #region singleton
        private static Controller instance;
        
        private Controller()
        {
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }
        #endregion

        private Employee selectedEmployee = new Employee();
        private List<Employee> employees = new List<Employee>();
        private EmployeeRepository employeeRepository = new EmployeeRepository();


        public void AddEmployee(TextBox fullName, TextBox email, TextBox phone, DateTimePicker dtpDateOfBirth, TextBox salary)
        {
            //vidi sta ces kad su prazna polja
            Employee employee = new Employee
            {
                FullName = fullName.Text,
                Email = email.Text,
                Phone = phone.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Salary = int.Parse(salary.Text)

            };
            try
            {
                employeeRepository.Save(employee);
                MessageBox.Show("Employee successfully created!");

            }
            catch (Exception)
            {

                MessageBox.Show("Failed to save data.");
            }
            

        }
        public void DeleteEmployee(DataGridView dgvSearchEmployees)

        {
            selectedEmployee = (Employee)dgvSearchEmployees.SelectedRows[0].DataBoundItem;
            employeeRepository.Delete(selectedEmployee);
        }

        public void SetEmployeeDataGridView(DataGridView dgv)
        {
            dgv.DataSource = employeeRepository.GetAll();
            dgv.ReadOnly = true;
        }

        private bool IsEmailValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }

       
        public bool ValidateEmployeeData(TextBox tbFullName, TextBox tbEmail, TextBox tbPhone, TextBox tbSalary)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(tbFullName.Text))
            {
                tbFullName.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                tbFullName.BackColor = Color.White;
            }

            if (!string.IsNullOrEmpty(tbEmail.Text) && !IsEmailValid(tbEmail.Text))
            {
                tbEmail.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                tbEmail.BackColor = Color.White;
            }
            
            if (!string.IsNullOrEmpty(tbSalary.Text) && !int.TryParse(tbSalary.Text, out _))
            {
                tbSalary.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                tbSalary.BackColor = Color.White;
            }

            return valid;
        }

        public void SearchEmployees(DataGridView dgv, string text)
        {
            try
            {
                employees = employeeRepository.Search(text);

                dgv.DataSource = employees;

            }
            catch (Exception ex)
            {

                MessageBox.Show("blah");
            }
        }


        /*if (dgvClanPretraga.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali red!");
                return;
            }
            izabranClan = (Clan)dgvClanPretraga.SelectedRows[0].DataBoundItem;
        
         FrmDetaljiClana frmDetaljiClana = new FrmDetaljiClana(izabranClan);
            frmDetaljiClana.ShowDialog();
            DialogResult result = frmDetaljiClana.DialogResult;
            frmDetaljiClana.Dispose();
            if(result== DialogResult.OK)
            {
                MessageBox.Show("Uspesno ste izmenili podatke o clanu!");
            }*/


        public bool ShowEmployeeDetails(DataGridView dgvSearchEmployees)
        {
            if(dgvSearchEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a row.");
                return false;
            }
            selectedEmployee = (Employee) dgvSearchEmployees.SelectedRows[0].DataBoundItem;
           
            return true;
        }
        
        public void LoadEmployeeData(TextBox tbId, TextBox tbFullName, TextBox tbEmail, TextBox tbPhone, DateTimePicker dtpDateOfBirth, TextBox tbSalary)
        {
            tbId.Text = selectedEmployee.EmployeeId.ToString();
            tbFullName.Text = selectedEmployee.FullName;
            tbEmail.Text = selectedEmployee.Email;
            tbPhone.Text = selectedEmployee.Phone;
            tbSalary.Text = selectedEmployee.Salary.ToString();
            dtpDateOfBirth.Value = selectedEmployee.DateOfBirth;

            tbId.ReadOnly = true;
        }

        public void UpdateEmployee(TextBox tbFullName, TextBox tbEmail, TextBox tbPhone, DateTimePicker dtpDateOfBirth, TextBox tbSalary)
        {
            selectedEmployee.FullName = tbFullName.Text;
            selectedEmployee.Email = tbEmail.Text;
            selectedEmployee.Phone = tbPhone.Text;
            selectedEmployee.DateOfBirth = dtpDateOfBirth.Value;
            selectedEmployee.Salary = int.Parse(tbSalary.Text);

            try
            {
                employeeRepository.Update(selectedEmployee);
                MessageBox.Show("Employee successfully updated!");
                DialogResult result = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Update failed.");
            }
        }
    }
}
