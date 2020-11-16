using System;

namespace Facade.NotUse
{
    public class Sando
    {
        public void TripToFindBook()
        {
            Console.WriteLine($"あー、ファサードパターンが書いてある本ほしいなぁ。そうだ、図書館に行こう！");
            Console.WriteLine("スタッフさん！この本さがして！... スタッフさんいない...？ あれ...自分でやれってこと...？");
            string wantBookName = "The Facade Pattern";
            string[] bookList = new string[]{
                "book1",
                "book2",
                "The Facade Pattern",
            };

            if(res){
                Console.WriteLine($"やったー！{book.Name}みつかった！さんきゅー！");
            }
            else{
                Console.WriteLine($"ないんかーい。かなしみ。");
            }
        }
    }
}