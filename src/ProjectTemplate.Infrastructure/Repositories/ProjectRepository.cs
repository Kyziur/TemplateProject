using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Domain;
using ProjectTemplate.Core.Repositories;

namespace ProjectTemplate.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public void Add(Project project)
        {
            throw new NotImplementedException();
        }

        public Project Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Project project)
        {
            throw new NotImplementedException();
        }
    }
}