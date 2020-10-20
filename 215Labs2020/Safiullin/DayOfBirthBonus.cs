using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class DayOfBirthBonus
    {
        public static int DiscountPrice = 100;
        public string name;
        public int day;
        public int mounth;
        public int year;
        public static void Discount()
        {
            bool a = false;
            
            DayOfBirthBonus HUMAN = new DayOfBirthBonus();
            HUMAN = new DayOfBirthBonus();
            Console.Write("Введите своё ФИО: ");
            HUMAN.name = Console.ReadLine();
            Console.Write("Введите день своего рождения: ");
            HUMAN.day = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            HUMAN.mounth = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            HUMAN.year = int.Parse(Console.ReadLine());
            if (HUMAN.day == DateTime.Now.Day & HUMAN.mounth == DateTime.Now.Month)
            {
                DiscountPrice += 1000;
                a = true;
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Бонусная карта магазина \"Детский мир\".");
            if (a)
            {
                Console.WriteLine($"Подзравляем вас {HUMAN.name} с {DateTime.Now.Year - HUMAN.year} летием. Ңелаем вам счатья и процветания!");
                Console.WriteLine("На вашу бонусную карту начислие 1000 бонусов.");
            }
            else { Console.WriteLine($"Владелец карты: {HUMAN.name}"); }
            Console.WriteLine($"Балан карты составляет: {DiscountPrice}");
        } 

    }
}
