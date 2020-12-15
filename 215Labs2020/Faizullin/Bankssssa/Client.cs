using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin.Bankssssa
{
    class Client : Person
    {
        public int _id { get; set; }
        public int _age { get; set; }
        public string _snf { get; set; }
        public Client(string snf, int id, int age)
        {
            _snf = snf;
            _id = id;
            _age = age;
        }

        public Client(string v1, int v2)
        {

        }


        public void SetSNF(string newSNF)
        {
            _snf = newSNF;


        }
        public static void zzzz()
        {
            Dictionary<int, Client> clientList = new Dictionary<int, Client>();
            clientList.Add(134, new Client("Popov", 45, 121));
            clientList.Add(235, new Client("Faizullin", 23, 12));
            clientList.Add(232, new Client("Ivanov", 56, 1212));
            clientList.Add(443, new Client("Ibragimov", 13, 121));
            clientList.Add(311, new Client("IIIIII", 20, 1214));
            foreach (var item in clientList)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }
        public static void EditSNF(List<Client> list, string newSNF, int searchID)
        {
            foreach (var item in list)
            {
                if (item.ID == searchID)
                {
                    item.SetSNF(newSNF);
                }
            }
        }
           
    }
}
