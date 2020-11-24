using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamov.Bank
{
    class Client : User
    {
        public int id { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        public static void ShowName()
        {
            Console.WriteLine(Name);
        }
    }
}
