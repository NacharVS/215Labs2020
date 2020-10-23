using System;

namespace _Bank
{
    class Bank
    {
        private static double procent = 20;
        private static string _surname;
        private static string _name;
        private static string _otchestvo;
        private static double balans = 0;
        private static int summ = 0;
        private static int _vivod = 0;
        private static int summ1 = 0;
        private static int nomer = 0;
        private static int a = 0;
        private static int year = 0;
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
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
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
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
                        Console.Write("Введите правильную сумму: ");
                        f1 = 0;
                    }
                }
            }
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
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильную сумму: ");
                    f = 0;
                }
            }
            while(balans - _vivod < 0 || _vivod > 200000 || (_vivod < 10000 && _vivod != 0))
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
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
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
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
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
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильную сумму: ");
                    f1 = 0;
                }
            }
            while (balans - summ1 < 0 || summ1 > 200000 || (summ1 < 10000 && summ1 != 0))
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
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
                        Console.Write("Введите правильную сумму: ");
                        f2 = 0;
                    }
                }
            }
            balans -= summ1;
            Console.WriteLine($"Вы перевели {summ1} руб. на счет {nomer}");
            Console.WriteLine($"Ваш текущий баланс: {balans}");
        }
        private static void _dohod()
        {
            Console.WriteLine($"Процентная ставка: {procent}%");
            Console.Write("На сколько лет хотите посчитать проценты: ");
            int f = 0;
            while (f == 0)
            {
                try
                {
                    year = int.Parse(Console.ReadLine());
                    f += 1;
                }
                catch
                {
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильно: ");
                    f = 0;
                }
            }
            double balans1 = balans;
            for (int i = 0; i < year; i++)
            {
                balans1 = Math.Round(balans1 + (balans1 * (procent / 100)),2);
            }
            double dohod = Math.Round(balans1-balans,2);
            if (year<5)
                Console.WriteLine($"Через {year} года ваш баланс будет {balans1} руб. Чистый доход: {dohod} руб.");
            else
                Console.WriteLine($"Через {year} лет ваш баланс будет {balans1} руб. Чистый доход: {dohod} руб.");
        }
        private static void tecush_balans()
        {
            Console.WriteLine($"Ваш текущий баланс: {balans} руб.");
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
                    Console.WriteLine("******!!!! ОШИБКА !!!!******");
                    Console.Write("Введите правильный номерр действия: ");
                    f = 0;
                }
            }
            if (a == 2)
                a = 0;
            while (a > 0 && a < 7)
            {
                switch (a)
                {
                    case 1: name(); break;
                    case 2: bank_account(); break;
                    case 3: vivod(); break;
                    case 4: transaction(); break;
                    case 5: _dohod(); break;
                    case 6: tecush_balans(); break;
                }
                Console.WriteLine();
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1) Зарегистрироваться");
                Console.WriteLine("2) Пополнить лицевой счет");
                Console.WriteLine("3) Вывести (Если захотите отменить операцию, то выведите 0 руб.)");
                Console.WriteLine("4) Перевод денег на другой лицевой счет (Если захотите отменить операцию, то переведите 0 руб.)");
                Console.WriteLine("5) Посчитать проценты");
                Console.WriteLine("6) Узнать текущий баланс");
                Console.WriteLine("7) Выйти");
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
                        Console.WriteLine("******!!!! ОШИБКА !!!!******");
                        Console.Write("Введите правильную сумму: ");
                        f1 = 0;
                    }
                }
            }
        }
    }
}
