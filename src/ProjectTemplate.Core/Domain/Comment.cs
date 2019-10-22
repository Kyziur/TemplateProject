using System;

namespace ProjectTemplate.Core.Domain
{
    public class Comment
    {
        protected Comment()
        {
        }

        public Comment(Guid id, User author, string text)
        {
            Id = id;
            SetAuthor(author);
            SetText(text);
            CreatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; protected set; }
        public User Author { get; protected set; }
        public string Text { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; set; }

        public void SetAuthor(User author)
        {
            if (author == null)
                throw new ArgumentNullException(nameof(author), "Author cannot be null.");

            Author = author;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new Exception("Comment must have text.");

            Text = text;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}