using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во клиентов:");
            int client = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            
            do
            {
                factorial *= client--;
            }
            while (client > 0);

            Console.WriteLine("Кол-во возможных маршрутов: {0}", factorial);
            Console.ReadKey();
        }
    }
}
//Имеется N клиентов, которым компания производитель должна доставить товар.
//Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина? 
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.
//Для решения задачи, используйте факториал N !, рассчитываемый с помощью цикла do -while.
