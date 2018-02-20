using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Store();
            shop.Add(new Article("Table", "Jusk", 2500));
            shop.Add(new Article("TV", "Comfy", 10250));
            shop.Add(new Article("Phone", "Rozetka", 8500));

            var article1 = shop.GetArticle(1);
            var article2 = shop.GetArticle("Table");

            Console.ReadKey();
        }
    }
}

