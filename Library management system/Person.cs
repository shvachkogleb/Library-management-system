using System;

namespace Library_management_system
{
    public abstract class Person : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid Id { get; private set; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
            Id = Guid.NewGuid();
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}, Email: {Email}, ID: {Id}";
        }
    }
}

