using System;
namespace _215Labs2020.Mihaylov
{
    class Bank
    {
        private static double balans = 0;
        private static void registration()
        {
            Console.WriteLine("Здравствуйте,пройдите регистрацию для использовании услуг банка.");
            Console.WriteLine("Введите своё ФИО : ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою дату рождения: ");
            string birthday = Console.ReadLine();
            Console.WriteLine("Введите свой номер телефона: ");
            string numberphone = Console.ReadLine();
            Console.WriteLine("Вы успешно зарегистрировались, можете пользоваться услугами банка.");
            Console.WriteLine($"Ваш баланс составляет {balans} р.");
        }
        private static void addition()
        {
            Console.Write("Введите сумму пополнения от 10000 до 200000: ");
            double a = double.Parse(Console.ReadLine());
            if (a <= 10000 | a >= 200000)
            {
                while (a <= 10000 | a >= 200000)
                {
                    Console.WriteLine("Ошибка! Диапазон пополнений  от 10000 до 200000. ");
                    Console.Write("Введите сумму пополнения: ");
                    a = double.Parse(Console.ReadLine());
                }
            }
            balans += a;
            Console.WriteLine($"Ваш баланс составляет {balans} р.");
        }
        private static void cut()
        {
            Console.WriteLine("Введите сумму которую хотите снять: ");
            double a = double.Parse(Console.ReadLine());
            while (balans - a < 0)
            {
                if (a <= 10000 | a >= 200000)
                {
                    Console.WriteLine($" У вас недостаточно средств для вывода денег, ваш баланс составляет: {balans}");
                    Console.Write("Введите сумму которую хотите снять:  ");
                    a = double.Parse(Console.ReadLine());
                }
            }
            balans -= a;
            Console.WriteLine("Снятие прошло успешно");
            Console.WriteLine($"Ваш баланс составляет: {balans} р.");
        }
        public static void Program()
        {
            while (true)
            {
                Console.WriteLine("Регистрация: ( 1 )");
                Console.WriteLine("Пополнить счет: ( 2 )");
                Console.WriteLine("Снять с счета: ( 3 )");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1: registration(); break;
                    case 2: addition(); break;
                    case 3: cut(); break;
                }
            }
        }
    }
}