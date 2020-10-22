using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov
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

        public static void ClientInfo()
        {
            DayOfBirthBonus Birthday = new DayOfBirthBonus();
            DayOfBirthBonus BirthMonth = new DayOfBirthBonus();
            DayOfBirthBonus BirthYear = new DayOfBirthBonus();
            DayOfBirthBonus BaseName = new DayOfBirthBonus();
            DayOfBirthBonus BaseSurname = new DayOfBirthBonus();
            Console.WriteLine("Имя : ");
            BaseName.name = Console.ReadLine();
            Console.WriteLine("Фамилия :");
            BaseSurname.surname = Console.ReadLine();
            Console.WriteLine("День рождения: ");
            Birthday.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц рождения: ");
            BirthMonth.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Год рождения: ");
            BirthYear.year = int.Parse(Console.ReadLine());
            if (Birthday.day == DateTime.Now.Day & BirthMonth.month == DateTime.Now.Month)
            {
                BirthBonus();
                Console.WriteLine($"Поздравляем! Вам исполнилось {DateTime.Now.Year - BirthYear.year} лет. Вам зачислено 1000 бонусных баллов: {bonuspoints}");
            }
            else
            {
                Console.WriteLine($"Кол-во бонусных баллов: {bonuspoints}");
            }



        }

    }
}
