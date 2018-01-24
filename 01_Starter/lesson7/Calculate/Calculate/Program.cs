using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static int Calculate(int a, int b, int c)
        {
            return ((a + b + c) / 3);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = Calculate(a,b,c);
            Console.WriteLine("Срезнее арифметическое значение равно: {0}", sum);

            Console.ReadKey();
        }
    }
}
