using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova
{
    class Bank
    {
        private static double balance = 0;
        private static double vklad = 0;
        private static double procent = 0.8;
        private static DateTime dateBorn { get; set; }
        private void Operation()
        {
            Bank bank = new Bank();
            Console.WriteLine("Введите сумму депозита");
            double money = int.Parse(Console.ReadLine());
            if (money >= 1000 || money <= 200000) Bank.vklad = money;
        }
        private void prognoz()
        {
            Bank bank = new Bank();
            Console.WriteLine("На сколько лет вы планируете вложение?");
            int coat = int.Parse(Console.ReadLine());
            for (int i = 1; i < coat; i++) ;
            {
                Bank.vklad += Bank.procent * Bank.vklad;
            }
        }
        private void end()
        {
            Bank bank = new Bank();
            Console.WriteLine($"Через указанный вами срок , ваш вклад составит {Bank.vklad} рублей");
        }
        public void method()
        {
            Bank bank = new Bank();
            bank.Operation();
            bank.prognoz();
            bank.end();
        }
    }
}
