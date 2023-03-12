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

        public List<Project> GetProjectStatus()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetPercentage();
            }
            finally
            {
                broker.CloseConnection();
            };
        }

        public List<Project> GetSmallProjects()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetSmallProjects();
            }
            finally
            {
                broker.CloseConnection();
            };
        }

        public List<Project> GetMediumProjects()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetMediumProjects();
            }
            finally
            {
                broker.CloseConnection();
            };
        }

        public List<Project> GetLargeProjects()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetLargeProjects();
            }
            finally
            {
                broker.CloseConnection();
            };
        }
    }
}
