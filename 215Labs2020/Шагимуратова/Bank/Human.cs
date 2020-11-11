using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Bank
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
        private static double salary;
        private string _Otdel;
        public string Otdel
        {
            get
            {
                return _Otdel;
            }
            set
            {
                _Otdel = value;
            }
        }
       
        public static void Personal(string a) 
            {
            if (a=="manager")
            {
                Sotrudnic.salary = 40000;
                Console.WriteLine($"Your salary: {Sotrudnic.salary}");
            }
            if (a == "consultant")
            {
                Sotrudnic.salary = 30000;
                Console.WriteLine($"Your salary: {Sotrudnic.salary}");
            }
            if(a== "cashier")
            {
                Sotrudnic.salary = 25000;
                Console.WriteLine($"Your salary: {Sotrudnic.salary}");
            }
            }
            public static void sotrud()
            {
                Sotrudnic sotrud = new Sotrudnic();

                Console.WriteLine("enter name");
                sotrud.Name = Console.ReadLine();
                Console.WriteLine("enter surname");
                sotrud.SurName = Console.ReadLine();
                Console.WriteLine("enter otdel (manager/consultant/cashier) ");
                sotrud.Otdel = Console.ReadLine();
            Console.WriteLine($"your salary");
           
        }
            
        }
}  

    

