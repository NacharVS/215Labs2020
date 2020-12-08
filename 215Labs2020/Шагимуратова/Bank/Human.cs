using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Bank
{
    public abstract class Human
    {
        private string _name;
        private string _Surname;
        private string _Otchestvo;
        private string _DayBD;
        private string _MonthBD;
        private string _YearBD;
        private int _id;





        public  string Name
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
        public string Otchestvo
        {
            get
            {
                return _Otchestvo;
            }
            set
            {
                _Otchestvo = value;
            }
        }
        public string DayBD
        {
            get
            {
                return _DayBD;
            }
            set
            {
                _DayBD = value;
            }
        }
        public string MonhtBD
        {
            get
            {
                return _MonthBD;
            }
            set
            {
                _MonthBD = value;
            }
        }
        public string YearBD
        {
            get
            {
                return _YearBD;
            }
            set
            {
                _YearBD = value;
            }
        }

        public int Id { get => _id; set => _id = value; }
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

    

