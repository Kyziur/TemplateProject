using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Domain;

namespace ProjectTemplate.Core.Repositories
{
    public interface IProjectRepository : IRepository
    {
        Project Get(Guid id);
        IEnumerable<Project> GetAll();
        void Add(Project project);
        void Remove(Guid id);
        void Update(Project project);
    }
}