using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class BankList 
    {
        public string _name;

        public int _age;
        public int _bill;
        public string Name => _name;
        public int Age => _age;
        public int Bill => _bill;
        public BankList(string name,  int age, int bill)
        {
            _name = name;          
            _age = age;
            _bill = bill;
        }
        public int Refill
        {
            get { return _bill; }
            set { _bill -= value; }
        }
        public static void Program()
        {
            List<BankList> PersonInfo = new List<BankList>();
            PersonInfo.Add(new BankList("Расиф", 17, 100000));
            PersonInfo.Add(new BankList("Рифат", 17, 50000));
            PersonInfo.Add(new BankList("Данил", 17, 50000));
        }

    }
}
