using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class DayOfBirthBonus
    {
        public string name;
        public string data;
        //public static string Data
        //{
        //    get
        //    {
        //        return data;
        //    }
        //    set
        //    {
        //        if(value == f)
        //        {
        //            int a = 1000;
        //        }
        //    }
        //}
        public static void Reg()
        {

            Console.WriteLine("Добро пожаловать в наш магазин. Пожалуйста пройдите регистрацию.");
            Console.WriteLine("Имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Укажите дату рождения");
            Console.WriteLine("День: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Год: ");
            int year = int.Parse(Console.ReadLine());

        }
    }
}
