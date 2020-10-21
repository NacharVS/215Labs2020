using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov
{
    class Bank
    {
        private string name;
        private string surname;
        private static int deposit;
        private static double procents = 0.05;
        private void Registration()
        {
            Console.WriteLine("Greetings, you need sign up to deposit your money in our bank");
            Bank InfoBase = new Bank();
            Console.WriteLine("Write your name");
            InfoBase.name = Console.ReadLine();
            Console.WriteLine(InfoBase.name);
            Console.WriteLine("Wrtie your surname");
            InfoBase.surname = Console.ReadLine();
            Console.WriteLine(InfoBase.surname);
        }
        private void Operations()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine("Enter the amount of deposit");
            double money = int.Parse(Console.ReadLine());
            if (money >= 10000 || money <= 200000) Bank.deposit = money;
        }
        private void procents()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine("Enter the loan lengh");

        }
    }
}
