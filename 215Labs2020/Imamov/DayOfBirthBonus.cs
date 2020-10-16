using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace _215Labs2020.Imamov
{
    class DayOfBirthBonus
    {
        public string name;
        public string surname;
        public int day;
        public int month;
        public int year;
        public static int bonuspoints = 0;
        public static int BirthBonus()
        {
            bonuspoints += 1000;
            return bonuspoints;
        }
        public static void login()
        {
            DayOfBirthBonus BirthDay = new DayOfBirthBonus();
            DayOfBirthBonus BirthMonth = new DayOfBirthBonus();
            DayOfBirthBonus BirthYear = new DayOfBirthBonus();
            DayOfBirthBonus BaseName = new DayOfBirthBonus();
            DayOfBirthBonus BaseSurname = new DayOfBirthBonus();
            Console.WriteLine("Имя: ");
            BaseName.name = Console.ReadLine();
            Console.WriteLine("Фамилия: ");
            BaseSurname.surname = Console.ReadLine();
            Console.WriteLine("День рождения: ");
            BirthDay.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц рождения: ");
            BirthMonth.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Год родждения: ");
            BirthYear.year = int.Parse(Console.ReadLine());
            if (BirthDay.day == DateTime.Now.Day & BirthMonth.month == DateTime.Now.Month);
            {
                BirthBonus();
                Console.WriteLine("Поздравляем! Вам исполнилось (DateTime.Now.Year - BirthYear.year) лет. Вам зачисленны 1000 бонусных баллов");
            }
        }
    }
}
