using System;

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
        public static void Print(string stroka, int color)
        {
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
            Console.WriteLine(stroka);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой текст:");
            string stroka = Console.ReadLine();
            Console.WriteLine("Выбирите цвет для текста: 0 - Red, 1 - Yellow, 2 - Green, 3 - Blue");
            int color = Convert.ToInt32(Console.ReadLine());

            MyClass.Print(stroka, color);

            Console.ReadKey();
        }
    }
}
