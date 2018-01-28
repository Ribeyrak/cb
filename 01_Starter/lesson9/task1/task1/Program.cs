using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            for (int i = 10; i < array.Length; i--)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте массив размерностью в 10 элементов, выведите на экран все элементы массива в обратном
//порядке