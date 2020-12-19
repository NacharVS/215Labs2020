using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.BankKlas
{
    class Baza
    {
        private string _name;
        private string _suname;
        private int _id;
     

        public string Name => _name;
        public string Sname => _suname;
        public int Id => _id;
      
        public Baza(string name, string surname, int year , int id)
        {
            _name = name;
            _suname = surname;
            _id = id;           
        }
        public void SetSname(string newSname)
        {
            _suname = newSname;
        }
        public void SetName(string newName)
        {
            _name = newName;
        }
        public static void izmeninii()
        {
            List<Baza> studentList = new List<Baza>();
            studentList.Add(new Baza("Pavlic", "Morozov", 13, 1));
            studentList.Add(new Baza("Норман", "Маттиас", 27, 2));
            studentList.Add(new Baza("Сергей", "Брин", 35, 228));
            Console.WriteLine("Введите ваш Id");
            int searchId = int.Parse(Console.ReadLine());
            foreach (var item in studentList)
            {
                if (item.Id == searchId)
                {
                    Console.WriteLine("Выберети что изменить");
                    string vybor = Console.ReadLine();
                    if (vybor == "имя")
                    {
                        Console.WriteLine("Введите новое имя");
                        string newName = Console.ReadLine();
                    }
                    if (vybor == "фамилия")
                    {
                        Console.WriteLine("Введите новую фамилию");
                        string newSname = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("вышла ошибка");
                        System.Environment.Exit(0);

                    }

                }
                Console.WriteLine(studentList);
            }

            //public void dictionary()
            //{
            //    Dictionary<int, Test> baza = new Dictionary<int, Test>();
            //    baza.Add(1, new Test("Sashka ", "Kokokorin", 159000));
            //    baza.Add(2, new Test("Bulat", "IBR", 168000));
            //    baza.Add(3, new Test("Rasif", "Saf", 190000));

            //    int a = int.Parse(Console.ReadLine());

            //    foreach (KeyValuePair<int, Test> item in baza)
            //    {
            //        if (a == item.id)
            //        {

            //            string s = Console.ReadLine();
            //            item.name = s;
            //            Console.WriteLine(item.name);
            //        }

            //    }
        } //}
    }
}


