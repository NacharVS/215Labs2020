using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sharipov
{
    class DayofbirthBonus
    {
        public string name;
        public string surname;
        public int day;
        public int month;
        public int year;
        public static int bonuscard = 0;
        public static int BirthBonus()
        {
            bonuscard += 1500;
            return bonuscard;
        }
        public static void Client()
        {
            DayofbirthBonus BirthDay = new DayofbirthBonus();
            DayofbirthBonus BirthMonth = new DayofbirthBonus();
            DayofbirthBonus BirthYear = new DayofbirthBonus();
            DayofbirthBonus BaseName = new DayofbirthBonus();
            DayofbirthBonus BaseSurname = new DayofbirthBonus();
            Console.WriteLine("Ваше имя");
            BaseName.name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия");
            BaseSurname.surname = Console.ReadLine();
            Console.WriteLine("Ваш день рождения");
            BirthDay.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш месяц рождения");
            BirthMonth.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш год рождения");
            BirthYear.year = int.Parse(Console.ReadLine());
            if ((BirthDay.day == DateTime.Now.Day) & (BirthMonth.month == DateTime.Now.Month))
            {
                BirthBonus();
                Console.WriteLine($"Ура! Сегодня поздравляем Вас с Вашим {DateTime.Now.Year - BirthYear.year}-ым днем рождением! В честь этого на Ваш виртуальный счет начисляется 1500 крабсов");
                Console.WriteLine($"Регистрация успешно завершена. Ваше имя {BaseName.name} {BaseSurname.surname}, Вам {DateTime.Now.Year - BirthYear.year} лет, на Вашем счету: {bonuscard} крабсов");
            }
            else
            {
                Console.WriteLine($"Регистрация успешно завершена. Ваше имя {BaseName.name} {BaseSurname.surname}, Вам {DateTime.Now.Year - BirthYear.year} лет, на Вашем счету: {bonuscard} крабсов");
            }

        }
    }
}
