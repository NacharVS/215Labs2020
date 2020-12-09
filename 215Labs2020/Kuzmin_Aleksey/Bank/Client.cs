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
        public string Birthday => _birthday;
        public string Telephone => _telephone;
        public int Id => _id;
        static List<Client> PersonInfo = new List<Client>();
        private void SetName(string newName)
        {
            _name = newName;
        }
        public Client(double bill, string name, string birthday, string telephone)
        {
            _bill = bill;
            _name = name;
            _birthday = birthday;
            _telephone = telephone;
            _users += 1;
            _id = _users;
        }
        delegate double Message(double a);
        event Message Notify;
        private Client(string name, string telephone, string birthday)
        {
            _name = name;
            _telephone = telephone;
            _birthday = birthday;
        }
        private static void Registration()
        {            
            Console.WriteLine("Регистрация:");
            Console.Write("Введите свое ФИО: ");
            string name = Console.ReadLine();           
            Console.Write("Введите свой номер: ");
            string number = Console.ReadLine();            
            Console.Write("Введите свою дату рожедения: ");
            string birthday = Console.ReadLine();
            Console.Write("Введите сумму первого взноса: ");
            int bill = int.Parse(Console.ReadLine());            
            PersonInfo.Add(new Client(bill, name, birthday, number));
        }     
        private static void Change(string change)
        {            
            foreach (var item in PersonInfo)
            {
                if (item.Name==change)
                {
                    item.SetName(change);
                }
            }
        }
        private void Balance()
        {
            Console.WriteLine($"Баланс счета: {_bill}");
        }
        private double Refill
        {
            get { return _bill; }
            set
            {
                if (value > 200000 || value < 10000)
                {
                    Console.WriteLine("Ошибка. Взнос должен быть больше 10 000 и меньше 200 000.");                           
                }
                else 
                {
                    _bill += value;
                    Console.WriteLine($"Баланс: {Notify?.Invoke(_bill)}"); 
                }
            }
        }
        private double TakeAway
        {
            get { return _bill; }
            set
            {
                if (value > 200000 || value < 10000)
                {
                    Console.WriteLine("Ошибка. Взнос должен быть больше 10 000 и меньше 200 000.");
                    
                }
                else if (_bill < value)
                {
                    Console.WriteLine("Ошибка. Не достаточно средств на балансе.");
                   
                }
                else 
                { 
                    _bill -= value;
                    Console.WriteLine($"Баланс: {Notify?.Invoke(_bill)}");
                }
            }
        }
        private double CashBack
        {
            get { return _bill; }
            set
            {
                if (_bill < value)
                {
                    Console.WriteLine("Ошибка. Не достаточно средств на балансе.");
                    
                }
                else
                {
                    _bill -= value;
                    _bill += value * 0.01;
                    Console.WriteLine($"Баланс: {Notify?.Invoke(_bill)}");
                }
            }
        }
        public static void Program()
        {    

            Client man = new Client(0, "", "", "");
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
                    case "1": man.Balance(); break;
                    case "2":
                        Console.Write("Введите сумму пополнения: ");
                        man.Refill=double.Parse(Console.ReadLine());                       
                        break;
                    case "3":
                        Console.Write("Введите сумму снятия: ");
                        man.TakeAway = double.Parse(Console.ReadLine());                       
                        break;
                    case "4":                        
                        Console.Write("Введите сумму покупки: ");
                        man.CashBack = double.Parse(Console.ReadLine());                        
                        break;
                    case "5": Registration(); break;
                    case "6":
                        foreach (var item in PersonInfo)
                        {
                            Console.WriteLine($"{item.Name} {item.Bill} {item.Id}");
                        }
                        break;
                }
            }
        }
    }
}
