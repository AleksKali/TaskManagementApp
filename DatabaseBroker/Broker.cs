using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
