using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.new_bank
{
    class Bank
    {
        public delegate void BankAccount(string phoneNumber, string Message);

        public event BankAccount Notify;

        private string _FIO;
        private string _phoneNumber;
        private int _age;
        private double _id;
        private static double _interestRate = 0.05;
        private double _account;

        private double _cashBack;

        private static double _cahsBackRate = 0.01;
        private static int _count = 0;
        private static int _Max = 100000;
        private static int _Min = 10000;
        private static int _MinAge = 14;

        private DateTime _accountOpen;
        private DateTime _lastProfit;
        private DateTime _lastCASHBACK;

        public string FIO
        {
            get { return _FIO; }
            private set
            {
                _FIO = FIO;
            }
        }
        public int Age
        {
            get { return _age; }
            private set
            {
                if (value >= _MinAge)
                    _age = value;
                else
                    Console.WriteLine("Ваш возраст не соответствует требуемому");
            }
        }
        public double Id
        {
            get { return _id; }
        }
        public double Account
        {
            get { return _account; }
            private set
            {
                _account = value;
                Notify?.Invoke(_phoneNumber, $"Acount Change {_account}");
            }
        }
        public static int Count
        {
            get { return _count; }
        }
        private void GenId()
        {
            _id = 234;
        }
        private void GetAge()
        {
            Console.WriteLine("Введите дату рождения в формате (00.00.00)");
            string[] date = new string[3];
            date = Console.ReadLine().Split(".");
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = DateTime.Now.Year - int.Parse(date[2]) - 1;
            {
                if (DateTime.Now.Month >= month & DateTime.Now.Day >= day) Age = year + 1;
                else Age = year;
            }
        }


        public Bank()
        {
            Console.WriteLine("Напишите ваше фио");
            _FIO = Console.ReadLine();
            Console.WriteLine("Введите телефонный номер");
            _phoneNumber = Console.ReadLine();
            GetAge();//Отдельный метод для запроса дня рождения и расчета возраста (мне так удобнее)
            GenId();
            _accountOpen = DateTime.Now;
            _lastProfit = _accountOpen;
        }

        public Bank(string name,  string phone)
        {
            FIO = _FIO;
            
            _phoneNumber = phone;
            GetAge();
            GenId();
            _accountOpen = DateTime.Now;
            _lastProfit = _accountOpen;
            _lastCASHBACK = _accountOpen;
        }
        public void Withdraw(int value)
        {
            if (value > _account)
            {
                Notify?.Invoke(_phoneNumber, $"You have only: {Account}");
                return;
            }
            if (value <= _Max)
            {
                Account = Account - value;
                _cashBack += value * _cahsBackRate;
            }
            else Notify?.Invoke(_phoneNumber, "You can't take more than 100 000");
        }
        public void Deposit(int value)
        {
            if (value >= _Min)
            {
                Account = Account + value;
            }
            else Notify?.Invoke(_phoneNumber, "You can't add less than 10 000");
        }
        public void ShowProfit(int yaer) 
        {
            double buff = _account;
            for (int i = 0; i < yaer; i++)
            {
                buff += buff * _interestRate;
            }
            Notify?.Invoke(_phoneNumber, $"Your balance will be {buff} in {yaer} yearz");
        }
        public void CalculateProfit(DateTime timeNow)
        {
            for (int i = 0; i < (timeNow.Day - _lastProfit.Day); i++)
            {
                Account += _account * _interestRate;
            }
            _lastProfit = timeNow;
        }
        public void GetCahsBack(DateTime timeNow)
        {
            if ((timeNow.Day - _lastCASHBACK.Day) != 0)
            {
                for (int i = 0; i < (timeNow.Day - _lastCASHBACK.Day); i++)
                {
                    Notify?.Invoke(_phoneNumber, $"Your get cahback {_cashBack}");
                    Account += _cashBack;
                }
                _lastCASHBACK = timeNow;
                _cashBack = 0;
            }
        }
        public void ChangeRate(double value)
        {
            _interestRate = value;
            Notify?.Invoke(_phoneNumber, $"New insert rate -- {_interestRate}");
        }
    }
    class RunBank
    {
        public static void _Bank()
        {
            Bank[] acc = new Bank[1];
            for (int i = 0; i < 1; i++)
            {
                acc[i] = new Bank();
                acc[i].Notify += Message;
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].FIO}");
              
                Console.WriteLine($"ID--{acc[i].Id}");
                Console.WriteLine($"Age--{acc[i].Age}");
                Console.WriteLine();
            } // Это выврд для проверки правильно ли создаються аккаунты и выбора с каким аккаунтом работать
            int acc_number = 0;
            while (true)
            {
                Console.WriteLine("введите число 0");
                acc_number = int.Parse(Console.ReadLine()) - 1;
                if (acc_number <= Bank.Count - 1) break;
                else Console.WriteLine("Wrong number");
            }
            while (true)
            {
                Console.WriteLine("Что вы хотите: 1 - снять деньги || 2 - внести деньги || 3 - проверить счет || 4 - рассчитать депозит || 5 - изменить ставку");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("How much:");
                        acc[acc_number].Withdraw(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("How much:");
                        acc[acc_number].Deposit(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine(acc[acc_number].Account);
                        break;
                    case 4:
                        Console.WriteLine("How many years to calculate");
                        acc[acc_number].ShowProfit(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("How much:");
                        acc[acc_number].ChangeRate(double.Parse(Console.ReadLine()));
                        break;
                }
                Console.WriteLine("Введите любое число чтобы продолжить");
                if (Console.ReadLine() == "n")
                    break;
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"number {i + 1}");
                Console.WriteLine($"Name--{acc[i].FIO}");
                
                Console.WriteLine($"ID--{acc[i].Id}");
                Console.WriteLine($"Money--{acc[i].Account}");
                Console.WriteLine($"Age--{acc[i].Age}");
                Console.WriteLine();
            }// Это вывод для проверки правильно ли программа работала с данными
        }

        public static void _Bank2() //Первый перегружен
        {
            Bank acc = new Bank("FIO", "88005553535");
            acc.Notify += Message;
            acc.Deposit(100000);
            acc.Deposit(100000);
            acc.Deposit(100000);
            acc.Deposit(100000);
            acc.Deposit(100000);
            acc.Deposit(100000);
            acc.Deposit(100000);
            acc.Deposit(100000);
            acc.Deposit(100000);
            acc.Deposit(100000);
            DateTime Now = DateTime.Now;
            for (int i = 0; i < 10; i++)
            {
                acc.CalculateProfit(Now += TimeSpan.FromDays(1));
            }
            for (int i = 0; i < 2; i++)
            {
                acc.Withdraw(10000);
                acc.Withdraw(15000);
                acc.GetCahsBack(Now += TimeSpan.FromDays(1));
            }
        }
        private static void Message(string PhoneNumber, string message)
        {
            Console.WriteLine($"Было отправлено сообщение на номер: {PhoneNumber}");
            Console.WriteLine($"Сообщение: {message}");
            Console.WriteLine();
        }
    }
}
