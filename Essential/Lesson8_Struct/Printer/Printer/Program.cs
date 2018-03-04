using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    enum Colors
    {
        Red,
        Yellow,
        Green,
        Blue,
   }

    static class MyClass
    {
        static void Print(string stroka, int color)
        {
            stroka = Console.ReadLine();
            switch (color)
            {
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }

            Console.BackgroundColor = ConsoleColor.Cyan;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tets");

            Console.ReadKey();
        }
    }
}
