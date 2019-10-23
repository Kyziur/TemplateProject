using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTemplate.Infrastructure.DTOs;

namespace ProjectTemplate.Infrastructure.Services
{
    public interface IIsueService : IService
    {
        Task<IssueDto> Get(Guid id);
        Task<IEnumerable<IssueDto>> GetAll();
        Task Create(IssueDto issue);
        Task Delete(Guid id);


    }
}