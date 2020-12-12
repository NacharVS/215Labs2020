using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _215Labs2020.Kuzmin_Aleksey.Bank
{
    class Client : Person
    {
        private string Name => _name;
        private double Bill => _bill;
        private DateTime Birthday => _birthday;
        private string Telephone => _telephone;
        private int Age => _age;
        private Client(double bill, string name, DateTime birthday, string telephone) 
        {
            _bill = bill;
            _name = name;
            _birthday = birthday;
            _telephone = telephone;
            _users += 1;          
            _age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month <= birthday.Month && DateTime.Now.Day < birthday.Day)
            {
                _age -= 1;
            }
        }
        private static Dictionary<int, Client> PersonInfo = new Dictionary<int, Client>();        
        private static void ChangeName(int id, string name)
        {           
            foreach (var item in PersonInfo)
            {
                if (item.Key == id)
                {
                    item.Value.SetName(name);
                }
            }
        }          
        private static void ChangePhone(int id, string phone)
        {
            foreach (var item in PersonInfo)
            {
                if (item.Key == id)
                {
                    item.Value.SetPhone(phone);
                }
            }
        }        
        private static void ChangeBirthday(int id, DateTime birthday)
        {
            foreach (var item in PersonInfo)
            {
                if (item.Key == id)
                {
                    item.Value.SetBirthday(birthday);
                }
            }
        }     
        private static void GetInfo()
        {
            foreach (var item in PersonInfo)
            {
                Console.WriteLine($"Счет: {item.Value.Bill}, ФИО: {item.Value.Name}, Дата рождения: {item.Value.Birthday}, Возраст: {item.Value.Age}, Телефон: {item.Value.Telephone}");
            }
            
        }
        public static void Program()
        {               
            //Первый взнос, Имя, Дата рождения, телефон.
            PersonInfo.Add(1111, new Client(100000, "Егор", new DateTime(2000, 2, 21), "8989829198"));
            PersonInfo.Add(1112, new Client(500000, "Василий", new DateTime(2002, 12, 31), "213124323"));
            GetInfo();
            PersonInfo[1111].Refill = 100000;
            ChangeName(1111, "Иван");
            GetInfo();
            ChangeBirthday(1111, new DateTime(2000, 12, 21));
            GetInfo();
        }
    }
}
