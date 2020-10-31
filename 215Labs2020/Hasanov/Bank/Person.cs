using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov
{
    abstract class Person
    {
        private static string _surname;
        private static string _name;
        private static string _patronymic;
        public static void name()
        {
            Console.Write("Введите Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string patronymic = Console.ReadLine();
            while (_surname == surname && _name == name && _patronymic == patronymic)
            {
                Console.WriteLine("Извините такой аккаунт уже существует.");
                Console.WriteLine("Попробуйте заново:");
                Console.Write("Введите Фамилию: ");
                surname = Console.ReadLine();
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите Отчество: ");
            }
            _surname = surname;
            _name = name;
            _patronymic = patronymic;
        }
        public abstract void act();
    }
}

