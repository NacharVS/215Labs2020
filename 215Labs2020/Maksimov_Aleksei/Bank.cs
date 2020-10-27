using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei
{
    class Bank
    {
        private static string name;
        private static string surname;
        private static double vklad = 0;
        private static double procent = 0.1;
        private static int age;
        private static int dt;
        private static int mm;
        private static int yy;
        private void Daa()
        {
            Console.WriteLine("Введите дату вашего рождения через точку)");
            string h = Console.ReadLine();
            string[] dt = h.Split(new char[] { '.' });
            Bank.dt = int.Parse(dt[0]);
            Bank.mm = int.Parse(dt[1]);
            Bank.yy = int.Parse(dt[2]);
            Bank.age = DateTime.Now.Year - Bank.yy;

        }
        private void Registration()
        {
            Console.WriteLine("Здравствуйте, для вложения средств в наш банк необходимо зарегистрироваться.");
            Bank bank = new Bank();
            Console.WriteLine("Введите ваше имя");
            Bank.name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            Bank.surname = Console.ReadLine();
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
                    Console.WriteLine("Вышла ошибка, перезайдите в программу");
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
                Bank.vklad += Bank.procent * Bank.vklad;
            }
        }
        private void end() 
        {
            Bank bank = new Bank();
            Console.WriteLine($"Через указанный вами срок, ваш вклад составит {Bank.vklad} рублей.");
            Console.WriteLine($"{Bank.name} {Bank.surname}, cпасибо за оказанное вами довериe к банку 'МаксимовСтройГазНефтьЛейсанИнвест'.");
        }
        public static void method()
        {
            Bank bank = new Bank();
            bank.Daa();
            if (Bank.age >= 14)
            {
                bank.Registration();
                bank.Operation();
                if (Bank.vklad != 0)
                {
                    bank.prognoz();
                    bank.end();
                }
            }
            else
                Console.WriteLine("Вы не можете положить деньги под депозит в нашем банке, так как вам недостаточно лет(");
        }
    }
}