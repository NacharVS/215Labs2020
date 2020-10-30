using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.Bank_class
{
    class Bank_1
    {
        abstract class BankPerson
        {
        public static string Name { get; set; }
            public BankPerson(string name)
            {
                Name = name;
            }
        }
        class User : BankPerson
        {
            public int Sum { get; set; }

            public User(string name, int sum)
                : base(name)
            {
                Sum = sum;
            }
        }
        class Worker : BankPerson
        {
            public string Position { get; set; }

            public Worker(string name, string position)
                : base(name)
            {
                Position = position;
            }
        }
    }
}

