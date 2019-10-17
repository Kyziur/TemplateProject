using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTemplate.Core.Domain
{
    public class Task
    {
        public Task(Guid id, string name, string description)
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
        public IEnumerable<Comment> Comments { get; protected set; }
        private ISet<Task> _linkedTasks = new HashSet<Task>();
        public ISet<Task> LinkedTasks
        {
            get { return _linkedTasks; }
            protected set { _linkedTasks = new HashSet<Task>(value); }
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
            var today = DateTime.UtcNow;
            var difference = today.Subtract(dueDate);
            if (difference.Days > 0)
                throw new ArgumentException(nameof(dueDate), "Due date is invalid. Due date cannot be in past.");

            DueDate = dueDate;
            UpdatedAt = DateTime.UtcNow;
        }

        public void AssignTaskTo(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User cannot be null.");

            AssignedTo = user;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetReportedBy(User reporter)
        {
            if (reporter == null)
                throw new ArgumentNullException(nameof(reporter), "Reporter cannot be null.");

            ReportedBy = reporter;
            UpdatedAt = DateTime.UtcNow;
        }

        public void AddLinkToTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task), "Task cannot be null.");

            _linkedTasks.Add(task);
            UpdatedAt = DateTime.UtcNow;
        }

        public void RemoveLinkedTask(Guid taskId)
        {
            var task = _linkedTasks.SingleOrDefault(x => x.Id == taskId);
            if (task == null)
                throw new Exception("Task was not found.");

            _linkedTasks.Remove(task);
            UpdatedAt = DateTime.UtcNow;
        }


    }
}