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
            
            MyDelegate Add = (a, b) => { return a + b; };
            double add = Add(x,y);
            MyDelegate Sub = (a, b) => { return a - b; };
            double sub = Sub(x, y);             
            MyDelegate Mul = (a, b) => { return x * y; };
            double mul = Mul(x, y);
            MyDelegate Dev = (a, b) => { return x / y; };
            double dev = Dev(x, y);

            Console.WriteLine("Выбирите знак арифметического действия");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine(add);
                    break;
                case "-":
                    Console.WriteLine(sub);
                    break;
                case "*":
                    Console.WriteLine(mul);
                    break;
                case "/":
                    if (y == 0) Console.WriteLine("На ноль делить нельзя");
                    else Console.WriteLine(dev);
                    break;

                default:
                {
                    Console.WriteLine("Вы ввели неверный знак арифметического действия");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
