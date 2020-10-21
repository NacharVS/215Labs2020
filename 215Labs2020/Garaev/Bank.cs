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
        private static void name()
        {
            Console.Write("Введите Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string otchestvo = Console.ReadLine();
            while (_surname == surname && _surname == surname && _otchestvo == otchestvo)
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
                summ = int.Parse(Console.ReadLine());
                while (summ>200000 || summ < 10000)
                {
                     summ = 0;
                     Console.WriteLine("Вы превысили лимит пополнения в 200 000 или сумма пополнения меньше 10 000");
                     Console.Write("Введите сумму пополнения: ");
                     summ = int.Parse(Console.ReadLine());
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
            int _vivod = int.Parse(Console.ReadLine());
            while(balans - _vivod < 0 || _vivod > 200000 || _vivod < 10000)
            {
                if (balans - _vivod < 0)
                    Console.WriteLine("На вашем счету недостаточно средств");
                else if (_vivod > 200000 || _vivod < 10000)
                {
                    Console.WriteLine("Минимальный перевод: 10 000 руб.");
                    Console.WriteLine("Максимальный перевод: 200 000 руб.");
                }
                Console.Write("Сколько денег хотите вывести: ");
                _vivod = int.Parse(Console.ReadLine());
            }
            balans = balans - _vivod;
            Console.WriteLine($"Ваш текущий баланс: {balans}");
        }
        private static void transaction()
        {
            Console.Write("Введите номер счета на которую хотите перевести: ");
            int nomer = int.Parse(Console.ReadLine());
            Console.Write("Сколько денег хотите перевести: ");
            int summ1 = int.Parse(Console.ReadLine());
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
                summ1 = int.Parse(Console.ReadLine());
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
            int a = int.Parse(Console.ReadLine());
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
                a = int.Parse(Console.ReadLine());
            }
        }
    }
}
