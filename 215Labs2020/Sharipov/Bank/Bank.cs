using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sharipov
{
    class Bank
    {
        private static string name;
        private static string surname;
        private static double vklad = 0;
        private static double procent = 0.1;
        private static int day;
        private static int mounth;
        private static int year;

        private void Registration()
        {
            Console.WriteLine(" Доброго времени суток, чтобы внести денежные средства на счет необходимо зарегистрироваться");
            Bank bank = new Bank();
            Console.WriteLine("Введите ваше имя");
            Bank.name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            Bank.surname = Console.ReadLine();
            while (true)
            {
                Console.Write("Введите день Вашего рождения");
                day = int.Parse(Console.ReadLine());
                Console.Write("Введите месяц Вашего рождения");
                mounth = int.Parse(Console.ReadLine());
                Console.Write("Введите год Вашего рождения");
                year = int.Parse(Console.ReadLine());
                int a = DateTime.Now.Year - year;
                if (a >= 14)
                {
                    Console.Write("Возраст подтвержден! Регистрация успешно завершена!");
                    break;
                }
                else
                {
                    Console.WriteLine("Извините, регистрация возможна только по достижению 14-летия");
                }
            }
        }
        private void Operation()
        {
            try
            {
                Bank bank = new Bank();
                Console.WriteLine("Введите сумму депозита");
                int money = int.Parse(Console.ReadLine());
                if (money >= 10000 && money <= 200000) Bank.vklad = money;
            }
            catch
            {
                Console.WriteLine("Произошла ошибка, попробуйте перезапустить программу");
            }
            finally
            {

            }
        }
        private void prognoz()
        {
            Bank bank = new Bank();
            Console.WriteLine("На сколько лет вы планируете вложение?");
            int coat = int.Parse(Console.ReadLine());
            for (int i = 0; i < coat; i++)
            {
                Bank.vklad += Bank.procent = Bank.vklad;
            }
        }
        private void end()
        {
            Bank bank = new Bank();
            Console.WriteLine($"Через указанный вами срок, сумма на вашем вкладе составит {Bank.vklad} рублей.");
            Console.WriteLine($"{Bank.name} {Bank.surname}, спасибо, что Вы с нами, ваш CamachBank.");
        }
        public static void method()
        {
            Bank bank = new Bank();
            bank.Registration();
            bank.Operation();
            if (Bank.vklad != 0)
            {
                bank.prognoz();
                bank.end();
            }
        }
    }
}

