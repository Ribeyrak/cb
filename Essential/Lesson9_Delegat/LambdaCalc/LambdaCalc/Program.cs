using System;

namespace LambdaCalc
{
    public delegate double MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());
            
            MyDelegate del = null;

            Console.WriteLine("Выбирите знак арифметического действия");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    del = (a, b) => { return x + y; };
                    break;
                case "-":
                    del = (a, b) => { return x - y; };
                    break;
                case "*":
                    del = (a, b) => { return x * y; };
                    break;
                case "/":
                    if (y == 0) Console.WriteLine("На ноль делить нельзя");
                    del = (a, b) => { return x / y; };
                    break;

                default:
                {
                    Console.WriteLine("Вы ввели неверный знак арифметического действия");
                    break;
                }
            }

            Console.WriteLine(del(x,y));
            Console.ReadKey();
        }
    }
}
