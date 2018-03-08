using System;

namespace AnonMethod
{
    public delegate int Delegate(int a, int b, int c);

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Vvedite 1 chislo");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vtoroe chislo");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3 chislo");
            int z = Convert.ToInt32(Console.ReadLine());

            Delegate myDelegate;
            myDelegate = (a, b, c) => { return (a + b + c) / 3; };
            int sum = myDelegate(x, y, z);

            Console.WriteLine("Среднее значение равное {0}", sum);

            Console.ReadKey();
        }
    }
}