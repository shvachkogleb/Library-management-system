using System;

namespace Library_management_system
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Guid ISBN { get; private set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = Guid.NewGuid();
            IsAvailable = true;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} (ISBN: {ISBN})";
        }
    }
}
