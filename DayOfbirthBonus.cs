using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.bULAT
{
    class DayOfBirthBonus
    {
        public string name;
        public int day;
        public int month;
        public int year;
        public static int userpoints = 0;
        public static int points()
        {
            points += 1;
            return userpoints;
        }
        public static void login()
        {
            DayOfBirthBonus Day = new DayOfBirthBonus();
            DayOfBirthBonus Month = new DayOfBirthBonus();
            DayOfBirthBonus Year = new DayOfBirthBonus();
            DayOfBirthBonus names = new DayOfBirthBonus();
            Console.WriteLine("Your Name");
            names.name = Console.ReadLine();
            Console.WriteLine("Your Day of Birth");
            birthDay.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Month of Birth");
            birthMonth.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Year of Birth");
            birthYear.year = int.Parse(Console.ReadLine());
           
        }
    }
}

