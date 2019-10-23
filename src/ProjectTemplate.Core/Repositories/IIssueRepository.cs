using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTemplate.Core.Domain;

namespace ProjectTemplate.Core.Repositories
{
    public interface IIssueRepository : IRepository
    {
        Task<Issue> Get(Guid id);
        Task<IEnumerable<Issue>> GetAll();
        Task Add(Issue issue);
        Task Remove(Guid id);
        Task Update(Issue issue);
    }
}