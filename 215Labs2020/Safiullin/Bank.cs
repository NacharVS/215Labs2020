using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class Bank
    {
        private string name;
        private string surname;
        private string year;
        private string phone;
        private static double depozit;
        private static double balans = 0;
        private static double persent = 0.006;
        public static void CreateAccount()
        {
            Console.WriteLine("Здраствуйте, добро пожаловать в ТатСоцБанк. Для дальнейших действий пройдите регистрацию.");
            string registration = Console.ReadLine();
            Console.Write("Введите своё ИМЯ: ");
            string name = Console.ReadLine();
            Console.Write("Введите свою ФАМИЛИЮ: ");
            string surname = Console.ReadLine();
            Console.Write("Введите свою дату рождения: ");
            string year = Console.ReadLine();
            Console.Write("Введите свой номер телефона: ");
            string phone = Console.ReadLine();
        }
        public static void Refill()
        {
            Console.Write("Мин. сумма пополнения составляет 10000 р. Макс.сумма пополнения составляет 200000 р. Введите сумму пополнения: ");
            double a = double.Parse(Console.ReadLine());
            if (a <= 10000 | a >= 200000)
            {
                while (a <= 10000 | a >= 200000)
                {
                    Console.WriteLine("Ошибка! Минимальная сумма пополнения составляет 10000р. ");
                    Console.Write("Введите сумму пополения: ");
                    a = double.Parse(Console.ReadLine());
                }
            }
            balans += a;
            Console.WriteLine($"Ваш баланс составляет {balans} р.");
        }
        public static void removal()
        {
            Console.Write("Введите сумму которую хотите снять: ");
            double a = double.Parse(Console.ReadLine());
            while (balans - a < 0)
            {
                if (a <= 10000 | a >= 200000)
                {
                    Console.WriteLine($"Недостаточно средст для вывода денег, ваш баланс составляет: {balans}");
                    Console.Write("Введите сумму которую хотите снять:  ");
                    a = double.Parse(Console.ReadLine());
                }
            }
            balans -= a;
            Console.WriteLine($"Ваш баланс составляет: {balans} р.");
            Console.WriteLine("Хотите снять ещё? Для этого нажмите 3 ");
            
        }
        public static void in_year()
        {
            Console.Write($"Через сколько лет вы хотите узнать свой баланс: ");
            double a = double.Parse(Console.ReadLine());
            double b = 0;
            for (int i = 0; i < a; i++)
            {
                b = balans + balans * persent * i;
            }
            Console.WriteLine($"Ваш баланс через {a} лет, будет равен {b}.");
            Console.WriteLine("Благодарим за окозания доверия банка! Ждем вас в следующий раз!");
        }
        public static void Program()
        {
            while (true)
            {
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1: CreateAccount(); break;
                    case 2: Refill(); break;
                    case 3: removal(); break;
                    case 4: in_year(); break;

                }
            }

        }





    }
}
