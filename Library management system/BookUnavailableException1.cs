using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_management_system
{
    internal class BookUnavailableException : Exception
    {
        public BookUnavailableException() : base("The requested book is not available.") { }
    }
}
