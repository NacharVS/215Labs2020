using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Davletshina
{
    class Bank
    {
        private static string surname;
        private static string name;
        private static double contibution = 0;
        private static double percent = 0.1;
        private void Registration()
        {
            Console.WriteLine("Hello, to invest in our Bank, you need to register.");
            Bank bank = new Bank();
            Console.WriteLine("Enter your surname:");
            Bank.surname = Console.ReadLine();
            Console.WriteLine("Enter your name:");
            Bank.name = Console.ReadLine();
        }
        private void Operation()
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter the deposit sum:");
            double money = int.Parse(Console.ReadLine());
            if (money >= 1000 || money <= 200000) Bank.contibution = money;
        }
        private void prognoz()
        {
            Bank bank = new Bank();
            Console.WriteLine("How many years do you plan to invest?");
            int coat = int.Parse(Console.ReadLine());
            for (int i =1; i < coat; i++);
            {
                Bank.contibution += Bank.percent * Bank.contibution;
            }
        }
        private void end()
        {
            Bank bank = new Bank();
            Console.WriteLine($"After the specified period, your contribution will be : {Bank.contibution} rubs.");
            Console.WriteLine($"{Bank.surname} {Bank.name}, thank you for your trust in the Bank.");
        }
        public static void method()
        {
            Bank bank = new Bank();
            bank.Registration();
            bank.Operation();
            bank.prognoz();
            bank.end();
        }
    }
}
