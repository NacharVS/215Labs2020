using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.Bank2
{
    class Abstract
    {
        public DateTime _birthday;
        public double _bill;
        public string _name;
        public int _age;
        public string _telephone;
        public int salary;
        public string Name => _name;
        public DateTime Birthday => _birthday;
        public double Bill => _bill;
        public int Age => _age;
        public string Telephone => _telephone;
        public void ChangeName(string new_name)
        {
            _name = new_name;
        }

    }
}
