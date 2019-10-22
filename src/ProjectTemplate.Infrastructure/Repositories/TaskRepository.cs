using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Domain;
using ProjectTemplate.Core.Repositories;

namespace ProjectTemplate.Infrastructure.Repositories
{
    public class TaskRepository : IIssueRepository
    {
        public void Add(Issue issue)
        {
            throw new NotImplementedException();
        }

        public Issue Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Issue> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Issue issue)
        {
            throw new NotImplementedException();
        }
    }
}