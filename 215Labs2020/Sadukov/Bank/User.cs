﻿using System;
using System.Collections;


namespace _215Labs2020.Sadukov.User
{
    class User : Bank
    {
        private static double money = 0;
        private static double deposit = 0.061;


        public static void Check()
        {
            Console.WriteLine($"Login as Employee or User?");
            Console.WriteLine($"Enter 1 to login as Employee or enter 2 to login as User");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    Employee.Login();
                    break;
                case "2":
                    User.Login();
                    break;
                case "3":

                    break;
            }

        }


        private static void Withdraw()
        {
            Console.WriteLine("How many do you want to withdraw?");
            int x = int.Parse(Console.ReadLine());
            if (x > money | x < 0)
            {
                Console.WriteLine("insufficient funds to write off");
            }
            else User.money -= x;
            Console.WriteLine($"You have {User.money} in your account");
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
                    User.money += y;
                    Console.WriteLine($"Account replenished\n{User.money}");

                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }

        }
        private static void percent()
        {

            double x = User.money * User.deposit;
            User.money += x;
            Console.WriteLine($"Your deposit will change in {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year + 1} and will be: {User.money}");
        }

        public static void signIn()
        {
            
            
            Console.WriteLine("Enter your full name:");
            string name = Console.ReadLine();
            User.UserName(name);
           
            Console.WriteLine("Enter your BirthDay");
            Bank.Day = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your BirthMonth");
            Bank.Month = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your BirthYear");
            Bank.Age = int.Parse(Console.ReadLine());
            
            User.Birth(Month, Age, Day);
            User.EmailCheck();
            
           
            

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
                User.Name = Newname;
            }
            User.Name = Newname;

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
                    User.money += 100;

                    Console.WriteLine($"it's your birthday!!! You are now {DateTime.Now.Year - b} year old.");
                    Console.WriteLine(User.money);
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
                    User.Email = em;
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
            User.signIn();
            Random bank123 = new Random();
            Bank.Id = bank123.Next(1000000, 1999999);
            ArrayList list = new ArrayList();
            list.Add(User.Name);
            list.Add(User.Month);
            list.Add(User.Day);
            list.Add(User.Age);
            list.Add(Bank.Id);

            Console.WriteLine($"Your id: {Bank.Id}");
            int yes = 1;
            while (yes == 1)
            {
                Console.WriteLine("What do you want to do (deposit money, withdraw money, Find out the amount of funds after replenishment of the deposit)");
                Console.WriteLine("Press 1 to deposit money\nPress 2 to withdraw money\nPress 3 to find out the amount of funds after replenishment of the deposit ");
                string enter = Console.ReadLine();
                switch (enter)
                {
                    case "1":

                        User.Desposit();
                        list.Add(User.money);
                        Console.WriteLine("Do you want to continue?\n y/n");
                        string cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                    case "2":
                        User.Withdraw();
                        Console.WriteLine("Do you want to continue?\n y/n");
                        cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                    case "3":
                        User.percent();
                        Console.WriteLine("Do you want to continue?\n y/n");
                        cont = Console.ReadLine();
                        if (cont == "n") yes = 0;

                        break;
                    case "4":
                        User.Check();
                        break;
                        }
            }
        }
    }
}
