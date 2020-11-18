using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{  
    class Person
    {
        public string _name;
        public string _telephone;
        public string _birthday;
        public int _dayCreation;
        public double _bill;
        public int _dateTime;
        public double Refill
        {
            get { return _bill; }
            set { _bill += value; }
        }
        public double TakeAway
        {
            get { return _bill; }
            set { _bill += value; }
        }
        public double CashBack
        {
            get { return _bill; }
            set
            {                
                _bill += value * 0.01;
            }
        }
    }
    class Bank2
    {        
        public static Person man = new Person();
        private static void CreateAccount(string name, string telephone, string birthday)
        {
            man._name = name;
            man._telephone=telephone;
            man._birthday = birthday;
        }      
        private static void balance()
        {
            Console.WriteLine(man._bill);
        }
        public static void Action()
        {
            man.Refill = 100;
            balance();
            man.CashBack = 1000;
            balance();
        }
    }
}
