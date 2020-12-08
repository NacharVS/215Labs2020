using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin.Bank
{
    class Client : Person
    {
        public int id { get; set; }
        public string _name;
        public int _age;
        public string Name => _name;
        public int Age => _age;
        public Client(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public void SnowName(int newAge)
        {
            _age = newAge;

            Console.WriteLine(newAge);
        }
        public static void Program()
        {
            List<Client> clientList = new List<Client>();
            clientList.Add(new Client("Алексей", 17));
            clientList.Add(new Client("Володя", 20));
            clientList.Add(new Client("Максим", 18));
            clientList.Add(new Client("Петр", 24));
        }
        

    }
}
