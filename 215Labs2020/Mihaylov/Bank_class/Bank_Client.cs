using _215Labs2020.Mihaylov.Bank_class;
using System;
namespace _215Labs2020.Mihaylov
{
    class Bank_Client:Person
    {
        private static double cash;
        private static double persent = 0.08;
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        private static void registration()
        {
            Console.WriteLine("Введите день своего рождения: ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения:");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год своего рождения:");
            year = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - year;
            if (age >= 14)
            {
                Console.WriteLine("Можете продолжить регистрацию");
            }
            else
            {
                Console.WriteLine("Вы не можете продолжить регистрацию, так как вам меньше 14 лет");
                System.Environment.Exit(0);
            }
            Console.Write("Введите своё ФИО : ");
            name = Console.ReadLine();
            Console.Write("Введите свой номер телефона: ");
            numberphone = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму первого взноса: ");
            Console.Write("Введите сумму пополнения от 10000 до 200000: ");
            int a = 0;
            a = int.Parse(Console.ReadLine());
            balans += a;
            Console.WriteLine("Вы успешно зарегистрировались, можете пользоваться услугами банка.");
            Console.WriteLine($"Ваш баланс составляет {balans} р.");
        }
        private static void addition()
        {
            Console.Write("Введите сумму пополнения от 10000 до 200000: ");
            int a = 0;
            if (a <= 10000 | a >= 200000)
            {
                while (a <= 10000 | a >= 200000)
                {
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Диапазон пополнений  от 10000 до 200000. ");
                        Console.WriteLine("Введите сумму пополнения: ");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            balans += a;
            void messege() => Console.WriteLine($"На счет поступило: {a}");
            messege();
            Console.WriteLine($"Ваш баланс составляет {balans} р.");
        }
        private static void cut()
        {
            Console.Write("Введите сумму которую хотите снять: ");
            int a = int.Parse(Console.ReadLine());
            while (balans - a < 0)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    if (a <= 10000 | a >= 200000)
                    {
                        Console.WriteLine($" У вас недостаточно средств для вывода денег, ваш баланс составляет: {balans}");
                        Console.Write("Введите сумму которую хотите снять:  ");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            balans -= a;
            void messege() => Console.WriteLine($"Со счета снято: {a}");
            messege();
            Console.WriteLine($"Ваш баланс составляет: {balans} р.");
        }
        private static void info()
        {
            Console.WriteLine($"ФИО:{name}");
            Console.WriteLine($"Дата рождения:{day}.{month}.{year}");
            Console.WriteLine($"Номер телефона :{numberphone}");
            Console.WriteLine($"Ваш баланс составляет: {balans} р.");
        }

        private static void cashbak()
        {
            Console.Write("Введите сумму товара: ");
            int a = int.Parse(Console.ReadLine());
            while (balans - a < 0)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    if (a <= 10000 | a >= 200000)
                    {
                        Console.WriteLine($" У вас недостаточно средств для вывода денег, ваш баланс составляет: {balans}");
                        Console.Write("Введите сумму товара:  ");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            balans -= a;
            cash += a * 0.05;
            balans = balans + cash;
            void messege() => Console.WriteLine($"Прибыл кэшбэк в размере {cash}");
            messege();
            Console.WriteLine($"Ваш баланс составляет: {balans} р.");
        }
        private static void vklad()
        {
            Console.Write("Введите сумму товара: ");
            int a = int.Parse(Console.ReadLine());
            while (balans - a < 0)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    if (a <= 10000 | a >= 200000)
                    {
                        Console.WriteLine($" У вас недостаточно средств для вывода денег, ваш баланс составляет: {balans}");
                        Console.Write("Введите сумму товара:  ");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            balans+= balans*persent;
            Console.WriteLine($"Ваш баланс в следующем году составит: {balans} р.");
        }
        public static void сhangeFIO()
        {
            Console.WriteLine("Введите новое ФИО");
            name = Console.ReadLine();
        }
        public static void сhangephone()
        {
            Console.WriteLine("Введите новый номер телефона");
            numberphone = int.Parse(Console.ReadLine());
        }
        public static void Program()
            {
                while (true)
                {
                    Console.WriteLine("Регистрация: ( 1 )");
                    Console.WriteLine("Пополнить счет: ( 2 )");
                    Console.WriteLine("Снять с счета: ( 3 )");
                    Console.WriteLine("Информация о аккаунте: (4)");
                    Console.WriteLine("Купить товары: (5)");
                    Console.WriteLine("Сделать вклад: (6)");
                    Console.WriteLine("Поменять ФИО: (7)");
                    Console.WriteLine("Поменять номер телефона: (8)");
                int s = int.Parse(Console.ReadLine());
                    switch (s)
                    {
                        case 1: registration(); break;
                        case 2: addition(); break;
                        case 3: cut(); break;
                        case 4: info(); break;
                        case 5: cashbak(); break;
                        case 6: vklad(); break;
                        case 7: сhangeFIO(); break;
                        case 8: сhangephone(); break;
                    }
                }
        }
    }
}
