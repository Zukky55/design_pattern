using System.Collections.Generic;

namespace Facade.NotUse
{
    public class LendingBook
    {
        private List<string> lendingList;

        public LendingBook(params string[] lendingList)
        {
            this.lendingList = new List<string>(lendingList);
        }

        public bool IsLending(string bookName)
        {
            return lendingList.Contains(bookName);
        }
    }
}