using System;

namespace GenericLikeList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            string str = Console.ReadLine();
            int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new MyList<int>();

            var t = new Random();
            for (int x = 0; x < u; x++) list.Add(t.Next(100));

            Console.WriteLine("Массив элементов:");
            for (int i = 0; i < list.Count; i++) Console.WriteLine(list[i] + " ");
            Console.WriteLine();
            Console.Write(new string('-',30));

            Console.WriteLine("Введите значение для поиска:");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
                Console.WriteLine("Введенное значение содержиться в массиве");
            else
                Console.WriteLine("Значение не найдено");

            Console.ReadLine();
        }
    }
}
