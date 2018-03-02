using System;

namespace Note
{
    internal struct Notebook
    {
        public int Model { get; }

        public string Manufacture { get; }

        public decimal Price { get; }

        public Notebook(int model, string manufacturer, decimal price)
        {
            Model = model;
            Manufacture = manufacturer;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine(Model);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var instance = new Notebook(164,"tets",65);

            //instance.Model = 164;
            //instance.Manufacture = "Bomba";
            //instance.Price = 55;
            instance.Show();

            Console.ReadKey();
        }
    }
}