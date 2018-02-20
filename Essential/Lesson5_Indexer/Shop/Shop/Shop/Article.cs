using System;
using System.Collections.Generic;

namespace Shop
{
    class Article
    {
        public string _name     { get; set; }
        public string _shopName { get; set; }
        public decimal _price   { get; set; }

        
        public void ToString(string _name, string _shopName, decimal _price)
        {
            Console.WriteLine("Наименование товара: {0}\nНазвание магазина {1}\nЦена товара {2} грн.", _name, _shopName, _price);
        }
        
        public string ToString1()
        {
        return "Наименование товара: " + _name + " Название магазина: " + _shopName + " Цена товара: " + _price;
        }
        
    }
}
