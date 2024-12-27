using System.Collections.Generic;

namespace Library_management_system
{
    public class Reader : Person, IBorrowable
    {
        public List<Book> BorrowedBooks { get; private set; }

        public Reader(string name, string email) : base(name, email)
        {
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= 3)
                throw new TooManyBooksException();
            if (!book.IsAvailable)
                throw new BookUnavailableException();

            BorrowedBooks.Add(book);
            book.IsAvailable = false;
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Remove(book))
                book.IsAvailable = true;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Borrowed Books: {string.Join(", ", BorrowedBooks)}";
        }
    }
}
