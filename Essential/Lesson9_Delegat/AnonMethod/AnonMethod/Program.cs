using System;

namespace AnonMethod
{
    public delegate int Delegate(int a, int b, int c);

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int z = Convert.ToInt32(Console.ReadLine());

            Delegate myDelegate = (a, b, c) => { return (a + b + c) / 3; };
            int sum = myDelegate(x, y, z);

            Console.WriteLine("Среднее значение равное {0}", sum);

            Console.ReadKey();
        }
    }
}