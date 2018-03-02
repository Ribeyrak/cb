using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    struct Notebook
    {
        private int model;
        private string manufacturer;
        private decimal price;

        public Notebook(int model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine("Test Show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
