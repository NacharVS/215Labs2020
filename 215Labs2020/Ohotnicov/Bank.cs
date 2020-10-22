using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Ohotnicov
{
    class Bank
    {
        private static string name;
        private static string surname;
        private static double card;
        private static double procent = 0.1;
        private static double prognoz;
        private static void registration()
        {
            Bank bank = new Bank();
            Console.WriteLine("Здравствуйте!Для регистрации введите ваше имя");
            Bank.name = Console.ReadLine();
            Console.WriteLine("Ваша фамиллия:");
            Bank.surname = Console.ReadLine();
        }
        private static void Invest()
        {
            Bank bank = new Bank();
            bool c = true;
            while (c == true)
            {
                Console.WriteLine("Введите сумму для внесения (от 10000 до 200000):");
                double a = int.Parse(Console.ReadLine());
                if ((a >= 10000) & (a <= 200000))
                {
                    Bank.card += a;
                    Console.WriteLine($"Ваш счет пополнен на {a}, ваш баланс {Bank.card}");
                    c = false;
                }
                if ((a < 10000) || (a > 200000))
                {
                    Console.WriteLine("Нужно ввести сумму в диапозоне от 10k до 200k ");
                }
            }
        }
        private static void Withdraw()
        {
            Bank bank = new Bank();
            bool c = true;
            while (c == true)
            {
                Console.WriteLine("Введите сумму для cнятия:");
                double a = int.Parse(Console.ReadLine());
                if ((a > 0) & (a <= card))
                {
                    Bank.card -= a;
                    Console.WriteLine($"Вы сняли со сета {a}, остаток на счету {Bank.card} ");
                    c = false;

                }
                else
                {
                    Console.WriteLine("Нужно ввести сумму не превышающую остаток на счету ");
                    c = false;
                }
            }
        }
        private static void Depozit()
        {
            Console.WriteLine("На сколько лет вы хотите внести вклад?");
            int coat = int.Parse(Console.ReadLine());
            for (int i = 0; i < coat; i++)
            {
                prognoz += Bank.card * Bank.procent;
            }
        }
        private static void End()
        {
            Console.WriteLine($"Через указанное количтеско лет, ваш вклад будет равен {prognoz}.");
            Console.WriteLine($"Спасибо что пользуйтесь нашим банком {Bank.name} {Bank.surname}");

        }
        public static void GO()
        {
            bool c = true;
            registration();
            Console.WriteLine($"{Bank.card}");
            while (c == true)
            {
                Console.WriteLine("Что вы хотите сделать с вашим счетом?");
                Console.WriteLine("Нажмите 1 - если вы хотите внести депозит в наш банк");
                Console.WriteLine("Нажмите 2 - если вы хотите вывести деньги с вашего счета");
                Console.WriteLine("Нажмите 3 - если вы хотите посмотреть информацию о вкладе");
                Console.WriteLine("Нажмите 4 - если вы хотите завершить работу с банком");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Invest();
                        Depozit();
                        break;
                    case "2":
                        Withdraw();
                        break;
                    case "3":
                        Console.WriteLine($"{card}");
                        break;
                    case "4":
                        End();
                        c = false;
                        break;
                    default:
                        Console.WriteLine($"Неизвестная клавиша, попробуйте еще раз");
                        break;
                }
            }
        }
    }
}
