namespace Shop
{
    class Article
    {
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        private string _name;
        private string _shopName;
        private decimal _price;

        public Article(string name, string shopName, decimal price)
        {
            _name = name;
            _shopName = shopName;
            _price = price;
        }

        public string ToString1()
        {
            return $"Наименование товара: {_name} Название магазина: {_shopName} Цена товара: {_price}";
        }
    }
}
