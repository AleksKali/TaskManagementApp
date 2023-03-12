using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = Domain.Task;
using TaskStatus = Domain.TaskStatus;

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
        private TaskRepository taskRepository = new TaskRepository();
        private ProjectRepository projectRepository = new ProjectRepository();
        private List<Task> tasks = new List<Task>();
        private Task selectedTask = new Task();

        #region project
        public void ShowSmallProjects(DataGridView dgvProjectsSize)
        {

            try
            {
                dgvProjectsSize.DataSource = projectRepository.GetSmallProjects();
                dgvProjectsSize.ReadOnly = true;
                dgvProjectsSize.Columns[3].Visible = false;
                dgvProjectsSize.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load display small projects. " + ex.Message);
                Debug.WriteLine(">>>>>>>>>>> " + ex.Message);
            }
            

        }
        public void ShowMediumProjects(DataGridView dgvProjectsSize)
        {
            
            try
            {
                dgvProjectsSize.DataSource = projectRepository.GetMediumProjects();
                dgvProjectsSize.ReadOnly = true;
                dgvProjectsSize.Columns[3].Visible = false;
                dgvProjectsSize.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load display medium projects. " + ex.Message);
                Debug.WriteLine(">>>>>>>>>>> " + ex.Message);
            }

        }
        public void ShowLargeProjects(DataGridView dgvProjectsSize)
        {
            
            try
            {
                dgvProjectsSize.DataSource = projectRepository.GetMediumProjects();
                dgvProjectsSize.ReadOnly = true;
                dgvProjectsSize.Columns[3].Visible = false;
                dgvProjectsSize.Columns[0].Visible = false; dgvProjectsSize.DataSource = projectRepository.GetLargeProjects();
                dgvProjectsSize.ReadOnly = true;
                dgvProjectsSize.Columns[3].Visible = false;
                dgvProjectsSize.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load display medium projects. " + ex.Message);
                Debug.WriteLine(">>>>>>>>>>> " + ex.Message);
            }
        }

        public void SetProjectStatusDataGridView(DataGridView dgvProjectStatus)
        {
            

            try
            {
                dgvProjectStatus.DataSource = projectRepository.GetProjectStatus();
                dgvProjectStatus.Columns[0].Visible = false;
                dgvProjectStatus.Columns[4].Visible = false;
                dgvProjectStatus.ReadOnly = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load status of the projects. " + ex.Message);
                Debug.WriteLine(">>>>>>>>>>> " + ex.Message);
            }
        }

        #endregion

        #region task

        public void LoadTaskData(ComboBox cbAssignee, ComboBox cbProject)
        {
            try
            {
                cbAssignee.DataSource = employeeRepository.GetAll();
                cbProject.DataSource = projectRepository.GetAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load task data. " + ex.Message);
                Debug.WriteLine(">>>>>>>>>>> " + ex.Message);
            }
            
        }

        public void DeleteTask(DataGridView dgvSearchTasks) //pls choose a row
        {

            if (dgvSearchTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a row.");
                return;
            }
            else
            {

                try
                {
                    selectedTask = (Task)dgvSearchTasks.SelectedRows[0].DataBoundItem;
                    taskRepository.Delete(selectedTask);
                    MessageBox.Show("Task successfully deleted.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Failed to delete object"+ ex.Message);
                    Debug.WriteLine(">>>>>>> " + ex.Message);
                }

            }
            
        }

        public void ShowTaskDetails(TextBox tbTaskId, TextBox tbTitle, RichTextBox rtbDescription, ComboBox cbAssignee, ComboBox cbProject, DateTimePicker dtpDueDate, ComboBox cbStatus)
        {
            try
            {
                tbTaskId.Text = selectedTask.TaskId.ToString();
                tbTitle.Text = selectedTask.Title;
                rtbDescription.Text = selectedTask.Description;
                LoadTaskData(cbAssignee, cbProject);
                cbAssignee.SelectedItem = selectedTask.Assignee;
                cbProject.SelectedItem = selectedTask.Project;
                dtpDueDate.Value = selectedTask.DueDate;
                cbStatus.DataSource = Enum.GetValues(typeof(TaskStatus));
                cbStatus.SelectedItem = selectedTask.Status;

                cbProject.Enabled = false;
                tbTaskId.ReadOnly = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to display task details" + ex.Message);
                Debug.WriteLine(">>>>>>> " + ex.Message);
            }
        }

        public void AddTask(TextBox tbTitle, RichTextBox rtbDescription, ComboBox cbProject, ComboBox cbAssignee, DateTimePicker dtpDueDate)
        {
            Task task = new Task
            {
                Title = tbTitle.Text,
                Description = rtbDescription.Text,
                Assignee = (Employee)cbAssignee.SelectedItem,
                Project = (Project)cbProject.SelectedItem,
                DueDate = dtpDueDate.Value,
                Status = TaskStatus.Ready
            };

            try
            {
               
                taskRepository.Save(task);
                MessageBox.Show("Task successfully created!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to save data." + ex.Message);
                Debug.WriteLine(">>>>>>> " + ex.Message);
            }
            

        }

        public void SearchTasks(DataGridView dgvSearchTasks, TextBox tbTaskTitle)
        {
            try
            {
                tasks = taskRepository.Search(tbTaskTitle.Text);

                dgvSearchTasks.DataSource = tasks;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load tasks.");
                Debug.WriteLine(">>>>>>> " + ex.Message);
            }
        }
       
        public void UpdateTask(TextBox tbTaskId, ComboBox cbProject, TextBox tbTitle, RichTextBox rtbDescription, ComboBox cbAssignee, ComboBox cbStatus, DateTimePicker dtpDueDate)
        {
            
            selectedTask.TaskId = int.Parse(tbTaskId.Text);
            selectedTask.Assignee = (Employee)cbAssignee.SelectedItem;
            selectedTask.Project = (Project)cbProject.SelectedItem;
            selectedTask.Title = tbTitle.Text;
            selectedTask.Description = rtbDescription.Text;
            selectedTask.DueDate = dtpDueDate.Value;
            selectedTask.Status = (TaskStatus)cbStatus.SelectedItem;

            try
            {
                taskRepository.Update(selectedTask);
                MessageBox.Show("Task successfully updated!");
                DialogResult result = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Update failed." + ex.Message);
                Debug.WriteLine(">>>>>>> " + ex.Message);
            }
        }

        public void SetTaskDataGridView(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = taskRepository.GetAll();
                dgv.ReadOnly = true;
                dgv.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load data. "+ex.Message);
                Debug.WriteLine(">>>>>>>> " + ex.Message);
            }
            
        }

        public bool ShowTaskDetailDialog(DataGridView dgvSearchTasks)
        {
            if (dgvSearchTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a row.");
                return false;
            }
            selectedTask = (Task)dgvSearchTasks.SelectedRows[0].DataBoundItem;

            return true;
        }

        public bool ValidateTaskData(TextBox tbTitle, RichTextBox rtbDescription)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                tbTitle.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                tbTitle.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(rtbDescription.Text))
            {
                rtbDescription.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                rtbDescription.BackColor = Color.White;
            }

            return valid;
        }
        public void RefreshFields(TextBox tbTitle, RichTextBox rtbDescription)
        {
            tbTitle.Text = null;
            rtbDescription.Text = null;
        }

        #endregion

        #region employee

        public void GetTopEmployees(DataGridView dgvTopEmployees)
        {
            try
            {
                dgvTopEmployees.DataSource = employeeRepository.GetTopEmployees();
                dgvTopEmployees.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to get 5 employees who completed the largest number of tasks in the past month. " + ex.Message);
                Debug.WriteLine(">>>>>>>> " + ex.Message);
            }
            
        }


        public void AddEmployee(TextBox fullName, TextBox email, TextBox phone, DateTimePicker dtpDateOfBirth, TextBox salary)
        {
            
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
            if (dgvSearchEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose a row.");
                return;
            }
            else
            {

                try
                {
                    selectedEmployee = (Employee)dgvSearchEmployees.SelectedRows[0].DataBoundItem;
                    employeeRepository.Delete(selectedEmployee);
                    MessageBox.Show("Employee successfully deleted.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Failed to delete object" + ex.Message);
                    Debug.WriteLine(">>>>>>> " + ex.Message);
                }

            }
            
        }

        public void SetEmployeeDataGridView(DataGridView dgv)
        {
            
            try
            {
                dgv.DataSource = employeeRepository.GetAll();
                dgv.ReadOnly = true;
                dgv.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to load data. " + ex.Message);
                Debug.WriteLine(">>>>>>>> " + ex.Message);
            }
        }

        #region Validation
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

            if (string.IsNullOrEmpty(tbEmail.Text) || !IsEmailValid(tbEmail.Text))
            {
                tbEmail.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                tbEmail.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(tbPhone.Text))
            {
                tbPhone.BackColor = Color.Salmon;
                valid = false;
            }
            else
            {
                tbPhone.BackColor = Color.White;
            }
            if (string.IsNullOrEmpty(tbSalary.Text) || !int.TryParse(tbSalary.Text, out _))
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


        public void RefreshEFields(TextBox tbFullName, TextBox tbEmail, TextBox tbPhone, TextBox tbSalary)
        {
            tbFullName.Text = null;
            tbEmail.Text = null;
            tbPhone.Text = null;
            tbSalary.Text = null;
        }


        #endregion
        public void SearchEmployees(DataGridView dgv, string text)
        {
            try
            {
                employees = employeeRepository.Search(text);

                dgv.DataSource = employees;
                dgv.ReadOnly = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to search employees by their name." + ex.Message);
                Debug.WriteLine(">>>>>>>> " + ex.Message);
            }
        }

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

                MessageBox.Show("Failed to update the employee. "+ex.Message);
                Debug.WriteLine(">>>>>> " + ex.Message);
            }
        }
        #endregion
    }
}
