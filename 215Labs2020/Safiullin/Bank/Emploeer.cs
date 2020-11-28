using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Bank
{
    class Emploeer : Person
    {
        public int id { get; set; }
        private static int zarplata = 35000;
        private static double zarplata_balans = 0;
        public Emploeer(string name)
        {

            Forename1 = name;
        }
        public static void emploeer()
        {
            Console.WriteLine($"Текущая дата: {DateTime.Now}");
            Console.WriteLine(Emploeer.Forename1);
            if (DateTime.Now.Day > 28)
            {
                zarplata_balans += zarplata;
                Console.WriteLine($"Зарплата за данный месяц составляет {zarplata_balans} рублей");

            }
            else
            {
                Console.WriteLine($"Зарплата начислится 28-го числа!");
            }
        }
    }
}
