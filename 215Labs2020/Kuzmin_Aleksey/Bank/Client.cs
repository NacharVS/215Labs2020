using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _215Labs2020.Kuzmin_Aleksey.Bank
{
    class Client : Person
    {
        public string Name => _name;
        public double Bill => _bill;
        public DateTime Birthday => _birthday;
        public string Telephone => _telephone;
        public int Id => _id;
        public int Age => _age;
        static List<Client> PersonInfo = new List<Client>();        
        public Client(double bill, string name, DateTime birthday, string telephone, int age) 
        {
            _bill = bill;
            _name = name;
            _birthday = birthday;
            _telephone = telephone;
            _users += 1;
            _id = _users;
            _age = age;
        }
        delegate double Message(double a);
        event Message Notify;
        private static void Registration()
        {
            Console.WriteLine("Регистрация:");
            Console.Write("Введите свое ФИО: ");
            string name = Console.ReadLine();
            Console.Write("Введите свой номер: ");
            string number = Console.ReadLine();
            Console.Write("Введите свою дату рожедения: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            int age = 0;
            if (DateTime.Now.Month <= birthday.Month && DateTime.Now.Day < birthday.Day)
            { age -= 1; }
            age = age + DateTime.Now.Year - birthday.Year;
            Console.Write("Введите сумму первого взноса: ");
            int bill = int.Parse(Console.ReadLine());
            if (age < 16 || bill < 10000 || bill > 200000)
            { Console.WriteLine("Ошибка"); }
            else { PersonInfo.Add(new Client(bill, name, birthday, number, age)); }            
        }
        private void SetName(string newName)
        {
            _name = newName;
        }
        private void SetTelephone(string newTelephone)
        {
            _telephone = newTelephone;
        }
        private void SetBirthday(DateTime newBirthday)
        {
            _birthday = newBirthday;
            _age = 0;
            if (DateTime.Now.Month <= _birthday.Month && DateTime.Now.Day < _birthday.Day)
            { _age -= 1; }
            _age = _age + DateTime.Now.Year - _birthday.Year;
        }
        private static void Change(int id)
        {
            Console.WriteLine("Какое поле вы хатите изменить?");
            Console.WriteLine("ФИО           { 1 }.");
            Console.WriteLine("Номер телефон { 2 }.");
            Console.WriteLine("Дату рождения { 3 }.");
            string nomination = Console.ReadLine();
            switch (nomination)
            {
                case "1":
                    Console.Write("Введите новое имя: ");
                    string change = Console.ReadLine();
                    foreach (var item in PersonInfo)
                    {
                        if (item.Id==id)
                        {
                            item.SetName(change);
                        }
                    }
                    break;
                case "2":
                    Console.Write("Введите новый телефон: ");
                    change = Console.ReadLine();
                    foreach (var item in PersonInfo)
                    {
                        if (item.Id == id)
                        {
                            item.SetTelephone(change);
                        }
                    }
                    break;
                case "3":
                    Console.Write("Введите новую дату рождения: ");
                    change = Console.ReadLine();
                    foreach (var item in PersonInfo)
                    {
                        if (item.Id == id)
                        {
                            item.SetBirthday(DateTime.Parse(change));
                        }
                    }
                    break;
            }            
        } 
        public static void Program()
        {    
            while (true)
            {           
                Console.WriteLine("\"1\" — Проверить баланс.");
                Console.WriteLine("\"2\" — Пополнить.");
                Console.WriteLine("\"3\" — Снять деньги.");
                Console.WriteLine("\"4\" — Вернуть деньги с покупки.");
                Console.WriteLine("\"5\" — Информация о аккаунте.");
                Console.Write("Выберите действие: ");
                string action = Console.ReadLine();
                switch (action)
                {
                    
                    case "2":
                        Console.Write("Введите сумму пополнения: ");
                                           
                        break;
                    case "3":
                        Console.Write("Введите сумму снятия: ");
                                             
                        break;
                    case "4":                        
                        Console.Write("Введите сумму покупки: ");
                                              
                        break;
                    case "5": Registration(); break;
                    case "6":
                        foreach (var item in PersonInfo)
                        {
                            Console.WriteLine($"{item.Name} {item._telephone} {item.Bill} {item._birthday} {item.Age} {item.Id}");
                        }
                        break;
                    case "7":
                        Console.Write("Введите ip: ");
                        Change(int.Parse(Console.ReadLine()));
                        break;
                }
            }
        }
    }
}
