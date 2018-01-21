using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение числа А:");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите значение числа В:");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int x = a++; a < b; a++)
            {
                Console.WriteLine("{0}", x);
                result += a;
            }
            result += a;

            Console.WriteLine("Сумма чисел равна {0}, result");
            Console.ReadKey();
        }
    }
}
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран.
//Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.