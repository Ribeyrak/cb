using System;

namespace Calcul
{
    internal static class Calculator
    {
        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static double Subctraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0) Console.WriteLine("На ноль делить нельзя");
            return a / b;
        }
    }
}