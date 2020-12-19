using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ilysov.Bank
{
   class Proverka
    {
        private string _name;
        private string _sname;
        private int _id;
        private int _money;

        public string Name => _name;
        public string Sname => _sname;
        public int Id => _id;
        public int Money => _money;


        public Proverka(string name, string surname, int money)
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
            Dictionary<int, Proverka> baza = new Dictionary<int, Proverka>();
            baza.Add(1, new Proverka("Timur", "Ilyasov", 159000));
            baza.Add(2, new Proverka("Kamil", "Sharipov", 168000));
            baza.Add(3, new Proverka("Ivan", "Kirillov", 190000));


        }
    }
}
