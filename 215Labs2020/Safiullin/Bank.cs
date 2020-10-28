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
        private static double persent = 0.061;
        private static bool registratshion = false;

        public static void CreateAccount()
        {
            Bank person = new Bank();
            Console.Write("Введите своё ИМЯ: ");
            string name = Console.ReadLine();
            Console.Write("Введите свою ФАМИЛИЮ: ");
            string surname = Console.ReadLine();
            Console.Write("Введите свой номер телефона: ");
            string phone = Console.ReadLine();
            if (year)
            {
                Console.Write("Введите свою дату рождения: ");
                string _phone = Console.ReadLine();
                Console.Write("Введите сумму первого взноса: ");
                Bank.contribution(Console.ReadLine());

                if (a < 10000 | a > 200000 )
                {
                    Console.WriteLine("Ошибка. Сумма первого взноса должна быть больше 10 000р и меньше 200 000р.");
                    _take2 = false;
                }
                else if (_take2)
                {
                    Bank._bill += _donation;
                    Console.WriteLine(Bank._line);
                    Console.WriteLine("Благодарим за регистрацию в нашем банке.");
                    Console.WriteLine($"Баланс счета составляет: {Bank._bill}");
                    Console.WriteLine(Bank._line);
                    Console.WriteLine();
                    _registration = true;
                    _take2 = false;
                }
            }
            else { Console.WriteLine("Ошибка. Регистрация не пройдена."); 
            Bank.registratshion = true;
        }
        public static void Refill()
        {
            Console.Write("Мин. сумма пополнения составляет 10000 р. Макс.сумма пополнения составляет 200000 р. Введите сумму пополнения: ");
            double a = double.Parse(Console.ReadLine()); 
            if (a < 10000 | a > 200000)
            {
                while (a < 10000 | a > 200000)
                {
                    Console.WriteLine("Ошибка! Минимальная сумма пополнения составляет 10000р. ");
                    Console.Write("Введите сумму пополения: ");
                    try 
                    { 
                         a = double.Parse(Console.ReadLine());

                    }
                    catch 
                    {
                        Console.WriteLine("Введите правильную сумму пополнения: ");
                        a = double.Parse(Console.ReadLine());
                    }
                }
            }
            balans += a;
            Console.WriteLine($"Ваш баланс составляет {balans} р.");
        }
        public static void removal()
        {
            Console.Write("Введите сумму которую хотите снять: ");
            double a = double.Parse(Console.ReadLine());
            if (balans - a < 0)
            {
                while (a < 10000 | a > 200000 | balans - a < 0)
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
            if (true)
            {
                int a;
                Console.WriteLine("Здраствуйте, добро пожаловать в ТатРасКазСафФанБанк.");
                Console.WriteLine("Для дальнейших действий пройдите быструю регистрацию.");
                Console.WriteLine("Для регистрации нажмите : (1)");
                Console.WriteLine("Для пополнения счета нажмите : (2)");
                Console.WriteLine("Для снятия со счета средств нажмите : (3)");
                Console.WriteLine("Для того чтобы узнать баланс через определенный период нажмите : (4)");
                a = int.Parse(Console.ReadLine());
                
                while (a > 0 && a < 5 ) 
                {
                    switch (a)
                    {
                        case 1: CreateAccount(); break;
                        case 2: Refill(); break;
                        case 3: removal(); break;
                        case 4: in_year(); break;

                    }
                    Console.WriteLine("Выберите дальнейшие действия: ");
                    a = int.Parse(Console.ReadLine());
                } 
                
            }

        }

    }

}
