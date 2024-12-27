using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Library_management_system
    {
        public interface IBorrowable
        {
            void BorrowBook(Book book);
            void ReturnBook(Book book);
        }

        public interface ILibraryManagement
        {
            void AddBook(Book book);
            void RemoveBook(Book book);
        }

        public interface IUser
        {
            string GetInfo();
        }
    }
