using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a <= 10; a++)
            {
                for (int b = 0; b <= 12; b++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
               
            Console.ReadKey();
        }
    }
}
//Задание Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте две целочисленные переменные и задайте им некоторые значения.
//Применяя технику вложенных цикл ов, нарисуйте прямоугольник из звездочек.Используйте значения ранее созданных
//переменных для указания высоты и ширин ы прямоугольника.