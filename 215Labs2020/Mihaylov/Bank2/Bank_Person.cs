using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.Bank2
{
    class Bank_Person : Abstract
    {
        public Bank_Person(double bill, string name, DateTime birthday, string telephone)
        {
            _bill = bill;
            _name = name;
            _birthday = birthday;
            _telephone = telephone;
            _age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month <= birthday.Month && DateTime.Now.Day < birthday.Day)
            {
                _age -= 1;
            }
        }
        public static Dictionary<int, Bank_Person> Info = new Dictionary<int, Bank_Person>();        
        public static void NewName(int nomer, string newname)
        {
            foreach (var item in Info)
            {
                if (item.Key == nomer)
                {
                    item.Value.ChangeName(newname);
                }

            }
        }
        public static void NewTelephone(int nomer, string newtelephone)
        {
            foreach (var item in Info)
            {
                if (item.Key == nomer)
                {
                    item.Value.ChangeTelephone(newtelephone);
                }

            }
        }
        public static void NewBirthday(int nomer, DateTime newbirthday)
        {
            foreach (var item in Info)
            {
                if (item.Key == nomer)
                {
                    item.Value.ChangeBirthday(newbirthday);
                }

            }
        }
        public static void GetInfo()
        {
            foreach (var item in Info)
            {
                Console.WriteLine($"Имя: {item.Value.Name}");
                Console.WriteLine($"Вклад: {item.Value.Bill}");
                Console.WriteLine($"Дата рождения: {item.Value.Birthday}");
                Console.WriteLine($"Возраст: {item.Value.Age}");
                Console.WriteLine($"Номер телефона: {item.Value.Telephone}");
                Console.WriteLine();
            }
        }
        public static void Program()
        {
            Info.Add(001, new Bank_Person(1000, "Рифат", new DateTime(1999, 12, 20), "89839128391238"));
            Info.Add(002, new Bank_Person(2000, "Рузаль", new DateTime(1999, 01, 1), "89839128391238"));
            NewName(001, "Расиф");
            NewBirthday(001, new DateTime(2003, 04, 28));
            NewTelephone(001, "89858585855");
            GetInfo();
        }
    }
}
