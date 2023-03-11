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
            throw new NotImplementedException();
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

                try
                {
                    broker.SaveEmployeeProject(obj);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(">>>>>>> Row already exists. " + ex.Message);
                }
                
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
                
                try
                {
                    
                    int i =broker.CheckEmployeeProjectConnection(obj);
                    if(i>)
                    //broker.UpdateEmployeeProject(obj);
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(">>>>>>> Row already exists. " + ex.Message);
                }
                broker.UpdateTask(obj); //provera da li postoji vise ovakvih, ako postoji sve kul, ako ne postoji brise se veza

            }
            finally
            {
                broker.CloseConnection();
            }
        }
    }
}
