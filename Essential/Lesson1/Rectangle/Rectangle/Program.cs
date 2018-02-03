using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private double side1;
        public double Area
        {
            get { return side1; }
        }
        private double side2;
        public double Perimeter
        {
            get { return side2; }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculator()
        {
            return side1 * side2;
        }

        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значени длинны прямоугильника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение ширины прямоугольника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Периметр = {0}, площадь = {1}", rectangle.Perimeter, rectangle.Area);

            Console.ReadKey();
        }
    }
}
//Требуется: Создать класс с именем Rectangle.  (+)
//В теле класса создать два поля, описывающие длины сторон double side1, side2. 
//Создать пользовательский конструктор Rectangle(double side1, double side2) , в теле которого поля side1 и side2 инициализируются значениями аргументов.
//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator () и периметр прямоугольника - double PerimeterCalculator (). 
//Создать два свойства double Area и double Perimeter с одним методом доступа get.Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
//на экран периметр и площадь.