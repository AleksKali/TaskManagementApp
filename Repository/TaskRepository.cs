using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Repository
{
    public class TaskRepository : IRepository<Task>
    {
        private Broker broker = new Broker();

        public void Delete(Task obj)
        {
            try
            {
                broker.OpenConnection();
                broker.DeleteTask(obj);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Task> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllTasks();
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Save(Task obj)
        {
            try
            {
                broker.OpenConnection();
                broker.SaveTask(obj);

            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public List<Task> Search(string criteria)
        {
            try
            {
                broker.OpenConnection();
                return broker.SearchTasks(criteria);
            }
            finally
            {
                broker.CloseConnection();
            }
        }

        public void Update(Task obj)
        {
            try
            {
                broker.OpenConnection();
                broker.UpdateTask(obj); 
               
            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
