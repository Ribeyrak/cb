using System;

namespace Class_Struct
{
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StrucktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            MyClass _class = new MyClass();
            MyStruct _struct = new MyStruct();

            _class.change = "не изменено";
            _struct.change = "не изменено";

            ClassTaker(_class);
            StrucktTaker(_struct);

            Console.WriteLine("Поле класа {0} ",_class.change);
            Console.WriteLine("Поле структуры {0}",_struct.change);

            Console.ReadKey();
        }
    }
}
