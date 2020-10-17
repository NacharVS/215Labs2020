using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class DayOfBirthBonus
    {
        public static int discount = 100;
        public string name;
        public int day;
        public int month;
        public int year;
        public static void Discont()
        {
            bool a = false;
            DayOfBirthBonus Person = new DayOfBirthBonus();
            Person = new DayOfBirthBonus();
            Console.Write("Введите свою фамилию и имя: ");
            Person.name = Console.ReadLine();
            Console.Write("Введите, день своего рождения: ");
            Person.day = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            Person.month = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            Person.year = int.Parse(Console.ReadLine());
            if (Person.day==DateTime.Now.Day & Person.month== DateTime.Now.Month)
            {
                discount += 1000;
                a = true;
            }
            Console.WriteLine("************************************************");
            Console.WriteLine("Дисконтная карта магазина \"Юношеский Мир\".");
            if (a)
            {
                Console.WriteLine($"Поздровляем вас {Person.name} с {DateTime.Now.Year - Person.year} летием.");
                Console.WriteLine("Желаем счасть, здравия и добра.");
                Console.WriteLine("На вашу карту начисленно 1000 подарочных бонусов."); 
                a = false;
            }
            else { Console.WriteLine($"Владелец карты: {Person.name}."); }
            Console.WriteLine($"Баланс карты составляет: {discount} баллов.");
            Console.WriteLine("************************************************");
        }
        
    }
}
