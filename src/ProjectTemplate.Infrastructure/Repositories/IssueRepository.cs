using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTemplate.Core.Domain;
using ProjectTemplate.Core.Repositories;

namespace ProjectTemplate.Infrastructure.Repositories
{
    public class IssueRepository : IIssueRepository
    {
        public Task Add(Issue issue)
        {
            throw new NotImplementedException();
        }

        public Task<Issue> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Issue>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Issue issue)
        {
            throw new NotImplementedException();
        }
    }
}