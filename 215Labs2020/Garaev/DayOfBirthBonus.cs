using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev
{
    class DayOfBirthBonus
    {
        public static int bonus
        {
            get
            {
                return 1000;
            }

        }
        public string name;
        public string day;
        public string month;
        public int year;
        public static void g()
        {
            int bonus0 = 0;

            //Console.Write("Введите день: ");
            //string day = Console.ReadLine();
            //Console.Write("Введите день: ");
            //string day = Console.ReadLine();
            //Console.Write("Введите месяц: ");
            //string month = Console.ReadLine();
            //Console.Write("Введите год: ");
            //int year = int.Parse(Console.ReadLine());
            //string Data = day + month;
            //string f = Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Month);
            //int realyear = Convert.ToInt32(DateTime.Now.Year);
            //if (Data == f)
            //    bonus0 += bonus;
            //int age = realyear - year;
            
            //Console.WriteLine($"Вам {age} лет");
            //Console.WriteLine($"Ваши бонусы: {bonus0}");



            Console.Write("Введите количество регистраций: ");
            int col = int.Parse(Console.ReadLine());
            DayOfBirthBonus[] people = new DayOfBirthBonus[col];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new DayOfBirthBonus();
            }
            
            string f = Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Month);
            int realyear = Convert.ToInt32(DateTime.Now.Year);
            for (int k = 0; k < col; k++)
            {
                Console.Write($"{k + 1}) Введите Фвмилию Имя : ");
                people[k].name = Console.ReadLine();
                Console.WriteLine("   Дата рождения:");
                Console.Write("   День: ");
                people[k].day = Console.ReadLine();
                Console.Write("   Месяц: ");
                people[k].month = Console.ReadLine();
                Console.Write("   Год: ");
                people[k].year = int.Parse(Console.ReadLine());
                string Data = people[k].day + people[k].month;
                int age = realyear - people[k].year;
                Console.WriteLine($"   Вам {age} лет");
                if (Data == f)
                {
                    bonus0 += bonus;
                    Console.WriteLine("   Поздравляем вас с днем рождения!!! И дарим вам 1000 бонусов");
                }
                Console.WriteLine($"   Ваши бонусы: {bonus0}");
                Console.WriteLine();
                bonus0 = 0;
            }

        }
    }
}
