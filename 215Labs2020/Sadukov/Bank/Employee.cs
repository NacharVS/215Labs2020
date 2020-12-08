using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Sadukov
{
    class Employee : Bank
    {
        private static double salary;
        private static string profession;
        private static int experience;

       
        private static void stah()
        {
            Console.WriteLine("Your work experience:");
            Employee.experience = int.Parse(Console.ReadLine());
            
        }
        


        public static void prof(string x)
        {
            if (x == "Manager")
            {
                Employee.salary = 2500;
                
            }
            else if (x == "Cashier")
            {
                Employee.salary = 2200;
                
            }
            else if (x == "Security")
            {
                Employee.salary = 2000;
               
            }
            else if (x == "Boss")
            {
                Employee.salary = 100000;
                
            }
            else if (x == "Janitor")
            {
                Employee.salary = 1500;
                
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
            Random bank123 = new Random();
            Bank.Id = bank123.Next(1000000, 1999999);
            Console.WriteLine("Choose a profession:(Manager, Cashier, Security, Boss, Janitor)");
            Employee.profession = Console.ReadLine();
            Employee.prof(Employee.profession);
            int yes = 1;
            while (yes == 1)
            {
                Console.WriteLine("What do you want to do (Find out salary per month,find out your ID)");
                Console.WriteLine("Press 1 find out salary per month\nPress 2 to find out your ID");
                string enter = Console.ReadLine();
                switch (enter)
                {
                    case "1":

                        Console.WriteLine($"Your salary per month: {Employee.salary}" );
                        Console.WriteLine("Do you want to continue?\n y/n");
                        string cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                    case "2":
                        Console.WriteLine($"Your ID: {Bank.Id} ");
                        Console.WriteLine("Do you want to continue?\n y/n");
                        cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
 
                }
            }

        }
    }
}
