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
        public Client(double bill, string name, DateTime birthday, string telephone, int ip) 
        {
            _bill = bill;
            _name = name;
            _birthday = birthday;
            _telephone = telephone;
            _users += 1;
            _id = ip;            
            _age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month <= birthday.Month && DateTime.Now.Day < birthday.Day)
            {
                _age -= 1;
            }
        }
        delegate double Message(double a);
        event Message Notify;
        static List<Client> PersonInfo = new List<Client>();
        private double Refill
        {
            get { return _bill; }
            set
            {
                if (value>=10000 && value<=200000)
                {
                    _bill += value;
                }
            }
        }
        private double Remove
        {
            get { return _bill; }
            set
            {
                if(_bill>=value)
                {
                    _bill -= value;
                }
            }
        }
        private void SetName(string newName)
        {
            _name = newName;
        }
        private void SetPhone(string newTelephone)
        {
            _telephone = newTelephone;
        }
        private void SetBirthday(DateTime newBirthday)
        {
            _birthday = newBirthday;
            _age = 0;
            if (DateTime.Now.Month <= _birthday.Month && DateTime.Now.Day < _birthday.Day)
            {
                _age -= 1;
            }
            _age = _age + DateTime.Now.Year - _birthday.Year;
        }
        private static void ChangeNme(int id, string name)
        {           
            foreach (var item in PersonInfo)
            {
                if (item.Id == id)
                {
                    item.SetName(name);
                }
            }
        }          
        private static void ChangePhone(int id, string phone)
        {
            foreach (var item in PersonInfo)
            {
                if (item.Id == id)
                {
                    item.SetPhone(phone);
                }
            }
        }        
        private static void ChangeBirthday(int id, DateTime birthday)
        {
            foreach (var item in PersonInfo)
            {
                if (item.Id == id)
                {
                    item.SetBirthday(birthday);
                }
            }
        }     
        private static void GetInfo()
        {
            foreach (var item in PersonInfo)
            {
                Console.WriteLine($"Счет: {item.Bill}, ФИО: {item.Name}, Дата рождения: {item.Birthday}, Возраст: {item.Age}, Телефон: {item.Telephone}, id: {item.Id}");
            }
            
        }
        public static void Program()
        {               
            //Первый взнос, Имя, Дата рождения, телефон, ip.
            PersonInfo.Add(new Client(100000, "Клиент1", new DateTime(2000, 2, 21), "8989829198", 0001));
            GetInfo();
        }
    }
}
