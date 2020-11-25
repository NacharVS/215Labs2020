using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei
{
    class DayOfBirthBonus
    {
        public static string name;
        public static string surname;
        public static int day;
        public static int mounth;
        private static int year;
        public static int bonuses;

        public static void method()
        {
            Console.WriteLine("Enter your name");
            DayOfBirthBonus.name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            DayOfBirthBonus.surname = Console.ReadLine();
            Console.WriteLine("Enter day of your biryhday");
            DayOfBirthBonus.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mounth of your biryhday");
            DayOfBirthBonus.mounth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year of your biryhday");
            DayOfBirthBonus.year = int.Parse(Console.ReadLine());
            int day1 = DateTime.Now.Day;
            int mounth1 = DateTime.Now.Month;
            if (day1 == DayOfBirthBonus.day && mounth1 == DayOfBirthBonus.mounth)
            {
                DayOfBirthBonus.bonuses += 1000;
                Console.WriteLine($"Dear {DayOfBirthBonus.name} {DayOfBirthBonus.surname}, you have {DayOfBirthBonus.bonuses} bonuses on your bonuses card, Happy Birthday to you)))))");
            }
            else
                Console.WriteLine($"We have only {DayOfBirthBonus.bonuses} bonuses on your card");
        }
    }
}
