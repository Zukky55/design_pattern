using System;

namespace Facade.Use
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
            lendingBook = new LendingBook(bookNames[1]);
        }

        public bool SearchBook(string bookName,out Book book)
        {
                Console.WriteLine($"librarian: 蔵書check...");
            var isExist = bookList.SearchBook(bookName,out book);
            if (!isExist)
            {
                Console.WriteLine($"librarian: 蔵書されていません。");
                return false;
            }
            else{
                Console.WriteLine($"librarian: 蔵書されてた！");
            }

                Console.WriteLine($"librarian: 貸出check...");
            var isLending = lendingBook.IsLending(bookName);
            if (isLending)
            {
                Console.WriteLine($"librarian: 貸出中です。");
                return false;
            }

            Console.WriteLine($"librarian: ありました！はいこれ！");
            return true;
        }
    }
}
