using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Bank
{
    abstract class BankPerson
    {
        private static string _surname;
        private static string _name;
        private static string _otchestvo;
        public static void name()
        {
            Console.Write("Введите Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string otchestvo = Console.ReadLine();
            while (_surname == surname && _name == name && _otchestvo == otchestvo)
            {
                Console.WriteLine("Извините такой аккаунт уже существует.");
                Console.WriteLine("Попробуйте заново:");
                Console.Write("Введите Фамилия: ");
                surname = Console.ReadLine();
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите Отчество: ");
            }
            _surname = surname;
            _name = name;
            _otchestvo = otchestvo;
        }
        public abstract void Deystvya();
    }
}
