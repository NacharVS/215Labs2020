using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Bank
{
    class Client : Person
    {
        public int id { get; set; }
        public Client(string name)
        {
            Forename1 = name;
        }
        public static void SnowName()
        {

            Console.WriteLine(Forename1);
        }
    }
}
