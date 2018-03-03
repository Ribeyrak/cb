using System;

namespace Class_Struct
{
    internal class MyClass
    {
        public string change;
    }

    internal struct MyStruct
    {
        public string change;
    }

    internal class Program
    {
        private static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        private static void StrucktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        private static void Main(string[] args)
        {
            var _class = new MyClass();
            var _struct = new MyStruct();

            _class.change = "не изменено";
            _struct.change = "не изменено";

            ClassTaker(_class);
            StrucktTaker(_struct);

            Console.WriteLine("Поле класа {0} ", _class.change);
            Console.WriteLine("Поле структуры {0}", _struct.change);

            Console.ReadKey();
        }
    }
}