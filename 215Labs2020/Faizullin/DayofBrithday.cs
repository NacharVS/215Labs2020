using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin
{
    class DayofBrithday
    {
        private static string name;
        private static int day;
        private static int age;
        private static int mounth;
        private static int bonus;

        public static void Bonus()
        {
            Console.WriteLine("Hello, welcome to our shop");
            Console.WriteLine("**************************");
            DayofBrithday.name = Console.ReadLine();
            Console.WriteLine("Enter day your biryhday");
            Console.WriteLine("**************************");
            DayofBrithday.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your age");
            Console.WriteLine("**************************");
            DayofBrithday.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter mouth your biryhday");
            Console.WriteLine("**************************");
            DayofBrithday.mounth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year your biryhday");
            Console.WriteLine("**************************");
            DayofBrithday.day = int.Parse(Console.ReadLine());
            int a = DateTime.Now.Day;
            int b = DateTime.Now.Month;
            if (a == DayofBrithday.day && b == DayofBrithday.mounth)
            {
                DayofBrithday.bonus += 500;
                Console.WriteLine($"{ DayofBrithday.name}, you have {DayofBrithday.bonus} bonus");
            }
            else
                Console.WriteLine($"You have {DayofBrithday.bonus}bonus");
        }
    }
}
