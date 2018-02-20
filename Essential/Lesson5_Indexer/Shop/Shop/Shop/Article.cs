using System;
using System.Collections.Generic;
namespace Shop
{
    class Article
    {
        private string _name;
        private string _shopName;
        private decimal _price;
                
        public Article(string name, string shopName, decimal price)
        {
            _name = name;
            _shopName = shopName;
            _price = price;
        }
        
        public override string ToString()
        {
        return $"Наименование товара: {_name} Название магазина: {_shopName} Цена товара: {_price}";
        }
    }
}
