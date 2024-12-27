using System;

namespace Library_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём объект Librarian и Reader
            var librarian = new Librarian("Admin", "admin@library.com");
            var reader = new Reader("HLib", "Hlib@example.com");
            Library.AddUser(reader);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Library Management System ---");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Remove a Book");
                Console.WriteLine("3. Borrow a Book");
                Console.WriteLine("4. Return a Book");
                Console.WriteLine("5. View All Books");
                Console.WriteLine("6. View Reader Information");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBookMenu(librarian);
                        break;

                    case "2":
                        RemoveBookMenu(librarian);
                        break;

                    case "3":
                        BorrowBookMenu(reader);
                        break;

                    case "4":
                        ReturnBookMenu(reader);
                        break;

                    case "5":
                        ViewBooks();
                        break;

                    case "6":
                        Console.WriteLine(reader.GetInfo());
                        break;

                    case "0":
                        exit = true;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddBookMenu(Librarian librarian)
        {
            Console.Write("Enter the book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author: ");
            string author = Console.ReadLine();

            var book = new Book(title, author);
            librarian.AddBook(book);
            Console.WriteLine($"Book '{title}' by {author} added successfully.");
        }

        static void RemoveBookMenu(Librarian librarian)
        {
            Console.Write("Enter the title of the book to remove: ");
            string title = Console.ReadLine();

            var book = Library.Books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                librarian.RemoveBook(book);
                Console.WriteLine($"Book '{title}' removed successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        static void BorrowBookMenu(Reader reader)
        {
            Console.Write("Enter the title of the book to borrow: ");
            string title = Console.ReadLine();

            var book = Library.Books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                try
                {
                    reader.BorrowBook(book);
                    Console.WriteLine($"Book '{book.Title}' borrowed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }


        static void ReturnBookMenu(Reader reader)
        {
            Console.Write("Enter the title of the book to return: ");
            string title = Console.ReadLine();

            var book = reader.BorrowedBooks.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                reader.ReturnBook(book);
                Console.WriteLine($"Book '{book.Title}' returned successfully.");
            }
            else
            {
                Console.WriteLine("You haven't borrowed this book.");
            }
        }

        static void ViewBooks()
        {
            Console.WriteLine("\n--- Available Books ---");
            foreach (var book in Library.Books)
            {
                Console.WriteLine(book);
            }

            if (Library.Books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
            }
        }
    }
}
