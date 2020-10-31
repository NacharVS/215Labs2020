using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Bank
{
    class Sotrudnik: BankPerson
    {
        private static int hour_work = rabota_time_summ / 3600;
        private static int minute_work = (rabota_time_summ % 3600) / 60;
        private static int second_work = rabota_time_summ % 60;
        private static int start_rabota_time = 0;
        private static int end_rabota_time = 0;
        private static int rabota_time_summ = 0;
        private static double zarplata = 0; 
        private static int dayofbirth = 0;
        private static int monthofbirth = 0;
        private static int yearofbirth = 0;
        private static string _surname;
        private static string _name;
        private static string _otchestvo;
        private static void rabota_time()
        {
            start_rabota_time = DateTime.Now.Second + DateTime.Now.Minute * 60 + DateTime.Now.Hour * 3600;
            int tru = 0;
            Console.Write("Вы начали работу. За каждую секунды вы получаете 6 копеек. Чтобы закончить нажмите ENTER:");
            try
            {
                string rabota = Console.ReadLine();
            }
            finally
            {
                tru = 1;
            }
            if (tru == 1)
            {
                end_rabota_time = DateTime.Now.Second + DateTime.Now.Minute * 60 + DateTime.Now.Hour * 3600;
            }
            int work_time = end_rabota_time - start_rabota_time;
            rabota_time_summ += work_time;
            int tecuch_hour_work = work_time / 3600;
            int tecuch_minute_work = (work_time % 3600) / 60;
            int tecuch_second_work = work_time % 60;
            double dohod = work_time * 0.06;
            zarplata += dohod;
            string hour = "часа";
            string minute = "минуты";
            string second = "секунды";
            if (tecuch_hour_work > 4)
                hour = "часа";
            if (tecuch_minute_work > 4)
                minute = "минут";
            if (tecuch_second_work > 4)
                second = "секунд";
            Console.WriteLine($"Вы проработали {tecuch_hour_work} {hour} {tecuch_minute_work} {minute} {tecuch_second_work} {second}. Вы заработали: {Math.Round(dohod,2)} руб.");
        }
        private static void schet_time()
        {
            hour_work = rabota_time_summ / 3600;
            minute_work = (rabota_time_summ % 3600) / 60;
            second_work = rabota_time_summ % 60;
        }
        private static void balans()
        {
            schet_time();
            string hour = "часа";
            string minute = "минуты";
            string second = "секунды";
            if (hour_work > 4)
                hour = "часа";
            if (minute_work > 4)
                minute = "минут";
            if (second_work > 4)
                second = "секунд";
            Console.WriteLine($"Вы проработали {hour_work} {hour} {minute_work} {minute} {second_work} {second}. Ваш текущяя зарплата: {Math.Round(zarplata,2)} руб.");
        }
        private static void regisration()
        {
            Console.Write("Введите Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string otchestvo = Console.ReadLine();
            Console.WriteLine("Введите дату рождение");
            Console.Write("День: ");
            dayofbirth = int.Parse(Console.ReadLine());
            Console.Write("Месяц: ");
            monthofbirth = int.Parse(Console.ReadLine());
            Console.Write("Год: ");
            yearofbirth = int.Parse(Console.ReadLine());
            while (_surname == surname && _name == name && _otchestvo == otchestvo)
            {
                Console.WriteLine("Извините такой аккаунт уже существует.");
                Console.WriteLine("Попробуйте заново:");
                Console.Write("Введите Фамилия: ");
                surname = Console.ReadLine();
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите Отчество: ");
                otchestvo = Console.ReadLine();
                Console.Write("День: ");
                dayofbirth = int.Parse(Console.ReadLine());
                Console.Write("Месяц: ");
                monthofbirth = int.Parse(Console.ReadLine());
                Console.Write("Год: ");
                yearofbirth = int.Parse(Console.ReadLine());
            }
            int realyear = DateTime.Now.Year;
            int realday = DateTime.Now.Day;
            int realmonth = DateTime.Now.Month;

            bool l = true;
            while (l == true)
            {
                int age = realyear - yearofbirth;
                if (age == 14)
                {
                    if (realmonth >= monthofbirth)
                    {
                        if (realday >= dayofbirth)
                        {
                            l = false;
                        }
                        else
                        {
                            Console.WriteLine("Извиние. Устроиться на работу могут лица достигшие 14 лет");
                            Console.Write("День: ");
                            dayofbirth = int.Parse(Console.ReadLine());
                            Console.Write("Месяц: ");
                            monthofbirth = int.Parse(Console.ReadLine());
                            Console.Write("Год: ");
                            yearofbirth = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Извиние. Устроиться на работу могут лица достигшие 14 лет");
                        Console.Write("День: ");
                        dayofbirth = int.Parse(Console.ReadLine());
                        Console.Write("Месяц: ");
                        monthofbirth = int.Parse(Console.ReadLine());
                        Console.Write("Год: ");
                        yearofbirth = int.Parse(Console.ReadLine());
                    }
                }
                else if (age > 14)
                    l = false;
                else
                {
                    Console.WriteLine("Извиние. Устроиться на работу могут лица достигшие 14 лет");
                    Console.Write("День: ");
                    dayofbirth = int.Parse(Console.ReadLine());
                    Console.Write("Месяц: ");
                    monthofbirth = int.Parse(Console.ReadLine());
                    Console.Write("Год: ");
                    yearofbirth = int.Parse(Console.ReadLine());
                }
            }
            _surname = surname;
            _name = name;
            _otchestvo = otchestvo;
        }
        public static void vibor_deistviy()
        {
            int a = 0;
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1) Зарегистрироваться");
            Console.WriteLine("2) Выйти");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    f = 1;
                }
                catch
                {
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильное действие: ");
                    f = 0;
                }
            }
            if (a == 2)
                a = 0;
            while (a>0 && a<4)
            {
                switch (a)
                {
                    case 1: regisration(); break;
                    case 2: balans(); break;
                    case 3: rabota_time(); break;
                }
                Console.WriteLine();
                Console.WriteLine("1) Зарегистрироваться");
                Console.WriteLine("2) Узнать текущую зарплату");
                Console.WriteLine("3) Начать работать");
                Console.WriteLine("4) Выйти");
                int f1 = 0;
                while (f1 == 0)
                {
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        f1 = 1;
                    }
                    catch
                    {
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
                        Console.Write("Введите правильное действие: ");
                        f1 = 0;
                    }
                }
            }
            BankPerson.Bank_deysviya();
        }
    }
}
