using System;
using _215Labs2020.Imamov.BankAcc;

namespace _215Labs2020.Imamov.BankAcc
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
