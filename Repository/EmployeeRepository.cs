using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {

        private Broker broker = new Broker();
        public void Delete(Employee obj)
        {
            try
            {
                broker.OpenConnection();
                broker.DeleteEmployee(obj);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Employee> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllEmployees();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Save(Employee obj)
        {
            try
            {
                broker.OpenConnection();
                broker.SaveEmployee(obj);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Employee> GetTopEmployees()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetTopEmployees();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Employee> Search(string criteria)
        {
            try
            {
                broker.OpenConnection();
                 return broker.SearchEmployees(criteria);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Update(Employee obj)
        {
            try
            {
                broker.OpenConnection();
                broker.UpdateEmployee(obj);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Employee> GetEmployeeKPI()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetEmployeeKPI();
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
