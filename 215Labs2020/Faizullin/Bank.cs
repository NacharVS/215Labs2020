using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin
{
    class Bank
    {
        private static string _SNF;
        private static double _contribution= 0;
        private static double _percent = 0.3;
        private void Registration()
        {
            Console.WriteLine("Hello, welcome to our Bank.");
            Console.WriteLine("***************************");
            Bank bank = new Bank();
            Console.WriteLine("Enter personal data");
            Console.WriteLine("***************");
            Bank._SNF = Console.ReadLine();
        }
        private void Operation()
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter the Deposit amount");
            Console.WriteLine("************************");
            double MONEY = int.Parse(Console.ReadLine());
            if (MONEY >= 10000 || MONEY <= 200000) Bank._contribution = MONEY;
        }
        private void PROGNOZ()
        {
            Bank bank = new Bank();
            Console.WriteLine("Investment for how many years?");
            Console.WriteLine("************************");
            int coat = int.Parse(Console.ReadLine());
            for (int i = 1; i < coat; i++)
            {
                Bank._contribution += Bank._percent + Bank._contribution;

            }
        }
        private void end()
        {
            Bank bank = new Bank();
            Console.WriteLine($"After the period yiou specified will be {Bank._contribution} rubles ");
            Console.WriteLine($" {Bank._SNF} ");
        }
    }
}
