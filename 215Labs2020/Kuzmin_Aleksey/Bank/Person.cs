using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Bank
{
    abstract class Person
    {
        public double _bill;
        public string _name;
        public DateTime _birthday;
        public int _age;
        public string _telephone;
        public int _salary;
        public static int _users = 0;
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetPhone(string newTelephone)
        {
            _telephone = newTelephone;
        }
        public void SetBirthday(DateTime newBirthday)
        {
            _birthday = newBirthday;
            _age = 0;
            if (DateTime.Now.Month <= _birthday.Month && DateTime.Now.Day < _birthday.Day)
            {
                _age -= 1;
            }
            _age = _age + DateTime.Now.Year - _birthday.Year;
        }
        public double Refill
        {
            get { return _bill; }
            set
            {
                if (value >= 10000 && value <= 200000)
                {
                    _bill += value;
                }
            }
        }
        public double Remove
        {
            get { return _bill; }
            set
            {
                if (_bill >= value)
                {
                    _bill -= value;
                }
            }
        }

    }
}
