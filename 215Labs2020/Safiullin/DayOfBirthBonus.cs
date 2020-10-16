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
            DateTime dateTime = new DateTime();


            
            DayOfBirthBonus HUMAN = new DayOfBirthBonus();
            HUMAN = new DayOfBirthBonus();
            Console.Write("Введите своё ФИО: ");
            HUMAN.name = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            Console.Write("День: ");
            HUMAN.day = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            HUMAN.mounth = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            HUMAN.year = int.Parse(Console.ReadLine());

        } 
    }
}
