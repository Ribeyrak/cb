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
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }

            for (int i = array.Length -1; i >= 0; i--)
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