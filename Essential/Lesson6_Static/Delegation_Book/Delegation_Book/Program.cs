using System;

namespace Delegation_Book
{
    internal class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Find a line " + str);
        }
    }

    internal static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            var book = new Book();
            book.FindNext(str);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("test");

            Console.ReadKey();
        }
    }
}