using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov
{
    class DayOfBirthBonus
    {
        public string name;
        public int day;
        public int month;
        public int year;
        public static int userpoints = 0;
         public static int addedpoints()
        {
            userpoints += 1000;
            return userpoints;
        }
        public static void login()
        {
            DayOfBirthBonus birthDay = new DayOfBirthBonus();
            DayOfBirthBonus birthMonth = new DayOfBirthBonus();
            DayOfBirthBonus birthYear = new DayOfBirthBonus();
            DayOfBirthBonus names = new DayOfBirthBonus();
            Console.WriteLine("Ваше имя:");
            names.name = Console.ReadLine();
            Console.WriteLine("Твой день рождения:");
            birthDay.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Твой месяц рождения:");
            birthMonth.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Твой год рождения:");
            birthYear.year = int.Parse(Console.ReadLine());
            if (birthDay.day == DateTime.Now.Day & birthMonth.month == DateTime.Now.Month)
            {
                addedpoints();
                Console.WriteLine($"У тебя день рождения!!! Твой возраст {DateTime.Now.Year - birthYear.year} .Тебе начисленно 1000 бонусов!");
            }
            Console.WriteLine($"Твой баланс: {userpoints}");
        }
    }


}
