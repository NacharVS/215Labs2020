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
        
        public static void Login()
        {
            

        }
    }
}
