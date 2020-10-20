using System;

namespace _Bank
{
    class Bank
    {
        private static int balans = 0;
        private static int summ = 0;
        public static void name()
        {
            Console.Write("Введите Фамилия: ");
            string _surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string _name = Console.ReadLine();
            Console.Write("Введите Отчество: ");
            string _otchestvo = Console.ReadLine();
        }
        public static void bank_account()
        {
            Console.WriteLine($"Ваш баланс {balans}");
            Console.Write("Хотите пополнить баланс: 1)Да 2)Нет: ");
            int vibor = int.Parse(Console.ReadLine());
            if (vibor == 1)
            {
                Console.Write("Введите сумму пополнения: ");
                summ = int.Parse(Console.ReadLine());
                while (summ + balans>200000 || summ < 10000)
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
        public static void vivod()
        {
            Console.Write("Сколько денег хотите вывести: ");
            int _vivod = int.Parse(Console.ReadLine());
            while(balans - _vivod < 0)
            {
                Console.WriteLine("На вашем счету недостаточно средств");
                Console.Write("Сколько денег хотите вывести: ");
                _vivod = int.Parse(Console.ReadLine());
            }
            balans = balans - _vivod;
            Console.WriteLine($"Ваш текущий баланс: {balans}");
        }
        public static void transaction()
        {
            Console.Write("Введите номер счета на которую хотите перевести: ");
            int nomer = int.Parse(Console.ReadLine());
            Console.Write("Сколько денег хотите перевести: ");
            int summ1 = int.Parse(Console.ReadLine());
            while (balans - summ1 < 0)
            {
                Console.WriteLine("На вашем счету недостаточно средств");
                Console.Write("Сколько денег хотите перевести: ");
                summ1 = int.Parse(Console.ReadLine());
            }
            balans -= summ1;
            Console.WriteLine($"Вы перевели {summ1} руб. на счет {nomer}");
            Console.WriteLine($"Ваш текущий баланс: {balans}");
        }
    }
}
