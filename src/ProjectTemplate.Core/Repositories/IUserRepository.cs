using System;
using ProjectTemplate.Core.Domain;

namespace ProjectTemplate.Core.Repositories
{
    public interface IUserRepository : IRepository
    {
        User Get(Guid id);
        void Add(User user);
        void Remove(Guid id);
        void Update(User user);
    }
}