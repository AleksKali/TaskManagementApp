using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProjectRepository : IRepository<Project>
    {

        private Broker broker = new Broker();

        public void Delete(Project obj)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAll()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllProjects();
            }
            finally
            {
                broker.CloseConnection();
            };
        }

        public void Save(Project obj)
        {
            throw new NotImplementedException();
        }

        public List<Project> Search(string criteria)
        {
            throw new NotImplementedException();
        }

        public void Update(Project obj)
        {
            throw new NotImplementedException();
        }
    }
}
