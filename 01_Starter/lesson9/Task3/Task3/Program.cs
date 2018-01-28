using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int MyRevers(int[] array)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            return array[i];

        }

        static void Main(string[] args)
        {

        }
    }
}
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.Требуется: 
//1) Создать метод MyReverse(int[] array), который принимает в качестве аргумента массив целочисленных элементов и возвращает инвертированный массив
//(элементы массива в обратном порядке) . 
//2) Создайте метод int[] SubArray(int[] array, int index, int count) . 
//Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции указанной в аргументе index, 
//размерностью, которая соответствует значению аргумента count.
//Если аргумент count содержит значение больше чем количество элементов, которые входят в выбираемую часть исходного массива 
//(от указанного индекса index, до индекса последнего элемента), 
//то при формировании нового массива размерностью в count, заполните единицами те элементы, которые не были скопированы из исходного массива.