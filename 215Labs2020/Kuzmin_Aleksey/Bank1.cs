using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class Person
    {
        private double _bill;
        private string _name, _birthday, _telephone;          
        private static string name, number, birthday;        
        delegate double Opperation(double opperation);
        private Person(string name, string telephone, string birthday)
        {
            _name = name;
            _telephone = telephone;
            _birthday = birthday;
        }
        private static void Registration()
        {
            Console.WriteLine("Регистрация:");
            Console.Write("Введите сове ФИО: ");
            name = Console.ReadLine();
            Console.Write("Введите свой номер: ");
            number = Console.ReadLine();
            Console.Write("Введите свою дату рожедения: ");
            birthday = Console.ReadLine();
        }
        private void GetInfo()
        {
            Console.WriteLine($"ФИО: {_name}");
            Console.WriteLine($"Дата рождания: {_birthday}");
            Console.WriteLine($"Телефон: {_telephone}");
        }
        private void Balance()
        {
            Console.WriteLine($"Баланс счета: {_bill}");
        }
        private double Refill(double donation)
        {
            if (donation > 200000 || donation < 10000)
            {
                Console.WriteLine("Ошибка. Взнос должен быть больше 10 000 и меньше 200 000.");
                return _bill;
            }
            else { return _bill += donation; }            
        }
        private double TakeAway(double donation)
        {
            if (donation > 200000 || donation < 10000)
            {
                Console.WriteLine("Ошибка. Взнос должен быть больше 10 000 и меньше 200 000.");
                return 0;
            }
            else if (_bill < donation)
            {
                Console.WriteLine("Ошибка. Не достаточно средств на балансе.");
                return _bill;
            }
            else { return _bill -= donation; }            
        }
        private double CashBack(double donation)
        {
            if (_bill < donation)
            {
                Console.WriteLine("Ошибка. Не достаточно средств на балансе.");
                return _bill;
            }
            else 
            {
                _bill -= donation;
                return _bill += donation * 0.01;
            }            
        }    
        public static void Program()
        {
            Registration();        
            Person man = new Person(name, number, birthday);
            while (true)
            {
                Opperation operation;
                Console.WriteLine("\"1\" — Проверить баланс.");
                Console.WriteLine("\"2\" — Пополнить.");
                Console.WriteLine("\"3\" — Снять деньги.");
                Console.WriteLine("\"4\" — Вернуть деньги с покупки.");
                Console.WriteLine("\"5\" — Информация о аккаунте.");
                Console.Write("Выберите действие: ");
                string action = Console.ReadLine();
                double donation = 0;
                switch(action)
                {
                    case "1": man.Balance(); break;
                    case "2":
                        operation = man.Refill;
                        Console.Write("Введите сумму пополнения: ");
                        donation = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Баланс: {operation(donation)}");
                        break;
                    case "3":
                        operation = man.TakeAway;
                        Console.Write("Введите сумму снятия: ");
                        donation = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Баланс: {operation(donation)}");
                        break;
                    case "4":
                        operation = man.CashBack;
                        Console.Write("Введите сумму покупки: ");
                        donation = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Баланс: {operation(donation)}");
                        break;
                    case "5": man.GetInfo(); break;
                }
            }
        }
    }
}
