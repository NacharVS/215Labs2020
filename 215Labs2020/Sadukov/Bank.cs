﻿using System;

namespace _215Labs2020.Sadukov
{
    class Bank
    {

        private string name;
        private int day;
        private int month;
        private int year;
        private string email;
        private static double money = 0;
        private static double deposit = 0.061;

        private static void Withdraw()
        {
            Console.WriteLine("How many do you want to withdraw?");
            int x = int.Parse(Console.ReadLine());
            if (x > money)
            {
                Console.WriteLine("insufficient funds to write off");
            }
            else Bank.money -= x;
            Console.WriteLine($"You have {Bank.money} in your account");
        }
        private static void Desposit(int x)
        {
            if (x < 10000)
            {
                Console.WriteLine("Unable to top up: Deposit less than 10000");
            }
            else
            {
                Bank.money += x;
                Console.WriteLine($"Account replenished\n{Bank.money}");

            }
        }
        private static void percent()
        {

            double x = Bank.money * Bank.deposit;
            Bank.money += x;
            Console.WriteLine($"Your deposit will change in {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year + 1} and will be: {Bank.money}");
        }

        private static void signIn()
        {
            Bank user = new Bank();
            Console.WriteLine("Enter your full name:");
            string name = Console.ReadLine();
            Bank.UserName(name);
            Console.WriteLine("Enter your BirthDay");
            user.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your BirthMonth");
            user.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your BirthYear");
            user.year = int.Parse(Console.ReadLine());
            Bank.Birth(user.month, user.year, user.day);
            Console.WriteLine("Enter your e-mail");
            user.email = Console.ReadLine();
        }
        private static void UserName(string Newname)
        {

            Newname = Newname.Trim();
            var first = Newname[0];
            if (first.ToString() != first.ToString().ToUpper())
            {
                var other = Newname.Remove(0, 1);
                Newname = first.ToString().ToUpper() + other;
                Console.WriteLine($"Your name with a capital letter: {Newname}");
            }

        }
        private static void Birth(int a, int b, int c)
        {
            if (c == DateTime.Now.Day & a == DateTime.Now.Month)
            {
                Bank.money += 100;
                
                Console.WriteLine($"У тебя день рождения!!! Твой возраст {DateTime.Now.Year - b} .Тебе начисленно 100!");
                Console.WriteLine(Bank.money);
            }


        }
        public static void Login()
        {
            Bank.signIn();
            int yes = 1;
            while (yes == 1)
            {
                Console.WriteLine("What do you want to do (deposit money, withdraw money, Find out the amount of funds after replenishment of the deposit)");
                Console.WriteLine("Press 1 to deposit money\nPress 2 to withdraw money\nPress 3 to find out the amount of funds after replenishment of the deposit ");
                string enter = Console.ReadLine();
                switch (enter)
                {
                    case "1":
                        Console.WriteLine("Amount of money you want to deposit");
                        int x = int.Parse(Console.ReadLine());
                        Bank.Desposit(x);
                        Console.WriteLine("Do you want to continue?\n y/n");
                        string cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                    case "2":
                        Bank.Withdraw();
                        Console.WriteLine("Do you want to continue?\n y/n");
                        cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                    case "3":
                        Bank.percent();
                        Console.WriteLine("Do you want to continue?\n y/n");
                        cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                       
                        break;
                }
            }
        }
    }
}
