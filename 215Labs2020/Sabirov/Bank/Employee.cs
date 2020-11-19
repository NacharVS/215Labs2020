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
        public delegate void Handler(string message);
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
            if (x == "Manager")
            {
                Employee.salary = 25000;
                Notify?.Invoke($"Your salary: {Employee.salary}");
            }
            else if (x == "Cashier")
            {
                Employee.salary = 20000;
                Notify?.Invoke($"Your salary: {Employee.salary}");
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
