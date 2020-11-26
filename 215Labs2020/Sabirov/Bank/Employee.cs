using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sabirov
{
    class Employee : Bank
    {
        private static double salary;
        private static string profession;
        private static int exp;
        public delegate void Handler();
        public static event Handler Notify;

        public static void DisplayMes(string mes)
        {
            Console.WriteLine(mes);
        }



        private static void stah()
        {
            Console.WriteLine("Your work experience:");
            Employee.exp = int.Parse(Console.ReadLine());

        }


        public static void prof(string x)
        { 
            Notify += () => Console.WriteLine($"Your salary: {Employee.salary}");
            if (x == "Manager")
            {
                Employee.salary = 25000;
                Notify?.Invoke();
            }
            else if (x == "Cashier")
            {
                Employee.salary = 15000;
                Notify?.Invoke();
            }
        }
        private static void signIn()
        {
            Console.WriteLine("Enter your full name:");
            Bank.Name = Console.ReadLine();
            Console.WriteLine("Enter your BirthDay");
            Bank.Day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your BirthMonth");
            Bank.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your BirthYear");
            Bank.Age = int.Parse(Console.ReadLine());


        }
        public static void Login()
        {
            Employee.signIn();
            Employee.stah();
            Console.WriteLine("Your occupation");
            Employee.profession = Console.ReadLine();
            Employee.prof(Employee.profession);
            Console.WriteLine(Employee.exp);



        }
    }
}
