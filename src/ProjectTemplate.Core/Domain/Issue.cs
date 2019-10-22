using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTemplate.Core.Domain
{
    public class Issue
    {
        protected Issue()
        {
        }
        public Issue(Guid id, string name, string description)
        {
            Id = id;
            SetName(name);
            SetDescription(description);
            CreatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        //TODO: Implement adding comments
        private ISet<Comment> _comments = new HashSet<Comment>();
        public ISet<Comment> Comments
        {
            get => _comments;
            protected set => _comments = new HashSet<Comment>(value);
        }
        private ISet<Issue> _linkedIssues = new HashSet<Issue>();
        public ISet<Issue> LinkedIssues
        {
            get => _linkedIssues;
            protected set => _linkedIssues = new HashSet<Issue>(value);
        }
        public DateTime DueDate { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public User AssignedTo { get; protected set; }
        public User ReportedBy { get; protected set; }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Name cannot be empty.");

            Name = name;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetDescription(string description)
        {
            Description = description;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetDueDate(DateTime dueDate)
        {
            var difference = dueDate.Subtract(DateTime.UtcNow).Days;
            if (difference < 0)
                throw new ArgumentException(nameof(dueDate), "Due date is invalid. Due date cannot be in past.");

            DueDate = dueDate;
            UpdatedAt = DateTime.UtcNow;
        }

        public void AssignIssueTo(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User not found.");

            AssignedTo = user;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetReportedBy(User reporter)
        {
            if (reporter == null)
                throw new ArgumentNullException(nameof(reporter), "Reporter not found.");

            ReportedBy = reporter;
            UpdatedAt = DateTime.UtcNow;
        }

        public void AddLinkToIssue(Issue issue)
        {
            if (issue == null)
                throw new ArgumentNullException(nameof(issue), "Issue not found.");

            _linkedIssues.Add(issue);
            UpdatedAt = DateTime.UtcNow;
        }

        public void RemoveLinkedIssue(Guid issueId)
        {
            var issue = _linkedIssues.SingleOrDefault(x => x.Id == issueId);
            if (issue == null)
                throw new Exception("Issue was not found.");

            _linkedIssues.Remove(issue);
            UpdatedAt = DateTime.UtcNow;
        }


    }
}