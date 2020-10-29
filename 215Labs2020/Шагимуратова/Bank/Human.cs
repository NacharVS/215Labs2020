using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Шагимуратова.Bank
{
    abstract class Human

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
        class Sotrudnic : Human
        {
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
            public static void sotrud()
            {
                Sotrudnic sotrud = new Sotrudnic();

                Console.WriteLine("enter name");
                sotrud.Name = Console.ReadLine();
                Console.WriteLine("enter surname");
                sotrud.SurName = Console.ReadLine();
                Console.WriteLine("enter otdel");
                sotrud.Otdel = Console.ReadLine();
            }

        }
        class Klient : Human
        {
            private int _summinvklad;
            private static double _procent = 0.13;
            private double _dohod;
            private int _years;
        }
        public static void klient ()
        {
            Klient klient = new Klient();

            Console.WriteLine("enter name");
            klient.Name = Console.ReadLine();
            Console.WriteLine("enter surname");
            klient.SurName = Console.ReadLine();
            Console.WriteLine("Введите сумму пополнения");
            int value = int.Parse(Console.ReadLine());
        }
    }  

    
}  
