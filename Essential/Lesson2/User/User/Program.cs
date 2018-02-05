//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace User
{
    class User
    {
        User user = null;

        void Method()
        {
            string login = "Dendi";
            string name = "Super";
            string family = "Mario";
            string age = "17";
        }
        readonly string dataRegistration;
        public User()
        {
            dataRegistration = "Дата регистрации: 20.06.2016";
        }
        public void CallMethod()
        {
            user = new User();
            user.Method();
        }
    }

    class Program
    {
        static void Main()
        {
            User user = new User();
            user.CallMethod();
            
            Console.ReadKey();
        }
    }
}
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
//Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.
