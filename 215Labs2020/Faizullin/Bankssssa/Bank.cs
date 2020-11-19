﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Faizullin

{
    class Bank
    {
        private DateTime _birth;
        private static string _SNF;
        private static string _PhoneNumber;
        private static double _contribution = 0;
        private static double _percent = 0.3;
        private static int _balans = 0;
        private static DateTime _accountOpenDate;

        public delegate void AccountHadler(string message);
        public event AccountHadler Notify;
        public void Bankk(int sum)
        {
            _balans = sum;
        }
        
        public int BALANSE { get; private set; }
        private static void  DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void Put(int sum)
        {
            _balans = sum;
            Notify?.Invoke($"поступило: {sum} ");
        }
        public void Take(int sum)
        {
            
            if (_balans >= sum)
            {
                _balans -= sum;
                Notify?.Invoke($"снято: {sum} ");
            }
            else
            {
                Notify?.Invoke($"недостаточно средств: {sum} ");
            }
        }
        public void RegistDate()
        {
            Bank bank = new Bank();
            _accountOpenDate = DateTime.Now;
            Console.WriteLine($"Дaта регистрации {_accountOpenDate}");
        }
        public string phoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                _PhoneNumber = phoneNumber;
            }
        }
        public DateTime Birth
        {
            get
            {
                return _birth;
            }

            set
            {
                _birth = value;

                if (_birth.Year == DateTime.Now.Year || _birth.Year > DateTime.Now.Year - 14)
                {
                    throw new Exception("Извените , но вам меньше 14лет");

                }
                else
                {
                    Console.WriteLine(" Можете внести депозит ");
                }
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birth.Year;
            }

        }

        public void Registration()
        {
            Console.WriteLine("Hello, welcome to our Bank.");
            Console.WriteLine("***************************");
            Console.WriteLine("Введите номер телефона");
            Console.WriteLine("**********************");
            _PhoneNumber = Console.ReadLine();

           Bank bank = new Bank();
            try
            {
                Console.WriteLine("Enter personal data");
                Console.WriteLine("***************");
                Bank._SNF = Console.ReadLine();
                Console.WriteLine("Enter date of birth");
                Console.WriteLine("***************");

                Console.Write("Введите дату рождения (17/06/1996):");
                string inputDate = Console.ReadLine();
                bank.Birth = Convert.ToDateTime(inputDate);

                Console.WriteLine("Ваш возвраст: {0}", bank.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }



        }
        private void Operation()
        {
            Bank bank = new Bank();
            Console.WriteLine("Enter the Deposit amount");
            Console.WriteLine("************************");
            double MONEY = int.Parse(Console.ReadLine());
            if (MONEY >= 10000 || MONEY <= 200000) Bank._contribution = MONEY;

        }
        //private void Operation2()
        //{
            //Bank bank = new Bank();
            //Console.WriteLine("Ведите сумму для снятия ");
            //_balans = Console.ReadLine();
        //}
        private void PROGNOZ()
        {
            Bank bank = new Bank();
            Console.WriteLine("Investment for how many years?");
            Console.WriteLine("************************");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                Bank._contribution += Bank._percent * Bank._contribution;

            }
        }
        private void END()
        {
            Bank bank = new Bank();
            Console.WriteLine($"After the period yiou specified will be {Bank._contribution} rubles ");
            Console.WriteLine($" {Bank._SNF} Thank you ,goodbye");
        }

        public static void Proverka()
        {
            Bank bank = new Bank();
            bank.Notify += DisplayMessage;
            bank.Put(20);
            bank.Take(70);
            bank.RegistDate();
            bank.Registration();
            bank.Operation();
            bank.PROGNOZ();
            bank.END();
        }
    }
}
