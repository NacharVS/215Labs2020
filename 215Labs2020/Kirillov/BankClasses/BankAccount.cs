using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _215Labs2020.Kirillov.BankClasses
{
    class BankAccount
    {
        private static double balance = 0;
        private static double percents = 0.05;
        private static double cashback_percents = 0.3;
        private static double partnerCashback_percents = 0.2;
        private static double cashback = 0;
        private static long phoneNumber;
        private static int birthDay;
        private static int birthMonth;
        private static int birthYear;
        private static DateTime accountOpenDate;


        public delegate void AccountHandler(string message);
        private event AccountHandler Notify;
        public BankAccount(double sum)
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
                balance -= sum
                Notify?.Invoke($"Withrawn from the account: {sum} ");
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
                Notify?.Invoke($"You transfered: { sum} ");
            }
        }
        public void Deposit(double sum)
        {
            balance += sum;
            Notify?.Invoke($" The account received: {sum} ");
        }
        public static double Sum { get; private set; }
        private static void DisplayNotification(string message)
        {
            Console.WriteLine(message);
        }
        private static void PhoneNumber()
        {
            Console.WriteLine("Enter your phone number: ");
            int chek = 0;
            while (check == 0);
            {
                try
                {
                    phoneNumber = long.Parse(Console.ReadLine());
                    check++;
                    if (phoneNumber / 10000000000 == 0 || phoneNumber / 10000000000 != 8) ;
                    {
                        check = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Enter the correct phone number: ");
                    check = 0;
                }
            }
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
                    if (money >= 10000 || <= 200000) balance = money;
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
            Ban
        }
    }
}

