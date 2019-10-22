using System;
using System.Collections.Generic;

namespace ProjectTemplate.Core.Domain
{
    public class Project
    {
        protected Project()
        {
        }

        public Project(Guid id, string name, User owner)
        {
            Id = id;
            SetName(name);
            SetOwner(owner);
            CreatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public User Owner { get; protected set; }
        private ISet<Issue> _issues = new HashSet<Issue>();
        public ISet<Issue> Issues
        {
            get => _issues;
            protected set => _issues = new HashSet<Issue>(value);
        }

        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Project name cannot be empty.");

            Name = name;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetOwner(User owner)
        {
            if (owner == null)
                throw new ArgumentNullException(nameof(owner), "Project owner not found.");

            Owner = owner;
            UpdatedAt = DateTime.UtcNow;
        }

        public void AddIssue(Issue issue)
        {
            if (issue == null)
                throw new ArgumentNullException(nameof(issue), "Issue not found.");

            _issues.Add(issue);
        }
    }
}