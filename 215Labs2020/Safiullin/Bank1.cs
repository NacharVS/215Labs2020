using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class Bank1
    {
        private static string _surname;
        private static string _name;
        private static string _otchestvo;
        private static int summ = 0;
        private static int summ1 = 0;
        private static int _number = 0;
        private static int year = 0;
        private static int day = 0;
        private static int month = 0;
        private static double _replen;
        private static double _balans = 0;
        private static double _percent = 0.0061;
        private static DateTime _accounOpenDate;

        private static void Check_Age()
        {
            Console.Write("Введите дату своего рождения (Пример: 01 01 2020): ");
            try
            {
                Console.Write("День: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("Месяц: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Год: ");
                year = int.Parse(Console.ReadLine());
                Console.Clear();
                _accounOpenDate = DateTime.Now;
                Console.WriteLine($"Дата открытия счета {_accounOpenDate} ");
                DateTime dataBorn = new DateTime(year, month, day);
                Console.WriteLine($"Дата рождения: {dataBorn.Day}.{dataBorn.Month}.{dataBorn.Year}");
                Console.WriteLine();
                if (DateTime.Now.Year - year >= 14 || DateTime.Now.Month - day <= DateTime.Now.Month || DateTime.Now.Day - day <= DateTime.Now.Day)
                {
                    Console.WriteLine("Люди младше 14 лет не могут открыть счет.");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка. Не коректно введена дата рождения.");
            }
            
        }
        private static void Person_name()
        {

        }
        private static void Record()
        {


        }
        private static void Check_Donation(double donation)
        {
            if (donation < 10000 | donation > 200000)
            {
                Console.WriteLine("Ошибка. Сумма взноса должна быть больше 10 000р и меньше 200 000р.");
            }
            else if (_balans - donation < 0)
            {
                Console.WriteLine("Ошибка. Не достаточно средств для снятия со сочета на балансе счета.");
            }
            else
            {
                Console.WriteLine($"Баланс счета составляет: {_balans}");
                Console.WriteLine();
            }
        }
        private static void Check_Symbol(string donation)
        {
            try
            {
                double a = double.Parse(donation);
                _replen = a;

            }
            catch
            {
                Console.WriteLine("Ошибка. Введенные символы не допустимы.");
            }

        }


        private static void Refill()
        {
            Console.Write("Введите сумму, на которую вы хотите пополнить баланс: ");
            Check_Symbol(Console.ReadLine());
            Check_Donation(_replen);
        }
        private static void Check_Data()
        {
            Console.Write("Через сколько лет вы хотите узнать свой баланс: ");
            double a = double.Parse(Console.ReadLine());
            double b = 0;
            for (int i = 0; i < a; i++)
            {
                b = _balans + _balans * _percent * i;
            }
            Console.WriteLine($"Ваш баланс через {a} лет, будет равен {b}.");
            Console.WriteLine();

        }







    }
}
