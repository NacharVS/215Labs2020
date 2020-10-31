using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova
{
    class Employee: Person
    {

        public double salary = 45000;

        public Employee()
        {
            id = 1;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Введите ФИО работника");
            SNP = Console.ReadLine();
            Console.WriteLine($"ФИО: {SNP} Зарплата: {salary} руб");
        }
    }
}
