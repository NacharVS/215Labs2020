using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Bank
{
    class Client : Person
    {
        public string _name;
        public string _phone;
        public int _age;
        public DateTime _birthday;
        public int _id;
        public string Name => _name;
        public string Phone => _phone;
        public int Age => _age;
        public int id => _id;
        public DateTime Birthday => _birthday;

        static List<Client> Person = new List<Client>();
        public Client(string name, string phone,int age, int id, DateTime birthday)
        {
            _name = name;
            _phone = phone;
            _age = age;
            _id = id;
            _birthday = birthday;

        }
        public void SnowName(string newName)
        {
            _name = newName;
        }
        public void SnowPhone(string newPhone)
        {
            _phone = newPhone;
        }
        public void SnowBirthday(string newBirthday)
        {
            _birthday = newBirthday; 
        }



        public static void Program()
        {
            
        }

    }
}
