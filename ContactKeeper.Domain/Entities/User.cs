using System;

namespace ContactKeeper.Domain.Entities
{
    public class User : Entity
    {
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Date = DateTime.Now;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime Date { get; private set; }
    }
}
