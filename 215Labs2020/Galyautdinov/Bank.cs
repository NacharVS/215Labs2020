using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class Bank
    {
        private static int bank_balans = 0;
        public static void FullName()
        {
            Console.Write("Фамилия Имя Отчество: ");
            string name = Console.ReadLine();
            
        }
        public static void Refill()
        {
            Console.Write("Введите сумму пополнения: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 10000)
            {
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма пополнения 10 000 рублей.");
                    Console.Write("Введите сумму пополнения: ");
                    a = int.Parse(Console.ReadLine());
                }
            }
            if (bank_balans + a > 200000)
            {
                Console.WriteLine("Максимальная сумма вашего баланса 200 000 рублей");
                Console.WriteLine($"Введите сумму пополнения не больше {200000 - bank_balans} рублей");
                a = int.Parse(Console.ReadLine());
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма пополнения 10 000 рублей.");
                    Console.Write("Введите сумму пополнения: ");
                    a = int.Parse(Console.ReadLine());
                }
            }
            bank_balans += a;
            Console.WriteLine($"Ваш баланс {bank_balans} рублей.");
        }
        public static void Withdrawal()
        {
            Console.Write("Введите сумму которую хотите снять: ");
            int a = int.Parse(Console.ReadLine());
            while (bank_balans - a < 0)
            {

                if (bank_balans - a < 0)
                {
                    Console.WriteLine($"Недостаточно средст для вывода. Ваш баланс {bank_balans}");
                    Console.Write("Введите сумму которую хотите снять: ");
                    a = int.Parse(Console.ReadLine());
                }
            }
            bank_balans -= a;
            Console.WriteLine($"Ваш баланс {bank_balans} рублей.");
        }
        public static void Transfer()
        {
            Console.Write("Введите счет, на которую переводите деньги: ");
            int login_transfer = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму которую хотите перевести: ");
            int a = int.Parse(Console.ReadLine());
            while (bank_balans - a < 0)
            {
                if (bank_balans - a < 0)
                {
                    Console.WriteLine($"Недостаточно средст для перевода. Ваш баланс {bank_balans}");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    a = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Вы перевели на счет {login_transfer} - {a} рублей");
            bank_balans -= a;
            Console.WriteLine($"Ваш баланс {bank_balans} рублей.");
        }
    }
}
