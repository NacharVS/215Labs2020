using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov
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
            Console.WriteLine("Your Name");
            names.name = Console.ReadLine();
            Console.WriteLine("Your Day of Birth");
            birthDay.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Month of Birth");
            birthMonth.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Year of Birth   ");
            birthYear.year = int.Parse(Console.ReadLine());
            if (birthDay.day == DateTime.Now.Day & birthMonth.month == DateTime.Now.Month)
            {
                addedpoints();
                Console.WriteLine($"You are now {DateTime.Now.Year - birthYear.year} years old");
            }
            Console.WriteLine($"You have {userpoints} points");
        }
    }
}
