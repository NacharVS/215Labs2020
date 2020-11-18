﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class Bank
    {
        private static double _bill = 0;
        private static double _persent = 0.0061;
        private DateTime _accounOpenDate;
        private static string _name;
        private static bool _registration = false;
        private static bool _take = false;
        private static bool _take2 = false;
        private static bool _age = false;
        private static double _donation;
        private static string _phone;
        private static double cashback = 0;
        private static double cashback_procent = 5;
        private static double cashback_partner_procent = 20;


        private static void Check_Donation(double donation)
        {
            if (donation < 10000 | donation > 200000 & _take2)
            {
                Console.WriteLine("Ошибка. Сумма взноса должна быть больше 10 000р и меньше 200 000р.");
                _take = false;
                _take2 = false;
            }
            else if (Bank._bill - donation < 0 & _take & _take2)
            {
                Console.WriteLine("Ошибка. Не достаточно средств для снятия со сочета на балансе счета.");
                _take = false;
                _take2 = false;
            }
            else if (_take2)
            {
                if (_take) { Bank._bill -= donation; }
                else { Bank._bill += donation; }
                Console.WriteLine($"Баланс счета составляет: {Bank._bill}");
                Console.WriteLine();
                _take = false;
                _take2 = false;
            }
        }

        private static void Check_Sign(string donation)
        {
            try
            {
                double a = double.Parse(donation);
                Bank._donation = a;
                Bank._take2 = true;
            }
            catch
            {
                Console.WriteLine("Ошибка. Введенные символы не допустимы.");
            }
        }
        private static void Check_Age()
        {
            ushort person_year;
            byte person_month;
            int person_day;
            Console.Write("Введите дату своего рождения (Пример: 01 01 2020): ");
            try
            {
                string _birthday = Console.ReadLine();
                string[] mass = _birthday.Split();
                person_year = ushort.Parse(mass[2]);
                person_month = byte.Parse(mass[1]);
                person_day = byte.Parse(mass[0]);
                if (DateTime.Now.Year - person_year >= 14 || DateTime.Now.Month - person_day <= DateTime.Now.Month || DateTime.Now.Day - person_day <= DateTime.Now.Day) { _registration = true; }
                else
                {
                    Console.WriteLine("Ошибка. Для регистрации вы должны быть старше 14 лет.");
                }

            }
            catch
            {
                Console.WriteLine("Ошибка. Не коректно введена дата рождения.");
                _age = false;
            }
        }
        private static void Person_name()
        {
            Console.Write("Введите свое ФИО : ");
            _name = Console.ReadLine();
            bool b = true;
            for (int j = 0; j < _name.Length; j++)
            {
                if (b) { Console.Write(_name[j].ToString().ToUpper()); b = false; }
                else { Console.Write(_name[j]); };
                string c = Convert.ToString(_name[j]);
                switch (c)
                {
                    case " ": b = true; break;
                }
            }
            _registration = true;
        }
        private static void Telephone_number()
        {
            Console.Write("Введите свой номер телефона:  ");
            _phone = Console.ReadLine();
            _registration = true;
        }
        private static void First_deposit()
        {
            Console.Write("Введите сумму первого взноса: ");
            Bank.Check_Sign(Console.ReadLine());

            if (_donation < 10000 | _donation > 200000 & _take2)
            {
                Console.WriteLine("Ошибка. Сумма первого взноса должна быть больше 10 000р и меньше 200 000р.");
                _take2 = false;
            }
            else if (_take2)
            {
                Bank._bill += _donation;
                Console.WriteLine();
                _registration = true;
                _take2 = false;
            }
        }
        private static void CreateAccount()
        {
            Person_name();
            Check_Age();
            Telephone_number();
            First_deposit();
            if (_registration)
            {
                Console.WriteLine("Благодарим за регистрацию в нашем банке.");
                Console.WriteLine($"Баланс счета составляет: {Bank._bill}");
            }
            else { Console.WriteLine("Ошибка. Регистрация не пройдена."); }
        }
        private static void Refill()
        {
            Console.Write("Введите сумму, на которую вы хотите пополнить баланс: ");
            Bank.Check_Sign(Console.ReadLine());
            Bank.Check_Donation(_donation);
        }
        private static void In_year()
        {
            Console.Write("Через сколько лет вы хотите узнать свой баланс: ");
            double a = double.Parse(Console.ReadLine());
            double b = 0;
            for (int i = 0; i < a; i++)
            {
                b = Bank._bill + Bank._bill * _persent * i;
            }
            Console.WriteLine($"Ваш баланс через {a} лет, будет равен {b}.");
            Console.WriteLine();
        }
        private static void Balance()
        {
            Console.WriteLine($"Баланс вашего счета равен: {Bank._bill}");
            Console.WriteLine();
        }
        private static void Cash_out()
        {
            Console.Write("Введите сумму для снятия с счета: ");
            _take = true;
            Bank.Check_Sign(Console.ReadLine());
            Bank.Check_Donation(_donation);
        }
        private static void popolnenie_cashback()
        {
            _bill += cashback;
            cashback = 0;
        }
        public static void Program()
        {
            while (true)
            {
                Console.WriteLine("Доступные действия над банковским счетам:");
                Console.WriteLine("Проверить баланс счета: ( 1 ) ");
                Console.WriteLine("Снять деньги со счета: ( 2 ) ");
                Console.WriteLine("Пополнить счет: ( 3 ) ");
                Console.WriteLine("Узнать баланс счета через определенный период: ( 4 ) ");
                if (_registration == false) { Console.WriteLine("Регистрация: ( 5 )"); }
                Console.Write("Введите действие над счетом: ");
                int action = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (_registration || action == 5)
                {
                    switch (action)
                    {
                        case 1: Balance(); break;
                        case 2: Cash_out(); break;
                        case 3: Refill(); break;
                        case 4: In_year(); break;
                        case 5: CreateAccount(); break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка. Для продолжения работы нужно пройти регистрацию.");
                    Console.WriteLine();
                }
            }
        }
    }

}
