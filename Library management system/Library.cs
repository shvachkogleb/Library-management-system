using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_management_system
{
    internal static class Library
    {
        public static List<Book> Books { get; private set; } = new List<Book>();
        public static List<Person> Users { get; private set; } = new List<Person>();

        public static void AddUser(Person person)
        {
            Users.Add(person);
        }
    }
}
