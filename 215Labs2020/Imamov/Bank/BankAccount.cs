using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.BankAcc
{
    class BankAccount
    {
        private static double balance = 0;
        private static double percents = 0.05;
        private static double cashback_percents = 0.03;
        private static double partnerCashbak_percents = 0.2;
        private static double cashback = 0;
        private static long phoneNumber;
        private static int birthDay;
        private static int birthMonth;
        private static int birthYear;

        public delegate void AccountHandler(string message);
        private event AccountHandler Notify;
        public BankAccount (double sum)
        {
            balance = sum;
        }
        public void Put(double sum)
        {
            balance += sum;
            Notify?.Invoke($"The account received: {sum} ");
        }
        public void Take(double sum)
        {
            if (balance >= sum)
            {
                balance -= sum;
                Notify?.Invoke($"Withdrawn from the acoount: {sum} ");
            }
            else
            {
                Notify?.Invoke($"Not enough money. The current balance: {sum} ");
            }
        }
        public void Transfer(double sum)
        {
            if (balance >= sum)
            {
                balance -= sum;
                Notify?.Invoke($"You transfered: {sum} ");
            }
        }
        public void Deposit (double sum)
        {
            balance += sum;
            Notify?.Invoke($"The account received: {sum} ");
        }
        public static double Sum { get; private set; }
        private static void DisplayNotification(string message)
        {
            Console.WriteLine(message);
        }
        private static void Refill(double balance)
        {
            BankAccount operations = new BankAccount(balance);
            operations.Notify += DisplayNotification;

            int money = 0;
            Console.Write("Enter the amount of deposit: ");
            int check = 0;
            while (check == 0)
            {
                try
                {
                    money = int.Parse(Console.ReadLine());
                    check++;
                    if (money >= 10000 || money <= 200000) balance = money;
                    {
                        check = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Enter the correct amount of deposit again: ");
                    check = 0;
                }
            }
            operations.Put(money);
        }
        private static void Withdraw()
        {
            BankAccount operations = new BankAccount(balance);
            operations.Notify += DisplayNotification;
            int money = 0;
            int check = 0;
            Console.Write("Enter the amount you want to withdraw: ");
            while (balance - money < 0)
            {
                try
                {
                    money = int.Parse(Console.ReadLine());
                    if (money >= 10000 || money <= 200000) balance = money;
                    {
                        check = 1;
                    }
                }
                catch
                {
                    Console.Write("Enter the correct amount you want to withdraw: ");
                }
            }
            if (balance - money < 0)
            {
                Console.WriteLine($"Not enough amount to withdraw. Your current balance: {balance}");
                Console.Write("Enter the amount you want to withdraw: ");
                try
                {
                    money = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter the correct amount: ");
                    money = int.Parse(Console.ReadLine());
                }
            }
            operations.Take(money);
        }
        private static void Transfer()
        {
            BankAccount operations = new BankAccount(balance);
            operations.Notify += DisplayNotification;
            int money;
            Console.Write("Enter the number of account that you want to transfer: ");
            int accNumber = int.Parse(Console.ReadLine());
            int check = 0;
            Console.Write("Enter the amount that you want to transfer: ");
            while (check == 0);
            {
                try
                {
                    money = int.Parse(Console.ReadLine());
                    if (money >= 10000 || money <= 200000) balance = money;
                    {
                        check = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Enter the correct amount: ");
                    money = int.Parse(Console.ReadLine());
                }
            }
            while (balance - money < 0)
            {
                if (balance - money < 0)
                {
                    Console.WriteLine($"Not enough money to transfer. Your balance: ");
                    Console.Write("Enter the amount you want to transfer: ");
                    try
                    {
                        money = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Enter the correct amount: ");
                        money = int.Parse(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine($"You transfered money to account {accNumber}");
            if (balance >= money)
            {
                balance -= money;
                operations.Notify?.Invoke($"You transfered {money}");
            }
        }
        private static void Purchase()
        {
            int money;
            Console.WriteLine("1.Partner's goods | | 2. Standart goods ");
            Console.Write("Choose what you want to buy: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of your purchase");
            int amount = int.Parse(Console.ReadLine());
            if (balance - amount < 0)
            {
                Console.WriteLine($"Not enough money to buy. Your balance {balance}");
                try
                {
                    amount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter the correct amount: ");
                    amount = int.Parse(Console.ReadLine());
                }
            }
            balance -= amount;
            Console.WriteLine($"The amount of your purchase");
            if (a == 1)
            {
                cashback += amount * partnerCashbak_percents;
                balance += cashback;
                Console.WriteLine($"You recevied your cashback: {cashback}. Your balance: {balance}");
            }
            else if (a == 2)
            {
                cashback += a * cashback_percents;
                balance += cashback;
                Console.WriteLine($"You recevied your cashback: {cashback.}. Your balance: {balance}");
            }
            cashback = 0;
        }
    }
}
