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
    }
}
