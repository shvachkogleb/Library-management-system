using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class Librarian : Person
    {
        public Librarian(string name, string email) : base(name, email) { }

        public static void AddBook(Book book)
        {
            Library.Books.Add(book);
        }

        public static void RemoveBook(Book book)
        {
            Library.Books.Remove(book);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ", Role: Librarian";
        }
    }
}

