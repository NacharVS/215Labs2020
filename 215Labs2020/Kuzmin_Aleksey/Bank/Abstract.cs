using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey.Bank
{
    abstract class Abstract
    {
        public DateTime _birthday;
        public double _bill;
        public string _name;        
        public int _age;
        public string _telephone;
        public int _salary;
        public string Name => _name;
        public double Bill => _bill;
        public DateTime Birthday => _birthday;
        public string Telephone => _telephone;
        public int Age => _age;
        public int Salary => _salary;
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
        public void Refill(double donation)
        {
            if (donation >= 10000 && donation <= 200000)
            {
                _bill += donation;
            }
        }
        public void Remove(double donation)
        {
            if (_bill >= donation)
            {
                _bill -= donation;
            }
        }
    }
}
