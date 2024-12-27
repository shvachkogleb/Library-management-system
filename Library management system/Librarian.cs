using System.Collections.Generic;

namespace Library_management_system
{
    public class Librarian : Person, ILibraryManagement
    {
        public Librarian(string name, string email) : base(name, email) { }

        public void AddBook(Book book)
        {
            Library.Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Library.Books.Remove(book);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ", Role: Librarian";
        }
    }
}

