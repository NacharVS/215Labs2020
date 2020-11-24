using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.Bank
{
    class Emploee : User
    {
        public int id { get; set; }
        private static int payment = 37000;
        private static double balance = 0;
        public Emploee(string name2)
        {
            Name2 = name2;
        }
        public static void employee()
        {
            Console.WriteLine($"Current date: {DateTime.Now}");
            Console.WriteLine(Emploee.Name2);
            if(DateTime.Now.Day > 15)
            {
                balance += payment;
                Console.WriteLine($"Your payment {balance}");
            }
            else
            {
                Console.WriteLine($"Payday at 15 day of every month");
            }
        }
    }
}
