using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    class Address
    {
        private string index;
        public string Index
        {
            set { index = value; }
            get { return index; }
        }

        private string country;
        public string Country
        {
            set { country = value; }
            get { return country; }
        }

        private string city;
        public string City
        {
            set { city = value; }
            get { return city; }
        }

        private string street;
        public string Street
        {
            set { street = value; }
            get { return street; }
        }

        private string house;
        public string House
        {
            set { house = value; }
            get { return house; }
        }

        private string apartament;
        public string Apartament
        {
            set { apartament = value; }
            get { return apartament; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Address instance = new Address();
            instance.Index = "02217, ";
            instance.Country = "Ukraine, ";
            instance.City = "Kiyv, ";
            instance.Street = "Drayzera st., ";
            instance.House = "house 10, ";
            instance.Apartament = "ap 180 ";

            Console.Write(instance.Index);
            Console.Write(instance.Country);
            Console.Write(instance.City);
            Console.Write(instance.Street);
            Console.Write(instance.House);
            Console.Write(instance.Apartament);

            Console.ReadKey();
        }
    }
}
//Требуется: Создать класс с именем Address.
//В теле класса требуется создать поля : index, country, city, street, house, apartment.
//Для каждого поля, создать свойство с двумя методами доступа.Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе. 
//Выведите на экран значения полей , описывающих адрес.