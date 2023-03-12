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

        #region connection
        private SqlConnection connection;

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


        #region project
       
        public List<Project> GetPercentage()
        {
            List<Project> projects = new List<Project>();
            SqlCommand command = new SqlCommand("dbo.GetProjectPercentage", connection);
                
            command.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Project p = new Project
                    {
                        ProjectId = (int)reader["id"],
                        Title = (string)reader["title"],
                        Description = (string)reader["description"],
                        Percentage = (double)reader["Percentage"]

                    };

                    projects.Add(p);
                }
            }
            return projects;
        }

        public List<Project> GetSmallProjects()
        {
            List<Project> projects = new List<Project>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT COUNT(e.id) AS NumOfEmployees, p.* FROM Project p JOIN Task t ON t.project_id = p.id JOIN Employee e ON e.id = t.assignee GROUP BY p.id, p.title, p.description HAVING COUNT(t.id) <= 3";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Project p = new Project
                    {
                        ProjectId = (int)reader["id"],
                        Title = (string)reader["title"],
                        Description = (string)reader["description"],
                        NumOFEmployees = (int)reader["NumOfEmployees"]

                    };

                    projects.Add(p);
                }
            }
            return projects;
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

        public List<Project> GetLargeProjects()
        {
            List<Project> projects = new List<Project>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT COUNT(e.id) AS NumOfEmployees, p.* FROM Project p JOIN Task t ON t.project_id = p.id JOIN Employee e ON e.id = t.assignee GROUP BY p.id, p.title, p.description HAVING COUNT(t.id) > 10";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Project p = new Project
                    {
                        ProjectId = (int)reader["id"],
                        Title = (string)reader["title"],
                        Description = (string)reader["description"],
                        NumOFEmployees = (int)reader["NumOfEmployees"]

                    };

                    projects.Add(p);
                }
            }
            return projects;
        }

        public List<Project> GetMediumProjects()
        {
            List<Project> projects = new List<Project>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"SELECT COUNT(e.id) AS NumOfEmployees, p.* FROM Project p JOIN Task t ON t.project_id = p.id JOIN Employee e ON e.id = t.assignee GROUP BY p.id, p.title, p.description HAVING COUNT(t.id) BETWEEN 4 AND 10";

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Project p = new Project
                    {
                        ProjectId = (int)reader["id"],
                        Title = (string)reader["title"],
                        Description = (string)reader["description"],
                        NumOFEmployees = (int)reader["NumOfEmployees"]

                    };

                    projects.Add(p);
                }
            }
            return projects;
        }
        #endregion

        #region task


        public void DeleteTask(Task obj)
        {
            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"delete from task WHERE id={obj.TaskId}";
            command.ExecuteNonQuery();
        }
        //public void UpdateTask(Task obj) //ne radi
        //{

        //    SqlCommand command = new SqlCommand("", connection);
        //    command.CommandText = $"update task set title = @Title, description = @Description, assignee = @Assignee, due_date = @DueDate, status = @Status, updated_at = @UpdatedAt WHERE id= {obj.TaskId}";


        //    command.Parameters.AddWithValue("Title", obj.Title);
        //    command.Parameters.AddWithValue("Description", obj.Description);
        //    command.Parameters.AddWithValue("Assignee", obj.Assignee.EmployeeId);
        //    command.Parameters.AddWithValue("DueDate", obj.DueDate);
        //    command.Parameters.AddWithValue("Status", obj.Status);
        //    command.Parameters.AddWithValue("UpdatedAt", DateTime.Now);


        //    command.ExecuteNonQuery();
        //}
        public void UpdateTask(Task obj)
        {
            SqlCommand command = new SqlCommand("dbo.UpdateTask", connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TaskId", obj.TaskId);
            command.Parameters.AddWithValue("@Title", obj.Title);
            command.Parameters.AddWithValue("@Description", obj.Description);
            command.Parameters.AddWithValue("@Assignee", obj.Assignee.EmployeeId);
            command.Parameters.AddWithValue("@DueDate", obj.DueDate);
            command.Parameters.AddWithValue("@Status", (int)obj.Status);

            command.ExecuteNonQuery();

        }
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

        #endregion

        #region employee
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

       

        public List<Employee> GetTopEmployees()
        {
            List<Employee> employees = new List<Employee>();

            SqlCommand command = new SqlCommand("", connection);
            command.CommandText = $"select TOP (5) COUNT(t.id) AS FinishedTasks, e.* FROM task t INNER JOIN Employee e ON e.id = t.assignee WHERE t.status = 2 and t.resolved >= DATEADD(month, -1, GETDATE()) GROUP by e.id, e.full_name, e.email, e.phone, e.date_of_birth, e.salary ORDER BY count(t.id) DESC";

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
        #endregion

    }
}
