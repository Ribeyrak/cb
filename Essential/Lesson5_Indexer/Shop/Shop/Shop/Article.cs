using System;

namespace Shop
{
    class Article
    {
        private string[] _product = new string[5];
        private string[] _shop = new string[5];
        private double[] _price = new double[5];

        public Article()
        {
            _product[0] = "Стол";    _shop[0] = "Эпицентр";  _price[0] = Convert.ToDouble("100");
            _product[1] = "Стул";    _shop[1] = "Юск";       _price[1] = Convert.ToDouble("120");
            _product[2] = "Кресло";  _shop[2] = "Эпицентр";  _price[2] = Convert.ToDouble(150);
            _product[3] = "Диван";   _shop[3] = "Юск";       _price[3] = Convert.ToDouble(300);
            _product[4] = "Люстра";  _shop[4] = "Мир деко";  _price[4] = Convert.ToDouble(50);
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _product.Length; i++)
                {
                    if(_product[i] == index)
                        return _product[i] + " - " + _shop[i] + " - " + _price[i];
                }
                return string.Format("{0} - товара нет в наличии.", index);
            }
        }
    }
}
//Создать класс Article, содержащий следующие закрытые поля:
//• название товара;
//• название магазина, в котором продается товар;
//• стоимость товара в гривнах.
//Создать класс Store, содержащий закрытый массив элементов типа Article. 
//Обеспечить следующие возможности: • вывод информации о товаре по номеру с помощью индекса;
//• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, 
//выдать соответствующее сообщение; Написать программу, вывода на экран информацию о товаре.