using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev
{
    class AccountBank
    {
        private static double balance = 0;
        private static double percents= 0.05;
        private static double cashback_percents = 0.03;
        private static double partnerCashback_percents = 0.2;
        private static double cashback = 0;
        private static long phonenumber;
        private static int birthDay;
        private static int birthMonth;
        private static int birthYear;
        private static DateTime accountOpenDate;

        public delegate void AccountHandler();
        public AccountBank(double sum)
        {
            balance = sum;
        }
        public void Put(double sum)
        {
            balance += sum;
            AccountHandler message = () => Console.WriteLine($"Account recived the amount: {sum}");
            message();
        }
        public void Take(double sum)
        {
            if (balance >= sum)
            {
                balance -= sum;
                AccountHandler message = () => Console.WriteLine($"Withdrawn from the acoount: {sum} ");
                message();
            }
            else
            {
                AccountHandler message = () => Console.WriteLine($"Not enough money. The current balance: {sum} ");
                message();
            }
        }
        public void Transfer(double sum)
        {
            if (balance >= sum)
            {
                balance -= sum;
                AccountHandler message = () => Console.WriteLine($"You transfered: {sum} ");
                message();
            }
        }
        public void Deposit(double sum)
        {
            balance += sum;
            AccountHandler message = () => Console.WriteLine($"The account received: {sum} ");
            message();
        }
        public static double Money { get; private set; }
        private static void DisplayNotification(string message)
        {
            Console.WriteLine(message);
        }
        private static void PhoneNumber()
        {
            Console.WriteLine("Enter your phone number: ");
            int check = 0;
            while (check == 0)
            {
                try
                {
                    phoneNumber = long.Parse(Console.ReadLine());
                    check++;
                    if (phoneNumber / 10000000000 == 0 || phoneNumber / 10000000000 != 8)
                    {
                        check = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Enter the correct phone number: ");
                }
            }
        }
        private static void Refill()
        {
            BankAccount operations = new BankAccount(balance);

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
            AccountBank operations = new AccountBank(balance);
            int money = 0;
            int check = 0;
            Console.Write("Enter the amount you want to withdraw: ");
            while (check == 0)
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
            AccountBank operations = new AccountBank(balance);
            int money = 0;
            Console.Write("Enter the number of account that you want to transfer: ");
            int accNumber = int.Parse(Console.ReadLine());
            int check = 0;
            Console.Write("Enter the amount that you want to transfer: ");
            while (check == 0)
            {
                try
                {
                    money = int.Parse(Console.ReadLine());
                    if (money >= 10000 || money <= 200000) balance = money;
                    {
                        check += 1;
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
                operations.Transfer(money);
            }
        }
        private static void Purchase()
        {
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
            AccountHandler message = () => Console.WriteLine($"The amount of your purchase: {amount}");
            message();
            if (a == 1)
            {
                cashback += amount * partnerCashbaсk_percents;
                balance += cashback;
                Console.WriteLine($"You recevied your cashback: {cashback}. Your balance: {balance}");
            }
            else if (a == 2)
            {
                cashback += a * cashback_percents;
                balance += cashback;
                Console.WriteLine($"You recevied your cashback: {cashback}. Your balance: {balance}");
            }
            cashback = 0;
        }
        private static void Check()
        {
            Console.WriteLine();
            Console.WriteLine($"Your balance: {balance} ");
        }
        public static void Period()
        {
            int OpenSec = accountOpenDate.Hour * 3600 + accountOpenDate.Minute * 60 + accountOpenDate.Second;
            int second = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            int time = second - OpenSec;
            int period = 20;
            period = time / period;
            for (int i = 0; i < period; i++)
            {
                balance = Math.Round(balance + balance * percents, 2);
            }
            Console.WriteLine(balance);
        }
        public static void Menu()
        {
            int check;
            int num_of_operation;
            Console.WriteLine("1.Sign up");
            Console.WriteLine("2.Exit");
            try
            {
                check = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Choose the option");
                check = int.Parse(Console.ReadLine());
            }
            if (check == 1)
            {
                PhoneNumber();
            }
            Console.WriteLine("Enter your day of birth: ");
            birthDay = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(User.Name);
            DateTime birthDate = new DateTime(birthDay, birthMonth, birthYear);
            Console.WriteLine($"Your date if birth: {birthDay}.{birthMonth}.{birthYear} ");
            Console.WriteLine($"Your phone number: {phoneNumber}");
            Console.WriteLine($"The date of opening the account: {accountOpenDate}");
            Console.WriteLine();
            if (DateTime.Now.Year - birthYear < 14)
            {
                Console.WriteLine("You can't use our bank underage");
            }
            else
            {
                Console.WriteLine("1.Refill");
                Console.WriteLine("1.Withdraw");
                Console.WriteLine("3.Transfer");
                Console.WriteLine("4.Buy stuff");
                Console.WriteLine("5.Balance");
                Console.WriteLine("6.Your balance procent");
                Console.WriteLine("7-0.Exit");
                Console.WriteLine();
                Console.WriteLine("Choice your next option: ");
                try
                {
                    num_of_operation = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter right amount");
                    num_of_operation = int.Parse(Console.ReadLine());
                }
                while (num_of_operation < 8)
                {
                    switch (num_of_operation)
                    {
                        case 1: Refill(); break;
                        case 2: Withdraw(); break;
                        case 3: Transfer(); break;
                        case 4: Purchase(); break;
                        case 5: Check(); break;
                        case 6: Period(); break;
                    }
                    Console.WriteLine("Choose your next step: ");
                    try
                    {
                        num_of_operation = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Enter the right amount");
                        num_of_operation = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public static void CheckUser()
        {
            AccountBank bank = new AccountBank(0);
            Client client = new Client("Ivan Ivanov");
            Employee Employee = new Employee("Oleg Olegov");

            Console.WriteLine("1.Client");
            Console.WriteLine("2.Employee");
            client.id = int.Parse(Console.ReadLine());
            accountOpenDate = DateTime.Now;
            if (client.id == 1)
            {
                AccountBank.Menu();
            }
            else if (client.id == 2)
            {
                Employee.employee();
            }
        }
    }
}
