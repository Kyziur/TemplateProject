using System;

namespace ProjectTemplate.Core.Domain
{
    public class User
    {
        protected User()
        {
        }

        public User(Guid id, string username, string firstName, string lastName, string email)
        {
            Id = id;
            SetUsername(username);
            SetFirstName(firstName);
            SetLastName(lastName);
            SetEmail(email);
            CreatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        public void SetUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException(nameof(username), "Username cannot be empty.");

            Username = username;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException(nameof(firstName), "Firstname cannot be empty.");

            FirstName = firstName;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException(nameof(lastName), "Lastname cannot be empty.");

            LastName = lastName;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException(nameof(email), "Email cannot be empty.");

            Email = email;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password, string salt)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException(nameof(password),
                    "Password cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(salt))
            {
                throw new ArgumentException(nameof(salt),
                    "Salt cannot be empty.");
            }
            if (password.Length < 4)
            {
                throw new ArgumentException(nameof(password),
                    "Password must contain at least 4 characters.");
            }
            if (password.Length > 100)
            {
                throw new ArgumentException(nameof(password),
                    "Password cannot contain more than 100 characters.");
            }
            if (Password == password)
            {
                return;
            }
            Password = password;
            Salt = salt;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}