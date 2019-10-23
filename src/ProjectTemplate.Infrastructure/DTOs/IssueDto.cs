using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Domain;

namespace ProjectTemplate.Infrastructure.DTOs
{
    public class IssueDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<IssueDto> LinkedIssues { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
    }
}