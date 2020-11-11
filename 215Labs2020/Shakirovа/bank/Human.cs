using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Shakirovа.bank
{
    public abstract class Human

    {
        private string _name;
        private string _Surname;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string SurName
        {
            get
            {
                return _Surname;
            }
            set
            {
                _Surname = value;
            }
        }
    }
    class Sotrudnic : Human
    {
        private string prof;
        public string Prof
        {
            get
            {
                return Prof;
            }
            set
            {
                Prof = value;
            }
        }
        
        public static void sotrud()
        {
            Sotrudnic sotrud = new Sotrudnic();

            Console.WriteLine("enter name");
            sotrud.Name = Console.ReadLine();
            Console.WriteLine("enter surname");
            sotrud.SurName = Console.ReadLine();

        }
        public static void proff()
        {
            Console.WriteLine("enter prof 1 -manager 2 -consultant 3 -casher");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.WriteLine("your salary-40000");
                    break;
                case "2":
                    Console.WriteLine("your salary-30000");
                    break;
                default:
                    Console.WriteLine("your salary-25000");
                    break;
            }



        }
    }
}
