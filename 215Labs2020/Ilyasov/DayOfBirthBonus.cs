using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _215Labs2020.Ilyasov
{
    class DayOfBirthBonus
    {
        public string name;
        public string surname;
        public int day;
        public int month;
        public int year;
        public static int bonuscard = 0;
        public static int BirthBonus()
        {
            bonuscard += 1000;
            return bonuscard;
        }
        public static void Client()
        {
            DayOfBirthBonus BirthDay = new DayOfBirthBonus();
            DayOfBirthBonus BirthMonth = new DayOfBirthBonus();
            DayOfBirthBonus BirthYear = new DayOfBirthBonus();
            DayOfBirthBonus BaseName = new DayOfBirthBonus();
            DayOfBirthBonus BaseSurname = new DayOfBirthBonus();
            Console.WriteLine("Ваше имя:");
            BaseName.name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия :");
            BaseSurname.surname = Console.ReadLine();
            Console.WriteLine("Ваш день рождения:");
            BirthDay.day= int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш месяц рождения:");
            BirthMonth.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш год рождения:");
            BirthYear.year = int.Parse(Console.ReadLine());
            if (BirthDay.day == DateTime.Now.Day & BirthMonth.month == DateTime.Now.Month)
            {
                BirthBonus();
                Console.WriteLine($"Поздравляем вас, с вашим {DateTime.Now.Year - BirthYear.year}-ым днём рождения! В честь этого на вашу карту зачислен бонус в размере 1000 коинов");
                Console.WriteLine($"Регистрация завершена.Вас зовут {BaseName.name} {BaseSurname.surname}, вам {DateTime.Now.Year - BirthYear.year} лет, на вашем счету: {bonuscard} бонусов");
            }
            else
            {
                Console.WriteLine($"Регистрация завершена.Вас зовут {BaseName.name} {BaseSurname.surname}, вам {DateTime.Now.Year - BirthYear.year} лет, на вашем счету: {bonuscard} бонусов");
            }

        }

    }
}
