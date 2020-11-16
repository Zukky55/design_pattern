using System.Collections.Generic;

namespace Facade.NotUse
{
    public class BookList
    {
        private List<Book> bookList;
        private Book keepedBook;

        public BookList(string[] bookNames)
        {
            bookList = new List<Book>();
            foreach (var bookName in bookNames)
            {
                bookList.Add(new Book(bookName));
            }
        }
        public bool SearchBook(string bookName,out Book foundBook)
        {
            foreach (var book in bookList)
            {
                if (book.Name == bookName)
                {
                    foundBook = book;
                    return true;
                }
            }
            foundBook=null;
            return false;
        }
    }
}