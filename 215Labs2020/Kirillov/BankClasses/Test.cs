using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.BankClasses
{
    class Test
    {
        private string _name;
        private string _sname;
        private int _id;
        private int _money;


        private string Name => _name;
        private string Sname => _sname;
        private int Id => _id;
        private int Money => _money;



        public Test(string name, string surname, int money)
        {
            _name = name;
            _sname = surname;
            _money = money;
        }
        public void SetSname(string newSname)
        {
            _sname = newSname;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }

        public void EditName()
        {
            Dictionary<int, Test> baza = new Dictionary<int, Test>();
            baza.Add(1, new Test("ivan", "Kirillov", 159000));
            baza.Add(2, new Test("Rinaz", "Kashapov", 168000));
            baza.Add(3, new Test("lesuya", "Ilyasova", 190000));
        }
    }
}
