using System;
using System.Collections.Generic;

namespace ProjectTemplate.Core.Domain
{
    public class Project
    {
        public Project(Guid id, string name, User owner, ISet<Task> tasks)
        {
            Id = id;
            SetName(name);
            SetOwner(owner);
            Tasks = tasks;
            CreatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public User Owner { get; protected set; }
        private ISet<Task> _tasks = new HashSet<Task>();
        public ISet<Task> Tasks
        {
            get { return _tasks; }
            protected set { _tasks = new HashSet<Task>(value); }
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
                throw new ArgumentNullException(nameof(owner), "Project owner cannot be null.");

            Owner = owner;
            UpdatedAt = DateTime.UtcNow;
        }

        public void AddTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task), "Task cannot be null.");

            _tasks.Add(task);
        }
    }
}