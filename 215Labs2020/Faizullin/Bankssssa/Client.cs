using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin.Bankssssa
{
    class Client : Person
    {
        public int _id { get; set; }
        public int _age { get; set; }
        public  string _snf { get; set; }
        public Client(string snf, int id, int age)
        {
            _snf = snf;
            ID = id;
            Age = age; 
        }
        //public static void SnowName()
        //{

        //    Console.WriteLine("ведите свои данные");
        //}


    }
    //public void SetSNF(string new_SNF)
    //{
    //     = new_SNF;
    //}
    //public void SetAge(int newAge)
    //{
    //    Age = newAge;
    //}
}
