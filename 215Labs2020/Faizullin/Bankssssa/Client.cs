using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin.Bankssssa
{
    class Client : Person
    {
        public int _id { get; set; }
        public  string _SNF { get; set; }
        public Client(string name, int id)
        {
            Name = name;
            ID = id;
        }
        public static void SnowName()
        {

            Console.WriteLine("ведите свои данные");
        }


    }
}
