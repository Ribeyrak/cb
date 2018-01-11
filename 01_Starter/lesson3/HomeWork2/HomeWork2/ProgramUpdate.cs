using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3;
            float b = 2;
            float c = 0;

            c = (a / b + 1) * 2;

            Console.Write("При переменной равной - ");
            Console.WriteLine(c);

            //Площадь круга
            const float pi = 3.141f;
            double r = Math.Pow(c, 2);
            double p = pi * r;
            Console.Write("Площадь круга составит - ");
            Console.WriteLine(p);

            //Объем цилиндра
            double h = r;
            double v = pi * r * h;
            Console.Write("Объем цилиндра - ");
            Console.WriteLine(v);

            //Площадь цилиндра
            double s = (2 * pi * r) + (2 * pi * r);
            Console.Write("Площадь цилиндра - ");
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
