using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class DayOfBirthBonus
    {
        public string name;
        public int day;
        public int month;
        public int year;
        public static int Bonus = 1000;
        public int UserBonus;
        public static int RegBonus = 200;

        public static void Reg()
        {

            DayOfBirthBonus person = new DayOfBirthBonus();

            Console.WriteLine("Добро пожаловать в наш магазин. Пожалуйста пройдите регистрацию.");
            Console.WriteLine($"Сегодняшнее число: {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}");
            Console.WriteLine();
            Console.WriteLine("За регистрацию вы получите 200 бонусных рублей");

            Console.Write("Имя: ");
            person.name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Укажите дату рождения");
            Console.Write("День: ");
            person.day = int.Parse(Console.ReadLine());
            if (person.day < 1 || person.day > 31)
            {
                Console.WriteLine("Введите правильную дату!!!");
                person.day = int.Parse(Console.ReadLine());
            }
            Console.Write("Месяц: ");
            person.month = int.Parse(Console.ReadLine());
            if (person.month < 1 || person.month > 12)
            {
                Console.WriteLine("Введите правильный месяц!!!");
                person.month = int.Parse(Console.ReadLine());
            }
            Console.Write("Год: ");
            person.year = int.Parse(Console.ReadLine());
            if (person.year > DateTime.Now.Year)
            {
                Console.WriteLine("Введите правильный год!!!");
                Console.Write("Год: ");
                person.year = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            person.UserBonus = RegBonus;

            if (person.day == DateTime.Now.Day && person.month == DateTime.Now.Month)
            {
                person.UserBonus = RegBonus + Bonus;
                Console.WriteLine($"Поздравляем Вас с днем рождения и дарим вам 1000 бонусных рублей,мы надеемся что вы с удовольствием будете отпраздновать свое {DateTime.Now.Year - person.year} летие.");

                Console.WriteLine($"Ваш бонусный счет: {person.UserBonus} рублей.");
            }
            else
            {
                Console.WriteLine($"Ваш бонусный счет: {person.UserBonus} рублей.");
            }
            Console.ReadLine();

        }
    }
}
