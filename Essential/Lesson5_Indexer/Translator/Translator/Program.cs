using System;


namespace Translator
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] ukr = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; ukr[0] = "книга";
            key[1] = "ручка"; value[1] = "pen"; ukr[1] = "ручка";
            key[2] = "солнце"; value[2] = "sun"; ukr[2] = "сонце";
            key[3] = "яблоко"; value[3] = "apple"; ukr[3] = "яблуко";
            key[4] = "стол"; value[4] = "table"; ukr[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i] + " - " + ukr[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index] + " - " + ukr[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}

//Расширьте пример 5 (русско-английский словарь) еще и украинским словарем.Реализуйте возможность
//поиска не только по ключевым русским словам и словам на остальных языках.