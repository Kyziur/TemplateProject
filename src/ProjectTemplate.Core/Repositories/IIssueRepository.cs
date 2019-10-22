using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Domain;

namespace ProjectTemplate.Core.Repositories
{
    public interface IIssueRepository : IRepository
    {
        Issue Get(Guid id);
        IEnumerable<Issue> GetAll();
        void Add(Issue issue);
        void Remove(Guid id);
        void Update(Issue issue);
    }
}