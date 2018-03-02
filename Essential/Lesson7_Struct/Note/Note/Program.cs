using System;

namespace Note
{
    struct Notebook
    {
        private string _model;
        private string _manufacturer;
        private decimal _price;

        public string Model
        {
            get { return _model; }
        }

        public string Manufacture
        {
            get { return _manufacturer; }
        }

        public decimal Price
        {
            get { return _price; }
        }

        public Notebook(string model, string manufacturer, decimal price)
        {
            this._model = model;
            this._manufacturer = manufacturer;
            this._price = price;
        }

        public void Show()
        {
            Console.WriteLine("Модель товара {0} от производителя {1} стоимостью {2} грн.", _model, _manufacturer, _price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook instance = new Notebook("AA7413R", "Gogo", 15000);
            instance.Show();

            Console.ReadKey();
        }
    }
}
