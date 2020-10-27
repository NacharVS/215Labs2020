﻿using System;

namespace _215Labs2020.Sadukov
{
    class Bank
    {

        private string name;
        private int day;
        private int month;
        private int age;
        private static string email = "";
        private static double money = 0;
        private static double deposit = 0.061;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (DateTime.Now.Year - value < 14)
                {
                    Console.WriteLine("You are underage");
                }
                else age = value;
            }
        }

        private static void Withdraw()
        {
            Console.WriteLine("How many do you want to withdraw?");
            int x = int.Parse(Console.ReadLine());
            if (x > money | x < 0 )
            {
                Console.WriteLine("insufficient funds to write off");
            }
            else Bank.money -= x;
            Console.WriteLine($"You have {Bank.money} in your account");
        }
        private static void Desposit()
        {

            Console.WriteLine("Введите число");
            int y;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out y))
            {
                if (y < 10000 & y < 200000)
                {
                    Console.WriteLine("Error. Deposit is less than 10000 or more than 200000");
                }
                else
                {
                    Bank.money += y;
                    Console.WriteLine($"Account replenished\n{Bank.money}");

                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
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
            user.Age = int.Parse(Console.ReadLine());
            Bank.Birth(user.month, user.age, user.day);
            Bank.EmailCheck();
            
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
            if (b > 1900 & b < DateTime.Now.Year & c > 0 & c <= 31 & a > 0 & a <= 12)
            {
                if (DateTime.Now.Year - b < 18)
                {
                    Console.WriteLine("You are underage :(");

                }
                else if (c == DateTime.Now.Day & a == DateTime.Now.Month)
                {
                    Bank.money += 100;

                    Console.WriteLine($"it's your birthday!!! You are now {DateTime.Now.Year - b} year old.");
                    Console.WriteLine(Bank.money);
                }
                
            }


        }
        private static void EmailCheck()
        {
            int a = 1;
            while (a == 1)
            {
                Console.WriteLine("Enter your E-mail");
                string em = Console.ReadLine();
                bool c = em.Contains('@');
                if (c == true)
                {
                    a = 0;
                    Bank.email = em;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    Console.WriteLine("Try again");
                }
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
                        
                        Bank.Desposit();
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
