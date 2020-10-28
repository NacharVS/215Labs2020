using System;
using System.Collections.Generic;
using System.Text;
using _215Labs2020.Galyautdinov;

namespace _215Labs2020.Galyautdinov.Bank_class
{
    abstract class BankPerson
    {
        public static string Name { get; set;}
        public BankPerson(string name)
        {
            Name = name;
        }
    }
    class Client : BankPerson
    {
        public int Sum { get; set; }

        public Client(string name, int sum)
            : base(name)
        {
            Sum = sum;
        }
    }
    class Employee : BankPerson
    {
        public string Position { get; set; }

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }
    }
}
