using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов: ");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            int max = 0, min = 0, sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            max = array[0];
            min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    Console.WriteLine("Число не честное: {0}", array[i]);
                }

                if (max < array[i])
                {
                    max = array[i];
                }

                if (min > array[i])
                {
                    min = array[i];
                }

                sum += array[i];
            }

            Console.WriteLine("Найбольшее значение массива: {0}", max);
            Console.WriteLine("Найменьшее значение массива: {0}", min);
            Console.WriteLine("Сумма всех элементов: {0}", sum);
            Console.WriteLine("Среднее арифметичкское: {0}", sum / array.Length);

            Console.ReadKey();
        }
    }
}
