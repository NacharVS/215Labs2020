using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Khabibullin.Bank
{
    class Baza
    {
        private string _name;
        private string _surname;
        private int _id;
        private int _money;

        public string Name => _name;
        public string Surname => _surname;
        public int Id => _id;
        public int Money => _money;

        public Baza(string name, string surname, int id, int money)
        {
            _name = name;
            _surname = surname;
            _id = id;
            _money = money;
        }
        public void SetSname(string newSname)
        {
            _surname = newSname;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }
        public static void EditName()
        {
            List<Baza> studentList = new List<Baza>();
            studentList.Add(new Baza("Insaf", "Khabibullin", 1555, 159000));
            studentList.Add(new Baza("Ranel", "Imamiev", 15, 168000));
            studentList.Add(new Baza("Bulat", "Basharov", 007, 190000));
            Console.WriteLine("Введите ваш Id");
            int searchId = int.Parse(Console.ReadLine());
            foreach (var item in studentList)
            {
                if (item.Id == searchId)
                {
                    Console.WriteLine($"{item.Name} {item.Surname}. Средств на счете: {item.Money}");
                    Console.WriteLine("Введите новую фамилию");
                    string newName = Console.ReadLine();
                    item.SetName(newName);
                }
            }
            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Name} {item.Surname}. Средств на счете: {item.Money}");
            }

        }
        public static void EditSurname()
        {
            List<Baza> studentList = new List<Baza>();
            studentList.Add(new Baza("Insaf", "Khabibullin", 1555, 159000));
            studentList.Add(new Baza("Ranel", "Imamiev", 15, 168000));
            studentList.Add(new Baza("Bulat", "Basharov", 007, 190000));
            Console.WriteLine("Введите ваш Id");
            int searchId = int.Parse(Console.ReadLine());
            foreach (var item in studentList)
            {
                if (item.Id == searchId)
                {
                    Console.WriteLine($"{item.Name} {item.Surname}. Средств на счете: {item.Money}");
                    Console.WriteLine("Введите новую фамилию");
                    string newSurname = Console.ReadLine();
                    item.SetSname(newSurname);
                }
            }
            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Name} {item.Surname}. Средств на счете: {item.Money}");
            }
        }
    }
}
