using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class Person
    {
        private string _name;
        private string _telephone;
        private string _birthday;
        private int _dayCreation;
        private double _bill;
        private int _dateTime;
        public Person(string name, string telephone, string birthday)
        {
            _name = name;
            _telephone=telephone;
            _birthday = birthday;
        }
        public void GetInfo()
        {
            Console.WriteLine($"ФИО: {_name}");
            Console.WriteLine($"Дата рождания: {_birthday}");
            Console.WriteLine($"Телефон: {_telephone}");
        }
        public void Balance()
        {
            Console.WriteLine($"Баланс счета: {_bill}");
        }
        public double Refill
        {
            get { return _bill; }
            set 
            { 
                if (value>200000 || value<10000)
                {
                    Console.WriteLine("Ошибка. Взнос должен быть больше 10 000 и меньше 200 000.");
                    return;
                }
                _bill += value; 
            }
        }
        public double TakeAway
        {
            get { return _bill; }
            set 
            {
                if (_bill<value)
                {
                    Console.WriteLine("Ошибка. Не достаточно средств на балансе.");
                    return;
                }
                _bill += value; 
            }
        }
        public double CashBack
        {
            get { return _bill; }
            set
            {
                if (_bill < value)
                {
                    Console.WriteLine("Ошибка. Не достаточно средств на балансе.");
                    return;
                }
                _bill -= value;
                _bill += value * 0.01;
            }
        }
    }
    class Bank2
    {
        public delegate void Operation(double donation);
        public static void Action()
        {
            Operation oper;
            Person man = new Person("Сидоров Сидор Сидорович","464646546","28.03.2003");
            oper = man.Person.Refill;
            oper =  man.CashBack;
            man.GetInfo();
            man.Balance();
        }
    }
}
