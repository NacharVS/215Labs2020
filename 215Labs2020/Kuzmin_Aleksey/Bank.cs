using _215Labs2020.Kuzmin_Aleksey;
using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class Bank
    {
        private static double _bill = 0;
        private static double _persent = 0.006;
        private string _name;
        private static bool _registration = false;
        private static bool _take = false;
        private static bool _take2 = false;
        private static bool _age = false;
        private static double _donation;
        private string _birtday;        
        private string _phone;
        private static string _line = "*************************************************************";       
        
        private static void Check_Donation(double donation)
        {
            if (donation < 10000 | donation > 200000 & _take2)
            {
                Console.WriteLine(Bank._line);
                Console.WriteLine("Ошибка. Сумма взноса должна быть больше 10 000р и меньше 200 000р.");
                Console.WriteLine(Bank._line);
                _take = false;
                _take2 = false;
            }
            else if (Bank._bill - donation < 0 & _take & _take2)
            {
                Console.WriteLine(Bank._line);
                Console.WriteLine("Ошибка. Не достаточно средств для снятия со сочета на балансе счета.");
                Console.WriteLine(Bank._line);
                _take = false;
                _take2 = false;
            }
            else if(_take2)
            {
                if (_take) { Bank._bill -= donation; }
                else { Bank._bill += donation; }
                Console.WriteLine(Bank._line);
                Console.WriteLine($"Баланс счета составляет: {Bank._bill}");
                Console.WriteLine(Bank._line);
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
                Console.WriteLine(Bank._line);
                Console.WriteLine("Ошибка. Введенные символы не допустимы.");
                Console.WriteLine(Bank._line);
            }
        }
        private static void Check_Age()
        {
            int person_year;
            try
            {
                string _birthday = Console.ReadLine();
                string[] mass = _birthday.Split();
                person_year = int.Parse(mass[2]);                
                if (DateTime.Now.Year - person_year > 14) { _age = true; }
                else 
                { 
                    Console.WriteLine("Ошибка. Для регистрации вы должны быть старше 14 лет.");
                    
                    Console.WriteLine(_line);
                }
                
            }
            catch
            {
                Console.WriteLine("Ошибка. Не коректно введена дата рождения.");               
                Console.WriteLine(_line);
                _age = false;
            }
        }
        private static void CreateAccount()
        {
            Bank person = new Bank();
            Console.WriteLine(Bank._line);
            Console.Write("Введите свое ФИО (Пример: Сидоров Сидор Сидорович): ");
            person._name = Console.ReadLine();
            Console.Write("Введите дату своего рождения (Пример: 01 01 2020): ");
            Check_Age();
            if (_age)
            {
                Console.Write("Введите свой номер телефона:  ");
                person._phone = Console.ReadLine();
                Console.Write("Введите сумму первого взноса: ");
                Bank.Check_Sign(Console.ReadLine());

                if (_donation < 10000 | _donation > 200000 & _take2)
                {
                    Console.WriteLine(Bank._line);
                    Console.WriteLine("Ошибка. Сумма первого взноса должна быть больше 10 000р и меньше 200 000р.");
                    Console.WriteLine(Bank._line);
                    _take2 = false;
                }
                else if (_take2)
                {
                    Bank._bill += _donation;
                    Console.WriteLine(Bank._line);
                    Console.WriteLine("Благодарим за регистрацию в нашем банке.");
                    Console.WriteLine($"Баланс счета составляет: {Bank._bill}");
                    Console.WriteLine(Bank._line);
                    Console.WriteLine();
                    _registration = true;
                    _take2 = false;
                }
            }
            else { Console.WriteLine("Ошибка. Регистрация не пройдена."); }
            }
            

        }
        private static void Refill()
        {
            Console.WriteLine(Bank._line);
            Console.Write("Введите сумму, на которую вы хотите пополнить баланс: ");
            Bank.Check_Sign(Console.ReadLine());
            Bank.Check_Donation(_donation);
        }
        private static void In_year()
        {
            Console.WriteLine(Bank._line);
            Console.Write("Через сколько лет вы хотите узнать свой баланс: ");
            double a = double.Parse(Console.ReadLine());
            double b = 0;
            for (int i = 0; i < a; i++)
            {
                b = Bank._bill + Bank._bill * _persent * i;
            }
            Console.WriteLine($"Ваш баланс через {a} лет, будет равен {b}.");
            Console.WriteLine(Bank._line);
            Console.WriteLine();
        }
        private static void Balance()
        {
            Console.WriteLine(Bank._line);
            Console.WriteLine($"Баланс вашего счета равен: {Bank._bill}");
            Console.WriteLine(Bank._line);
            Console.WriteLine();
        }
        private static void Cash_out()
        {
            Console.Write("Введите сумму для снятия с счета: ");
            _take = true;
            Bank.Check_Sign(Console.ReadLine());
            Bank.Check_Donation(_donation);
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
                    Console.WriteLine(Bank._line);
                    Console.WriteLine("Ошибка. Для продолжения работы нужно пройти регистрацию.");
                    Console.WriteLine(Bank._line);
                    Console.WriteLine();
                }
            }
        }
    }

}