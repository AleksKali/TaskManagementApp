using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DatabaseBroker
{
    public class Broker
    {

        #region basic
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=taskMgmt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

     
        public void OpenConnection()
        {
            connection.Open();
        }

      

        public void CloseConnection()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
                connection.Close();
        }
        #endregion


        public List<Task> GetAllTasks()
        {
            List<Task> tasks = new List<Task>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT t.id as taskId, t.title as taskTitle, t.description as taskDescription, t.due_date as taskDueDate, t.status as taskStatus, e.full_name as employeeFullName, e.id as employeeId, p.id as projectId, p.title as projectTitle from task t join employee e on (t.assignee=e.id) join Project p on(t.project_id=p.id)";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Task t = new Task
                    {
                        TaskId = (int)reader["taskId"],
                        Title = (string)reader["taskTitle"],
                        Description = (string)reader["taskDescription"],
                        DueDate = (DateTime)reader["taskDueDate"],
                        Status = (TaskStatus)reader["taskStatus"],
                        Assignee = new Employee
                        {
                            FullName = (string)reader["employeeFullName"],
                            EmployeeId = (int)reader["employeeId"]
                        },
                        Project = new Project
                        {
                            Title = (string)reader["projectTitle"],
                            ProjectId = (int)reader["projectId"]
                        }

                    };

                    tasks.Add(t);
                }
            }
            return tasks;
        }


        public List<Project> GetAllProjects()
        {
            List<Project> projects = new List<Project>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT * from project";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Project p = new Project
                    {
                        ProjectId = (int)reader["id"],
                        Title = (string)reader["title"],
                        Description = (string)reader["description"]

                    };

                    projects.Add(p);
                }
            }
            return projects;
        }

        public void UpdateTask(Task obj)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update task set title = @Title, description = @Description, assignee = @Assignee, due_date = @DueDate, status = @Status, updated_at = @UpdatedAt WHERE id= @TaskId";
            command.Parameters.AddWithValue("TaskId", obj.TaskId);
            command.Parameters.AddWithValue("Title", obj.Title);
            command.Parameters.AddWithValue("Description", obj.Description);
            command.Parameters.AddWithValue("Assignee", obj.Assignee.EmployeeId);
            command.Parameters.AddWithValue("Salary", obj.DueDate);

            command.ExecuteNonQuery();
        }

        public int CheckEmployeeProjectConnection(Task obj)
        {
            bool go = true;

            int broj = 0;

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select count(assignee) from task where assignee = {obj.Assignee.EmployeeId} AND project_id={obj.Project.ProjectId}";

            broj= (int)command.ExecuteScalar();

            return broj;
        }
        //ako ima jos onda nista, ako nema onda delete

        public void UpdateEmployeeProject(Task obj)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update employee_project set @EmployeeId, @ProjectId";
            command.Parameters.AddWithValue("EmployeeId", obj.Assignee.EmployeeId);
            command.Parameters.AddWithValue("ProjectId", obj.Project.ProjectId);

            command.ExecuteNonQuery();
        }

        public List<Task> SearchTasks(string criteria)
        {
            List<Task> tasks = new List<Task>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT t.id as taskId, t.title as taskTitle, t.description as taskDescription, t.due_date as taskDueDate, t.status as taskStatus, e.full_name as employeeFullName, e.id as employeeId, p.id as projectId, p.title as projectTitle from task t join employee e on (t.assignee=e.id) join Project p on(t.project_id=p.id) WHERE t.title LIKE '%{criteria}%'";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Task t = new Task
                    {
                        TaskId = (int)reader["taskId"],
                        Title = (string)reader["taskTitle"],
                        Description = (string)reader["taskDescription"],
                        DueDate = (DateTime)reader["taskDueDate"],
                        Status = (TaskStatus)reader["taskStatus"],
                        Assignee = new Employee
                        {
                            FullName = (string)reader["employeeFullName"],
                            EmployeeId = (int)reader["employeeId"]
                        },
                        Project = new Project
                        {
                            Title = (string)reader["projectTitle"],
                            ProjectId = (int)reader["projectId"]
                        }

                    };

                    tasks.Add(t);
                }
            }
            return tasks;
        }

        public void SaveTask(Task obj)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"insert into Task (title, description, assignee, project_id, due_date, status, created_at) values (@Title, @Description, @Assignee, @Project, @DueDate, @Status, @CreatedAt)";
            command.Parameters.AddWithValue("Title", obj.Title);
            command.Parameters.AddWithValue("Description", obj.Description);
            command.Parameters.AddWithValue("Assignee", obj.Assignee.EmployeeId);
            command.Parameters.AddWithValue("Project", obj.Project.ProjectId);
            command.Parameters.AddWithValue("DueDate", obj.DueDate);
            command.Parameters.AddWithValue("Status", obj.Status);
            command.Parameters.AddWithValue("CreatedAt", DateTime.Now);

            command.ExecuteNonQuery();
        }

        public void SaveEmployeeProject(Task obj)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"insert into employee_project  values (@EmployeeId, @ProjectId)";
            command.Parameters.AddWithValue("EmployeeId", obj.Assignee.EmployeeId);
            command.Parameters.AddWithValue("ProjectId", obj.Project.ProjectId);

            command.ExecuteNonQuery();
        }
        public void SaveEmployee(Employee obj)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"insert into Employee values (@FullName, @Email, @Phone, @DateOfBirth, @Salary)";
            command.Parameters.AddWithValue("FullName", obj.FullName);
            command.Parameters.AddWithValue("Email", obj.Email);
            command.Parameters.AddWithValue("Phone", obj.Phone);
            command.Parameters.AddWithValue("DateOfBirth", obj.DateOfBirth);
            command.Parameters.AddWithValue("Salary", obj.Salary);

            command.ExecuteNonQuery();
        }

        public void UpdateEmployee(Employee obj)
        {

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"update employee set full_name = @FullName, email = @Email, phone = @Phone, date_of_birth = @DateOfBirth, salary = @Salary WHERE id= @EmployeeId";
            command.Parameters.AddWithValue("EmployeeId", obj.EmployeeId);
            command.Parameters.AddWithValue("FullName", obj.FullName);
            command.Parameters.AddWithValue("Email", obj.Email);
            command.Parameters.AddWithValue("Phone", obj.Phone);
            command.Parameters.AddWithValue("DateOfBirth", obj.DateOfBirth);
            command.Parameters.AddWithValue("Salary", obj.Salary);

            command.ExecuteNonQuery();
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT * from employee";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee e = new Employee
                    {
                        EmployeeId = (int)reader["id"],
                        FullName = (string)reader["full_name"],
                        Email = (string)reader["email"],
                        Phone = (string)reader["phone"],
                        DateOfBirth = (DateTime)reader["date_of_birth"],
                        Salary = (int)reader["salary"]

                    };

                    employees.Add(e);
                }
            }
            return employees;
        }

        public List<Employee> SearchEmployees(string criteria)
        {
            List<Employee> employees = new List<Employee>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT * from employee WHERE full_name LIKE '%{criteria}%'";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee e = new Employee
                    {
                        EmployeeId = (int)reader["id"],
                        FullName = (string)reader["full_name"],
                        Email = (string)reader["email"],
                        Phone = (string)reader["phone"],
                        DateOfBirth = (DateTime)reader["date_of_birth"],
                        Salary = (int)reader["salary"]

                    };

                   employees.Add(e);
                }
            }
            return employees;
        }

        public void DeleteEmployee(Employee obj)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from Employee WHERE id={obj.EmployeeId}";
            command.ExecuteNonQuery();
        }

    }
}
