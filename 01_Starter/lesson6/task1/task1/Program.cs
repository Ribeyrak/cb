using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            
            
            //for (int a = 0; a <= 10; a++)
            //{
            //    for (int b = 0; b <= 12; b++)
            //    {
            //        Console.Write("*");
            //    }
            //
            //    Console.WriteLine();
            //}
               
            Console.ReadKey();
        }
    }
}
//Задание Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте две целочисленные переменные и задайте им некоторые значения.
//Применяя технику вложенных цикл ов, нарисуйте прямоугольник из звездочек.Используйте значения ранее созданных
//переменных для указания высоты и ширин ы прямоугольника.