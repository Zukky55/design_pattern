using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Facade.NotUse
{
    public class Sando
    {
        public void TripToFindBook()
        {
            Console.WriteLine($"あー、ファサードパターンが書いてある本ほしいなぁ。そうだ、図書館に行こう！");
            Console.WriteLine("スタッフさん！この本さがして！... スタッフさんいない...？ あれ...自分でやれってこと...？");
            string targetBookName = "The Facade Pattern";

            // 蔵書一覧の詳細を知らなければならない
            string[] bookNames = new string[]{
                "book1",
                "book2",
                "Dummy The Facade Pattern",
            };
            var bookCollections = new BookList(bookNames);

            // 本の貸出票も自分で確認しなければならない。
            var lendingBook = new LendingBook();

            Book book = null;
            if (!bookCollections.SearchBook(targetBookName, out book))
            {
                Console.WriteLine($"そもそもおいてないのかー");
                return;
            }


            if (lendingBook.IsLending(book.Name))
            {
                Console.WriteLine($"借りられてる...");
            }
            else
            {
                Console.WriteLine($"やったゲット！！ただ、色々情報探して色々持って大変だったなぁ...");
            }
        }
    }
}