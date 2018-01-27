using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static int Fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
            }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во клиентов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact = Fact(n);
            Console.WriteLine("Кол-во вариантов доставки = {0}", fact);

            Console.ReadKey();
        }
    }
}
//Имеется N клиентов, которым компания производитель должна доставить товар.
//Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина? 
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Напишите программу, которая будет рассчитывать и выводить на экран количество возможных вариантов доставки товара. 
//Для решения задачи, используйте факториал N !, рассчитываемый с помощью рекурсии. 
//Объясните, почему не рекомендуется использовать рекурсию для расчета факториала. Укажите слабые места данного подхода.