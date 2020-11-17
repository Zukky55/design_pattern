using System;

namespace Facade.Use
{
    public class Sando
    {
        public void TripToFindBook()
        {
            Console.WriteLine($"sando: あー、ファサードパターンが書いてある本ほしいなぁ。そうだ、図書館に行こう！");
            var librarian = new Librarian();
            Console.WriteLine("sando: スタッフさん！この本さがして！");
            Book book =null;    
            var res =librarian.SearchBook("The Facade Pattern",out book);

            if(res){
                Console.WriteLine($"sando: やったー！{book.Name}みつかった！さんきゅー！");
            }
            else{
                Console.WriteLine($"sando: ないんかーい。かなしみ。");
            }
        }
    }
}