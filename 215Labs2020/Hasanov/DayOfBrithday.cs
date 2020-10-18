using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov
{
    class DayOfBrithday
    {
        public string _name;
        public int _year;
        public int _month;
        public int _day;
        public static int _personalBonus = 0;


        public static void Bonus(int day, int month, int year)

        {
            int a = DateTime.Now.Day;
            int b = DateTime.Now.Month;
            int c = DateTime.Now.Year;
            int g = 1000;
            int h = 0;
            if (day == a & month == b)
                h = c - year;
            if (day == a & month == b)
                Console.WriteLine($"Ваш возраст {h}") ;
            if (day == a & month == b)
                Console.WriteLine($"Поздравляем!Сегодня у вас день рождения, на ваш счет начисляется 1000 бонусов!На вашем счету {_personalBonus = _personalBonus + g}");
            else
                Console.WriteLine("Спасибо за регистрацию, когда у вас будет день рождения мы вам начислим 1000 бонусов!");
        }
        public static void Registration()
        {
            Console.WriteLine("Добрый день, пожалуйста пройдите простую регистрацию в нашем магазине.");
            Console.WriteLine("Назовите свое имя");
            DayOfBrithday person = new DayOfBrithday();
            person._name = Console.ReadLine();
            Console.WriteLine("Введите ваш дату вашего рождения (день, месяц, год)");
            person._day = int.Parse(Console.ReadLine());
            person._month = int.Parse(Console.ReadLine());
            person._year = int.Parse(Console.ReadLine());
            DayOfBrithday.Bonus(person._day, person._month, person._year);

        }


    }
}

