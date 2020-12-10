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
        public int _id;
    }
}
