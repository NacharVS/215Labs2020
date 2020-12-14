using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.BankClasses
{
    class Bazz
    {
        private string _name;
        private string _sname;
        private int _id;
        private int _money;

        public string Name => _name;
        public string Sname => _sname;
        public int Id => _id;
        public int Money => _money;


        public Baza(string name, string surname, int id, int money)
        {
            _name = name;
            _sname = surname;
            _id = id;
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
        public static void EditName()
        {
            List<Baza> studentList = new List<Baza>();
            studentList.Add(new Baza("ivan", "Kirillov", 1555, 159000));
            studentList.Add(new Baza("Rinaz", "Kashapov", 15, 168000));
            studentList.Add(new Baza("lesuya", "Ilyasova", 007, 190000));
            Console.WriteLine("Ввидите ваш Id");
            int searchId = int.Parse(Console.ReadLine());
            foreach (var item in studentList)
            {

                if (item.Id == searchId
                {
                    Console.WriteLine($"{item.Name} {item.Sname}. Средств на счете: {item.Money}");
                    Console.WriteLine("Введите новую фамилию");
                    string newName = Console.ReadLine();
                    item.SetName(newName);
                }
            }
            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Name} {item.Sname}. Средств на счете: {item.Money}");
            }
        }
        public static void EditSname()
        {
            List<Baza> studentList = new List<Baza>();
            studentList.Add(new Baza("ivan", "Kirillov", 1555, 159000));
            studentList.Add(new Baza("Rinaz", "Kashapov", 15, 168000));
            studentList.Add(new Baza("lesuya", "Ilyasova", 007, 190000));
            Console.WriteLine("Введите ваш Id");
            int searchId = int.Parse(Console.ReadLine());
            foreach (var item in studentList)
            {
                if (item.Id == searchId)
                {
                    Console.WriteLine($"{item.Name} {item.Sname}. Средств на счете: {item.Money}");
                    Console.WriteLine("Введите новую фамилию");
                    string newSname = Console.ReadLine();
                    item.SetSname(newSname);
                }
            }
            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.Name} {item.Sname}. Средств на счете: {item.Money}");
            }

        }
    }
}
