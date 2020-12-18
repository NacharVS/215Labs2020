using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.Bank2
{
    class Person : Abstract
    {
        public Person(double bill, string name, DateTime birthday, string telephone)
        {
            _bill = bill;
            _name = name;
            _birthday = birthday;
            _telephone = telephone;
            _age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month <= birthday.Month && DateTime.Now.Day < birthday.Day)
            {
                _age -= 1;
            }
        }
        public static Dictionary<int, Person> Info = new Dictionary<int, Person>();        
        public static void NewName(int nomer, string newname)
        {
            foreach (var item in Info)
            {
                if (item.Key == nomer)
                {
                    item.Value.ChangeName(newname);
                }

            }
        }
        public static void GetInfo()
        {
            foreach (var item in Info)
            {
                Console.WriteLine(item.Value.Age);
            }
        }
        public static void Program()
        {
            Info.Add(001, new Person(1000, "Рифат", new DateTime(1999, 12, 20), "89839128391238"));
            Info.Add(002, new Person(2000, "Рузаль", new DateTime(1999, 01, 1), "89839128391238"));
            GetInfo();
            NewName(001, "Расиф");
            GetInfo();
        }
    }
}
