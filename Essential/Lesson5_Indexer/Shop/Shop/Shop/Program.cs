using System;
using System.Collections.Generic;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articls = new List<Article>(3);
            articls.Add(new Article() { _name = "Table", _shopName = "Jusk", _price = 2500 });
            articls.Add(new Article() { _name = "TV", _shopName = "Comfy", _price = 10250 });
            articls.Add(new Article() { _name = "Phone", _shopName = "Rozetka", _price = 8500 });

            foreach (Article p in articls)
            {
                Console.WriteLine(p._name);// d._shopName, c._price);
            }
            foreach (Article d in articls)
            {
                Console.WriteLine(d._shopName);
            }

            Console.ReadKey();
        }
    }
}

