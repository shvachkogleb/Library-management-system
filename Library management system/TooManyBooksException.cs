using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_management_system
{
    internal class TooManyBooksException : Exception
    {
        public TooManyBooksException() : base("Reader cannot borrow more than 3 books.") { }
    }
}
