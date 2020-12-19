using System;
using System.Collections;
using System.Collections.Generic;

namespace _215Labs2020.Sadukov.User
{
    class User : Bank
    {




        public User(string Name, string Surname, int Day, int Month, int Age, string Email, double Money)
        {
            name = Name;
            surname = Surname;
            day = Day;
            month = Month;
            age = Age;
            email = Email;
            money = Money;

        }
        private static Dictionary<int, User> PersonInfo = new Dictionary<int, User>();
        public static void Check()
        {
            Console.WriteLine($"Login as Employee or User?");
            Console.WriteLine($"Enter 1 to login as Employee or enter 2 to login as User");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    Employee.Login();
                    break;
                case "2":
                    User.Login();
                    break;
                case "3":

                    break;
            }

        }

        private static void GetInfo()
        {
            foreach (var item in PersonInfo)
            {
                Console.WriteLine($"Имя: {item.Value.Name}, Фамилия: {item.Value.Surname}, День рождения: {item.Value.Day}, Месяц рождения: {item.Value.Age}, Год рождения: {item.Value.Age},E-mail:{item.Value.Email},Money:{item.Value.Money}");
            }
        }

        public static void Login()
        {
            PersonInfo.Add(1111, new User("Аяз", "сАДЫКОВ", 13, 12, 2003, "@", 10000));
            GetInfo();
            PersonInfo[1111].put(10000);
            GetInfo();
            PersonInfo[1111].SetName("Рузаль");
            PersonInfo[1111].SetEmail("a@");
            PersonInfo[1111].SetSurname("Сабиров");
            GetInfo();
            PersonInfo[1111].deposit1(10000);
            GetInfo();
        }
    }
}
