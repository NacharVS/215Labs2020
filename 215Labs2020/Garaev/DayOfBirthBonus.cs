using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev
{
    class DayOfBirthBonus
    {
        int a = 0;
        public string data;
        public string Data
        {
            get
            {
                return data;
            }
            set
            {
                string f = Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Day);
                if (value == f)
                    a = 1000;
            }
        }
        public void g()
        {
            Console.Write("Введите день: ");
            string day = Console.ReadLine();
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            string Data = day + month;
            
            Console.WriteLine(a);
        }
    }
}
