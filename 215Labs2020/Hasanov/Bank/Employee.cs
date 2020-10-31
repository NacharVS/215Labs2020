using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Bank
{
    {
    class Employee : Person
    {
        public int _id { get; set; }
        private static int Salary = 40000;
        private static double Salary_balans = 0;
        public Employee(string name)
        {

            string Name = name;
        }
        public static void employee()
        {
            Console.WriteLine(Employee.Name);
            if (DateTime.Now.Day > 28)
            {
                Salary_balans += Salary;
                Console.WriteLine($"Ваша зарплата {Salary_balans} рублей");

            }
            else
            {
                Console.WriteLine($"Зарплата начислится 28 го числа");
            }
        }
    }
}