using ProjectTemplate.Core.Domain;
using ProjectTemplate.Core.Repositories;
using ProjectTemplate.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTemplate.Infrastructure.Services
{
    public class IssueService : IIsueService
    {
        private readonly IIssueRepository _issueRepository;

        public IssueService(IIssueRepository issueRepository)
        {
            _issueRepository = issueRepository;
        }
        public async Task Create(IssueDto issueDto)
        {
            var issue = new Issue(Guid.NewGuid(), issueDto.Name, issueDto.Description);
            issue.SetDueDate(issueDto.DueDate);

            await _issueRepository.Add(issue);
        }

        public async Task Delete(Guid id)
        {
            await _issueRepository.Remove(id);
        }

        public async Task<IssueDto> Get(Guid id)
        {
            var issue = await _issueRepository.Get(id);
            var issueDto = new IssueDto
            {
                Name = issue.Name,
                Description = issue.Description,
                DueDate = issue.DueDate,
                Comments = issue.Comments,
                Status = issue.Status,
                LinkedIssues = issue.LinkedIssues.Select(x => new IssueDto
                {
                    Name = x.Name,
                    Description = x.Description,
                    DueDate = x.DueDate,
                    Comments = x.Comments,
                    Status = x.Status
                })
            };

            return issueDto;
        }

        public async Task<IEnumerable<IssueDto>> GetAll()
        {
            var issues = await _issueRepository.GetAll();
            var issuesDto = issues.Select(x => new IssueDto
            {
                Name = x.Name,
                Description = x.Description,
                DueDate = x.DueDate,
                Comments = x.Comments,
                Status = x.Status,
                LinkedIssues = x.LinkedIssues.Select(x => new IssueDto
                {
                    Name = x.Name,
                    Description = x.Description,
                    DueDate = x.DueDate,
                    Comments = x.Comments,
                    Status = x.Status
                }),

            }).ToList();
            return issuesDto;
        }
    }
}