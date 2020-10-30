using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov
{
    class Employee : Bank
    {
        private static double salary;
        private static string profession;
        private static int exp;

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
                Console.WriteLine($"Your salary: {Employee.salary}");
            }
            else if (x == "Cashier")
            {
                Employee.salary = 20000;
                Console.WriteLine($"Your salary: {Employee.salary}");
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
