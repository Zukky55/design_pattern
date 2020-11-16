using System;

namespace Facade.NotUse
{
    public class Librarian
    {
        BookList bookList;
        LendingBook lendingBook;

        public Librarian()
        {
            var bookNames = new string[]{
                "book1",
                "book2",
                "The Facade Pattern",
            };

            bookList = new BookList(bookNames);
            lendingBook = new LendingBook(bookNames[2]);
        }

        public bool SearchBook(string bookName,out Book book)
        {
            var isExist = bookList.SearchBook(bookName,out book);
            if (!isExist)
            {
                Console.WriteLine($"蔵書されていません。");
                return false;
            }

            var isLending = lendingBook.IsLending(bookName);
            if (isLending)
            {
                Console.WriteLine($"貸出中です。");
                return false;
            }

            Console.WriteLine($"ありました！はいこれ！");
            return true;
        }
    }
}
