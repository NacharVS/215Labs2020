using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class DayOfBirthBonus
    {
        public static int discount = 100;
        public string name;
        public int day;
        public int month;
        public int year;
        public static void Discont()
        {
            DateTime dateTime = new DateTime();

            DayOfBirthBonus Person = new DayOfBirthBonus();
            Person = new DayOfBirthBonus();
            Console.Write("Введите свою фамилию и имя: ");
            Person.name = Console.ReadLine();
            Console.WriteLine("Введите, дату своего рождения:");
            Console.Write("День: ");
            Person.day = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            Person.month = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            Person.year = int.Parse(Console.ReadLine());
            if 
        }
        
    }
}
