using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static int[] MyRevers(int[] array)
        {
            int buf = 0;
            int n = array.Length;
            int j = n - 1;

            for (int k = 0; k < j; k++)
            {
                buf = array[k];
                array[k] = array[j];
                array[j] = buf;
                j--;
            }
            
            return array;

        }

        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
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