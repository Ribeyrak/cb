using System;
using System.Collections;

namespace ArrayList_Task1
{
    class MyClass
    {
        public int MyInt { get; set; }
        public string MyString { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add(-25);
            arrayList.Add(5.57);
            arrayList.Add('w');
            arrayList.Add("text");
            arrayList.Add(new MyClass());

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.ReadKey();
        }
    }
}