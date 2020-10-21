using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class Bank
    {
        private static int bank_balans = 0;
        private static string name;
        private static void FullName()
        {
            Console.Write("Фамилия Имя Отчество: ");
            string _name = Console.ReadLine();
            while(_name == name)
            {
                Console.WriteLine("Извините такой аккаунт уже существует.");
                Console.WriteLine("Попробуйте заново:");
                Console.Write("Фамилия Имя Отчество: ");
                _name = Console.ReadLine();
            }
            name = _name;
        }
        private static void Refill()
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
            while (a > 200000)
            {
                Console.WriteLine("Максимальная сумма пополнения 200 000 рублей");
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
        private static void Withdrawal()
        {
            Console.Write("Введите сумму которую хотите снять: ");
            int a = int.Parse(Console.ReadLine());
            while (bank_balans - a < 0)
            {
                if (a < 10000)
                {
                    while (a < 10000)
                    {
                        Console.WriteLine("Минимальная сумма для снятия 10 000 рублей.");
                        Console.Write("Введите сумму которую хотите снять: ");
                        a = int.Parse(Console.ReadLine());
                    }
                }
                while (a > 200000)
                {
                    Console.WriteLine("Максимальная сумма для снятия 200 000 рублей");
                    a = int.Parse(Console.ReadLine());
                    while (a < 10000)
                    {
                        Console.WriteLine("Минимальная сумма для снятия 10 000 рублей.");
                        Console.Write("Введите сумму которую хотите снять: ");
                        a = int.Parse(Console.ReadLine());
                    }
                }
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
        private static void Transfer()
        {
            Console.Write("Введите счет, на которую переводите деньги: ");
            int login_transfer = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму которую хотите перевести: ");
            int a = int.Parse(Console.ReadLine());
            if (a < 10000)
            {
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма для перевода 10 000 рублей.");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    a = int.Parse(Console.ReadLine());
                }
            }
            while (a > 200000)
            {
                Console.WriteLine("Максимальная сумма для перевода 200 000 рублей");
                a = int.Parse(Console.ReadLine());
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма для перевода 10 000 рублей.");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    a = int.Parse(Console.ReadLine());
                }
            }
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
        public static void Operation()
        {
            Console.WriteLine("1.Зарегистрироваться");
            Console.WriteLine("2. Выйти");
            int prov = int.Parse(Console.ReadLine());
            if (prov == 1)
            {
                Console.WriteLine("Здравствуйте, выберите операцию которую хотите выполнить.");
                Console.WriteLine("1. Регистрация пользователя");
                Console.WriteLine("2. Пополнение счета");
                Console.WriteLine("3. Снятие денег со счета");
                Console.WriteLine("4. Перевод денег");
                Console.WriteLine("Выберите любое число для выхода");
                int number_operation = int.Parse(Console.ReadLine());
                while (number_operation > 0 && number_operation < 5)
                {
                    switch (number_operation)
                    {
                        case 1: FullName(); break;
                        case 2: Refill(); break;
                        case 3: Withdrawal(); break;
                        case 4: Transfer(); break;
                    }
                    Console.WriteLine("Выберите дальнейшие действие");
                    number_operation = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
