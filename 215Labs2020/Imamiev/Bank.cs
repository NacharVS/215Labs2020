using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev
{
    class Bank
    {
        private static string name;
        private static string surname;
        private static double deposit = 0;
        private static double procents = 0.05;
        private void Registration()
        {
            Console.WriteLine("Greetings,you need sign up to deposit your money in our bank");
            Bank InfoBase = new Bank();
            Console.WriteLine("Enter your name");
            Bank.name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            Bank.surname = Console.ReadLine();
        }
        private void Operations()
        {
            int i = 0;
            while (i <= 0)
            {
                try
                {
                    Bank InfoBase = new Bank();
                    Console.WriteLine("Enter the amount od deposit");
                    double money = int.Parse(Console.ReadLine());
                    if (money >= 10000 || money <= 10000) Bank.deposit = money;
                    {
                        i = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Error!Deposit couldn't has any words in it!");
                }
            }
        }
        private void Procent()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine("Enter the loan length");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Bank.deposit += Bank.procents * Bank.deposit;
            }
        }
        private void Finish()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine($"After the loan,that you close,your deposit will be:|{Bank.deposit} rubles");
            Console.WriteLine($"{Bank.name} {Bank.surname},think you for using our blank!");
        }
        public static void Method()
        {
            Bank InfoBase = new Bank();
            InfoBase.Registration();
            InfoBase.Operations();
            InfoBase.Procent();
            InfoBase.Finish();
        }
    }
}
