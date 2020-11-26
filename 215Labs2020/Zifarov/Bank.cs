using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Hasanov
{
    public delegate void AccountHandler(string mesegge);

    class Bank
    {
        private string _name;
        private string _surname;
        private int _age;
        private static int _minideposit = 10000;
        private static int _maxdeposit = 200000;
        private static double _bankaccount = 0;
        private int _day;
        private int _year;
        private int _month;
        private double _summ;
        private DateTime _openDate;
        private static double _cashbackpersent = 0.03;
        private static double _cashbackpersentreferal = 0.05;
        private static double _depositpersent = 1.025;
        public event AccountHandler Notify;


        private void Put1(double sum)
        {

            int r;
            while (true)
            {
                r = 0;
                if (sum >= _minideposit & sum <= _maxdeposit)
                {
                    BankAccount += sum;
                    Notify?.Invoke($"На счет поступило: {sum}");
                    Notify?.Invoke($"На счетe : {BankAccount}");
                    r += 1;
                }
                else Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                if (r != 0) break;
            }

        }

        private void Take1(double sum)
        {
            int r;
            while (true)
            {
                r = 0;
                if (BankAccount >= sum & sum >= _minideposit & sum <= _maxdeposit)
                {

                    BankAccount -= sum;
                    Notify?.Invoke($"Со счета выведено: {sum}");
                    Notify?.Invoke($"На счетe : {BankAccount}");
                    r += 1;
                }
                if (sum < _minideposit || sum > _maxdeposit) Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                if (r != 0) break;
            }
        }
        private void CashBack1(double sum)
        {
            Console.WriteLine("У вас есть рефиральный код?");
            string referal = Console.ReadLine();
            if (referal == "Да")
            {
                Console.WriteLine("Введите его");
                Console.ReadLine();
                BankAccount += (sum * _cashbackpersentreferal);
                Notify?.Invoke($"Кэшбэк : {sum}");
                Notify?.Invoke($"На счетe : {BankAccount}");
            }
            else
            {
                BankAccount += (sum * _cashbackpersent);
                Notify?.Invoke($"Кэшбэк : {sum}");
            }
        }
        public double Summ
        {
            get
            {
                return _summ;

            }
            set
            {
                _summ = value;
            }

        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }

        }


        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                if (Age >= 14 & _month == DateTime.Now.Month & _day == DateTime.Now.Day)
                {
                    Console.WriteLine("Поздравляем с вашем днем рождением");
                    Bank bank = new Bank();
                    bank.OperationInBank();
                }
                if (Age <= 14 & _month >= DateTime.Now.Month)
                {
                    Console.WriteLine("К сожалению регистрация в нашем банке возможна с 14 лет, мы вынуждены прервать регистрацию! Всего доброго:)");
                    return;
                }
                else
                {
                    Bank bank = new Bank();
                    bank.OperationInBank();
                }
            }

        }
        public double BankAccount
        {
            get
            {
                return _bankaccount;

            }
            private set
            {
                _bankaccount = value;

            }
        }
        public static void LaunchBank()
        {
            Bank bank = new Bank();
            bank.RegistrationBank();
        }
        private void RegistrationBank()
        {
            Console.WriteLine("Hello, plese registr in bank");
            Console.WriteLine("Enter your Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Surname");
            Surname = Console.ReadLine();
            Console.WriteLine("Введите свою дату рождения (Например 15.07.2003)");
            string birthday = Console.ReadLine();
            string[] array = birthday.Split(new char[] { '.' });
            _day = int.Parse(array[0]);
            _month = int.Parse(array[1]);
            _year = int.Parse(array[2]);
            _openDate = DateTime.Now;
            Age = DateTime.Now.Year - _year;
        }
        private void Depositsonthebalance()
        {
            int second = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            int secondOpen = _openDate.Hour * 3600 + _openDate.Minute * 60 + _openDate.Second;
            int deltaTime = second - secondOpen;
            int period = 10;
            period = deltaTime / period;
            for (int i = 0; i < period; i++)
            {
                BankAccount = Math.Round(BankAccount, 2);
            }
            Console.WriteLine(BankAccount);

        }
        private void CashBack()
        {
            Bank acc = new Bank();
            Console.WriteLine("Введите сумму на которую совершали покупку");
            Summ = double.Parse(Console.ReadLine());
            acc.Notify += DisplayMessage;
            acc.CashBack1(Summ);


        }
        private void Deposit()
        {

            int year;
            int b;
            int c = DateTime.Now.Year;
            int r;
            Console.WriteLine($"На вашем счету {BankAccount}");
            while (true)
            {
                r = 0;
                Console.WriteLine("Введите сумму которую хотите внести ");
                b = int.Parse(Console.ReadLine());
                if (b < _minideposit || b > _maxdeposit)
                {
                    Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                    r += 1;


                }

                if (BankAccount < b && BankAccount != 0)
                {
                    Console.WriteLine("На вашем счету недостаточно средств");

                }
                if (r != 1) break;
            }
            Console.WriteLine("Введите на сколько лет хотите внести депозит");
            year = int.Parse(Console.ReadLine());
            if (BankAccount >= b & b >= _minideposit & b <= _maxdeposit) Console.WriteLine($"На вашем счету {BankAccount -= b}");
            _depositpersent = Math.Pow(_depositpersent, year);
            year += c;
            Console.WriteLine($"Ваш депозит в {year} году будет составлять {b * _depositpersent} ");

        }
        private void Take()
        {



            Bank acc = new Bank();
            Console.WriteLine("Введите сумму которую хотите снять ");
            Summ = int.Parse(Console.ReadLine());
            acc.Notify += DisplayMessage;
            acc.Take1(Summ);



        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        private void Put()
        {
            Bank acc = new Bank();
            Console.WriteLine("Введите сумму которую хотите внести ");
            Summ = int.Parse(Console.ReadLine());
            acc.Notify += DisplayMessage;
            acc.Put1(Summ);
        }

        public void OperationInBank()
        {
            while (true)
            {

                Console.WriteLine("Ваши возможные операции: внести денежные средства, снять денежные средства, внести денежные средста на депозит (2.5%)");
                string operations = Console.ReadLine();
                switch (operations)
                {
                    case "Внести денежные средства":
                        Put();
                        break;
                    case "Снять денежные средства":
                        Take();
                        break;
                    case "Внести денежные средста на депозит":
                        Deposit();
                        break;
                    case "Совершить покупку":
                        CashBack();
                        break;
                    case "Накрутить деньги":
                        Depositsonthebalance();
                        break;

                }
                Console.WriteLine("Вы хотите продолжить?(Да/Нет)");
                string flag = Console.ReadLine();
                if (flag != "Да") break;

            }
            Console.WriteLine("Спасибо за использование ХАСУСГОССТРАХБАНКа! Всего доброго");
        }
    }
}
























