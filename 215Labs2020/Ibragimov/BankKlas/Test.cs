using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.BankKlas
{
    class Test
    {
        private string _name;
        private string _sname;
        private int _id;
     

        public string Name => _name;
        public string Sname => _sname;
        public int Id => _id;
       


        public Test(string name, string surname, int id)
        {
            _name = name;
            _sname = surname;
            _id = id;
        }
      

        public void EditName()
        {
            Dictionary<int, Test> baza = new Dictionary<int, Test>();
            baza.Add(1, new Test("Sashka ", "Kokokorin", 159000));
            baza.Add(2, new Test("Bulat", "IBR", 168000));
            baza.Add(3, new Test("Rasif", "Saf", 190000));

            int a = int.Parse(Console.ReadLine());

            foreach (KeyValuePair< int, Test> item in baza)
            {
                if (a == item.id)
                {

                     string s = Console.ReadLine();
                    item.name = s;
                    Console.WriteLine(item.name);
                }

            }

        }
    }
}



