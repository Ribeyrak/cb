using System;

namespace Note
{
    internal struct Notebook
    {
        public string Model { get; }

        public string Manufacture { get; }

        public decimal Price { get; }

        public Notebook(string model, string manufacturer, decimal price)
        {
            Model = model;
            Manufacture = manufacturer;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine("Модель товара {0} от производителя {1} стоимостью {2} грн.", Model, Manufacture, Price);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var instance = new Notebook("AA7413R", "Gogo", 15000);
            instance.Show();

            Console.ReadKey();
        }
    }
}