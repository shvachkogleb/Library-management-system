using System.Collections.Generic;

namespace Library_management_system
{
    public static class Library
    {
        public static List<Book> Books { get; private set; } = new List<Book>();
        public static List<IUser> Users { get; private set; } = new List<IUser>();

        public static void AddUser(IUser person)
        {
            Users.Add(person);
        }
    }
}

