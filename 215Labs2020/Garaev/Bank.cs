using System;

namespace _Bank
{
    class Bank
    {
        private static string _surname;
        private static string _name;
        private static string _otchestvo;
        private static int balans = 0;
        private static int summ = 0;
        private static int _vivod = 0;
        private static int summ1 = 0;
        private static int nomer = 0;
        private static int a = 0;
        private static void name()
        {
            Console.Write("Введите Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string otchestvo = Console.ReadLine();
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
            }
            _surname = surname;
            _name = name;
            _otchestvo = otchestvo;
        }
        private static void bank_account()
        {
            Console.WriteLine($"Ваш баланс {balans}");
            Console.Write("Хотите пополнить баланс: 1)Да 2)Нет: ");
            int vibor = int.Parse(Console.ReadLine());
            if (vibor == 1)
            {
                Console.Write("Введите сумму пополнения: ");
                int f = 0;
                while (f==0)
                {
                    try
                    {
                        summ = int.Parse(Console.ReadLine());
                        f += 1;
                    }
                    catch
                    {
                        Console.Write("Введите правильную сумму: ");
                        f = 0;
                    }
                }
                while (summ>200000 || summ < 10000)
                {
                     summ = 0;
                     Console.WriteLine("Вы превысили лимит пополнения в 200 000 или сумма пополнения меньше 10 000");
                     Console.Write("Введите сумму пополнения: ");
                    int f1 = 0;
                    while (f1 == 0)
                    {
                        try
                        {
                            summ = int.Parse(Console.ReadLine());
                            f1 += 1;
                        }
                        catch
                        {
                            Console.Write("Введите правильную сумму: ");
                            f1 = 0;
                        }
                    }
                }
            }
            else if (vibor == 2)
            {
                summ = 0;
            }
            else
                Console.WriteLine("Error");
            balans += summ;
            Console.WriteLine($"Ваш текущий баланс: {balans}");
        }
        private static void vivod()
        {
            Console.Write("Сколько денег хотите вывести: ");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    _vivod = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.Write("Введите правильную сумму: ");
                    f = 0;
                }
            }
            while(balans - _vivod < 0 || _vivod > 200000 || _vivod < 10000)
            {
                if (balans - _vivod < 0)
                    Console.WriteLine("На вашем счету недостаточно средств");
                else if (_vivod > 200000 || _vivod < 10000)
                {
                    Console.WriteLine("Минимальный вывод: 10 000 руб.");
                    Console.WriteLine("Максимальный вывод: 200 000 руб.");
                }
                Console.Write("Сколько денег хотите вывести: ");
                int f1 = 0;
                while (f1 == 0)
                {
                    try
                    {
                        _vivod = int.Parse(Console.ReadLine());
                        f1 += 1;
                    }
                    catch
                    {
                        Console.Write("Введите правильную сумму: ");
                        f1 = 0;
                    }
                }
            }
            balans = balans - _vivod;
            Console.WriteLine($"Ваш текущий баланс: {balans}");
        }
        private static void transaction()
        {
            Console.Write("Введите номер счета на которую хотите перевести: ");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    nomer = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.Write("Введите правильный номер: ");
                    f = 0;
                }
            }
            Console.Write("Сколько денег хотите перевести: ");
            int f1 = 0;
            while (f1 == 0)
            {
                try
                {
                    summ1 = int.Parse(Console.ReadLine());
                    f1 += 1;
                }
                catch
                {
                    Console.Write("Введите правильную сумму: ");
                    f1 = 0;
                }
            }
            while (balans - summ1 < 0 || summ1 > 200000 || summ1 < 10000)
            {
                if(balans - summ1 < 0)
                    Console.WriteLine("На вашем счету недостаточно средств");
                else if (summ1 > 200000 || summ1 < 10000)
                {
                    Console.WriteLine("Минимальный перевод: 10 000 руб.");
                    Console.WriteLine("Максимальный перевод: 200 000 руб.");
                }
                Console.Write("Сколько денег хотите перевести: ");
                int f2 = 0;
                while (f2 == 0)
                {
                    try
                    {
                        summ1 = int.Parse(Console.ReadLine());
                        f2 += 1;
                    }
                    catch
                    {
                        Console.Write("Введите правильную сумму: ");
                        f2 = 0;
                    }
                }
            }
            balans -= summ1;
            Console.WriteLine($"Вы перевели {summ1} руб. на счет {nomer}");
            Console.WriteLine($"Ваш текущий баланс: {balans}");
        }
        public static void vibor_deistviy()
        {
            Console.WriteLine("Здравствуйте вас приветствует наш банк");
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1) Зарегистрироваться");
            Console.WriteLine("2) Выйти");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.Write("Введите правильную сумму: ");
                    f = 0;
                }
            }
            if (a == 2)
                a = 0;
            while (a > 0 && a < 5)
            {
                switch (a)
                {
                    case 1: name(); break;
                    case 2: bank_account(); break;
                    case 3: vivod(); break;
                    case 4: transaction(); break;
                }
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1) Зарегистрироваться");
                Console.WriteLine("2) Пополнить лицевой счет");
                Console.WriteLine("3) Вывести");
                Console.WriteLine("4) Перевод денег на другой лицевой счет");
                Console.WriteLine("5) Выйти");
                int f1 = 0;
                while (f1 == 0)
                {
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        f1 += 1;
                    }
                    catch
                    {
                        Console.Write("Введите правильную сумму: ");
                        f1 = 0;
                    }
                }
            }
        }
    }
}
