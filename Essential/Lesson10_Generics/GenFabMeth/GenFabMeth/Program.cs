using System;

namespace GenFabMeth
{
    internal class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = MyClass<int>.FactoryMethod();

            Console.WriteLine(i.GetType().Name);
            Program p = MyClass<Program>.FactoryMethod();

            Console.WriteLine(p.GetType().Name);

            Console.ReadKey();
        }
    }
}