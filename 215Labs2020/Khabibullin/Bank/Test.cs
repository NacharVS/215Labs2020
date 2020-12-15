using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Bank
{
    class Test
    {
        private string _name;
        private string _surname;
        private int _id;
        private int _money;

        private string Name => _name;
        private string Surname => _surname;
        private int Id => _id;
        private int Money => _money;

        public Test(string name, string surname, int money)
        {
            _name = name;
            _surname = surname;
            _money = money;
        }
        public void SetSurname(string newSurname)
        {
            _surname = newSurname;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }
        public void EditName()
        {
            Dictionary<int, Test> baza = new Dictionary<int, Test>();
            baza.Add(1, new Test("Insaf", "Khabibullin", 159000));
            baza.Add(2, new Test("Ranel", "Imamiev", 168000));
            baza.Add(3, new Test("Bulat", "Basharov", 19000));
        }
    }
}
