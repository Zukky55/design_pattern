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
            Console.WriteLine($"sando: あー、ファサードパターンが書いてある本ほしいなぁ。そうだ、図書館に行こう！");
            Console.WriteLine("sando: スタッフさん！この本さがして！... スタッフさんいない...？ あれ...自分でやれってこと...？");
            string targetBookName = "The Facade Pattern";

            // 蔵書一覧の詳細を知らなければならない
            string[] bookNames = new string[]{
                "book1",
                "book2",
                "The Facade Pattern",
            };
            var bookCollections = new BookList(bookNames);

            // 本の貸出票も自分で確認しなければならない。
            var lendingBook = new LendingBook();

            Book book = null;
            if (!bookCollections.SearchBook(targetBookName, out book))
            {
                Console.WriteLine($"sando: そもそもおいてないのかー");
                return;
            }
            else{
                Console.WriteLine($"sando: 蔵書されてる！");
            }

                Console.WriteLine($"sando: 本が借りられてるか調べなきゃ...");
            if (lendingBook.IsLending(book.Name))
            {
                Console.WriteLine($"sando: 借りられてる...");
            }
            else
            {
                Console.WriteLine($"sando: 貸出されてない！やったゲット！！ただ、色々情報探して色々持って大変だったなぁ...");
            }
        }
    }
}