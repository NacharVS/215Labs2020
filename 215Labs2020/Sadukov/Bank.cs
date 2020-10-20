using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov
{
    class Bank
    {

        public string name;
        public string birthDay;
        public string email;       
        public static double money = 0;
        public static double deposit = 0.061;
        public static void Desposit(int x)
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
        public static void percent()
        {

            double x  = Bank.money * Bank.deposit;
            Bank.money += x;
            Console.WriteLine($"Your deposit will change in {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year + 1} and will be: {Bank.money}");
        } 

        public static void login()
        {
            Bank user = new Bank();
            Console.WriteLine("Enter your full name");
            user.name = Console.ReadLine();
            Console.WriteLine("Enter your BirthDay");
            user.birthDay = Console.ReadLine();
            Console.WriteLine("Enter your e-mail");
            user.email = Console.ReadLine();
            Console.WriteLine("Your Deposit");
            int x = int.Parse(Console.ReadLine());
            Bank.Desposit(x);
            Console.WriteLine("Replenishment by interest");
            Bank.percent();



        }           
    }
}
