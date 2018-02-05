using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace User
{
    class User
    {
        string login;
        string name;
        string family;
        int age;
                
        public readonly DateTime dataRegistration;
                      
        public string Login
        {
            set { login = value; }
            get { return login; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Family
        {
            set { family = value; }
            get { return family; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public User()
        {
            dataRegistration = DateTime.Now;
        }

        public User(string login, string name, string family, int age)
        {
            this.login = login;
            this.name = name;
            this.family = family;
            this.age = age;
            dataRegistration = DateTime.Now;
        }
        


    }

    class Program
    {
        static void Main()
        {
            User user = new User();

            user.Login = "kartas";
            user.Name = "Super";
            user.Family = "Mario";
            user.Age = 17;

            Console.WriteLine(user.Login);
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Family);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.dataRegistration.ToString());

            Console.Write("Press <Enter> to exit... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}
        }
    }
}
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
//Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.
