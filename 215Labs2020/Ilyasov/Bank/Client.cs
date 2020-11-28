using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilyasov.Bank
{
    class Client : Person
    {
        public int _id { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        public static void SnowName()
        {

            Console.WriteLine(Name);
        }
    }
}
