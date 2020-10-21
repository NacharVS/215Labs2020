using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Ohotnicov
{
    class Bank
    {
        private string name;
        private string surname;
        private static int card ;
        private static double procent = 0.006;
        private static int Invest()
        {
            bool c = true;
            while (c == true)
            {
                Console.WriteLine("Введите сумму для внесения (от 10000 до 200000):");
                int a = Convert.ToInt16(Console.ReadLine());
                if ((a >= 10000) & (a <= 200000))
                {
                    card += a;
                    Console.WriteLine($"Ваш счет пополнен на {a}, ваш баланс {card}");
                    c = false;
                    return card;
                }
                if ((a < 10000) || (a > 200000))
                {
                    Console.WriteLine("Нужно ввести сумму в диапозоне от 10k до 200k ");
                    c = false;
                }
            }
            return card;
        }
        private static int Withdraw()
        {
            bool c = true;
            while (c == true)
            {
                Console.WriteLine("Введите сумму для cнятия:");
                int a = Convert.ToInt16(Console.ReadLine());
                if ((a > 0) & (a <= card))
                {
                    card -= a;
                    Console.WriteLine($"Вы сняли со сета {a}, остаток на счету {card} ");
                    c = false;
                }
                else
                {
                    Console.WriteLine("Нужно ввести сумму не превышающую остаток на счету ");
                    c = false;
                }
            }
            return card;
        }
        private static void Depozit()
        {
            Bank bank = new Bank();
            Console.WriteLine("На сколько лет вы хотите внести вклад?");
            int coat = int.Parse(Console.ReadLine());
            for (int i = 0; i < coat; i++)
            {
                card += card * Bank.procent;
            }
        }

        public static void GO()
        {
            bool c = true;
                Bank Name = new Bank();
                Bank SurName = new Bank();
                Console.WriteLine("Здравствуйте!Для регистрации введите ваше имя");
                Name.name = Console.ReadLine();
                Console.WriteLine("Ваша фамиллия:");
                SurName.surname = Console.ReadLine();
            while (c == true)
            {
                Console.WriteLine("Что вы хотите сделать с вашим счетом?(внести/снять)");
                string vubor = Convert.ToString(Console.ReadLine());
                if (vubor == "внести")
                {
                    Invest();
                }
                else
                {
                    Withdraw();
                }
                Console.WriteLine("Хотите продолжить действия с вашим счетом? Введите Y/N");
                string b = Convert.ToString(Console.ReadLine());
                if (b == "N")
                {
                    Console.WriteLine($"{Name.name}, cпасибо что пользуетесь нашим банком, ваш балнас {card}");
                    c = false;
                }
            }

        }
    }
}
