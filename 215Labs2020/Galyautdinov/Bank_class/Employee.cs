using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov.Bank_class
{
    class Employee : Person
    {
        public int _id { get; set; }
        private static int zp=35000;
        private static double zp_balans = 0;
        public Employee(string name)
        {
            Name = name;
        }
        public static void employee()
        {
            if (DateTime.Now.Day > 28)
            {
                zp_balans += zp;

            }
            else
            {
                Console.WriteLine($"Зарплата начислится 28 го числа");
            }
        }
    }
}
