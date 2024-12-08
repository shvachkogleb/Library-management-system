using System;

namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book("C# Programming", "John Doe");
            var book2 = new Book("Advanced Algorithms", "Jane Smith");

            Librarian.AddBook(book1);
            Librarian.AddBook(book2);

            var reader = new Reader("Alice", "alice@example.com");
            Library.AddUser(reader);

            try
            {
                reader.BorrowBook(book1);
                reader.BorrowBook(book2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var book in Library.Books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine(reader.GetInfo());

            reader.ReturnBook(book1);
            Librarian.RemoveBook(book2);

            foreach (var book in Library.Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
