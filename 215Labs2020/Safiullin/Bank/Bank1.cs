using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Safiullin
{
    class Bank1
    {

        private static string _name;
        private static string _surname;
        private static int _id;
        private static double cashback = 0;
        private static double cashback_percent = 0.05;
        private static double cashback_partner_percent = 0.2;
        private static int year = 0;
        private static int day = 0;
        private static int month = 0;
        private static double _donation;
        private static string _phone;
        private static double _balans = 0;
        private static double _percent = 0.0061;
        private static DateTime _accounOpenDate;


        static List<Bank1> Person = new List<Bank1>();


        public delegate void Handling(string message);
        //public delegate void Handling();
        public event Handling Notify = (message) =>
        {
            Console.WriteLine($"На ваш номер телефон: {_phone}. Прибыло соообщение: {message} . ");
        };
        public Bank1(int id, string name, string surname, string phone)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _phone = phone;
        }
        public static double summ { get; private set; }
        private static void Check_Age()
        {
            Console.WriteLine("-----Введите дату своего рождения----- ");

            try
            {
                Console.Write("День (11) : ");
                day = int.Parse(Console.ReadLine());
                Console.Write("Месяц (12) : ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Год (2000) : ");
                year = int.Parse(Console.ReadLine());
                Console.Clear();
                _accounOpenDate = DateTime.Now;
                Console.WriteLine($"Дата открытия счета {_accounOpenDate} ");
                DateTime dataBorn = new DateTime(year, month, day);
                Console.WriteLine($"Дата рождения: {dataBorn.Day}.{dataBorn.Month}.{dataBorn.Year}");
                Console.WriteLine();
                _id += 1;
                Person.Add(new Bank1(1, "Сафиуллин", "Расиф", "89393987849"));
                Person.Add(new Bank1(2, "Камальдинов", "Ринат", "89393747785"));

                if (DateTime.Now.Year - year < 14)
                {
                    Console.WriteLine("Люди младше 14 лет не могут открыть счет.");
                }
            }
            catch
            {
                Console.WriteLine("Ошибка. Не правильно введена дата рождения.");
            }

        }
        private static void Amendment()
        {
            //Person<int, Bank1> bankList = new Person<int, Bank1> 
        }



        private static void Check_Remove()
        {
            Console.Write("Укажите сумму которое хотите снять: ");
            int b = int.Parse(Console.ReadLine());
            if (_balans - b < 0)
            {
                Console.WriteLine("Ошибка. Не достаточно средств для снятия со счета на балансе счета.");
            }
            else if (_balans - b > 0)
            {
                _balans -= b;
                Console.WriteLine($"Баланс счета составляет: {_balans}");
                Console.WriteLine();
            }
        }
        private static void popolnenie_cashback()
        {
            _balans += cashback;
            cashback = 0;
        }
        private static void First_deposit()
        {
            Console.Write("Укажите сумму пополнения: " );
            int a = int.Parse(Console.ReadLine());
            if (a < 10000 | a > 200000 )
            {
                Console.WriteLine("Ошибка. Сумма первого взноса должна быть больше 10 000р и меньше 200 000р.");
                
            }
            else if (_balans + a > 0 )
            {
                 _balans += a;
                Console.WriteLine($"Баланс счета составляет: {_balans}");
                Console.WriteLine();
            }
            
        }

        private static void Refill()
        {
            //Bank1 bank = new Bank1(_balans);
            //bank.Notify += DisplayMessage;
            First_deposit();
            //bank.Notify?.Invoke($"Пополнение на сумму: {a} р.");
        }
        private static void Cash_out()
        {
            //Bank1 bank = new Bank1(_balans);
            //bank.Notify += DisplayMessage;
            Check_Remove();
            //bank.Notify?.Invoke($"Было снято : {a}");
        }
        private static void CreateAccount()
        {
            Console.WriteLine("-----Добро пожаловать в наш банк-----");
            Console.WriteLine("Регистрация:");
            Console.Write("Введите ФИО (пример: Сафиуллин Расиф Фанисович): ");
            _name = Console.ReadLine();
            Console.Write("Введите номер своего телефона (пример: +7 ХХХ ХХХ-ХХ-ХХ): ");
            _phone = Console.ReadLine();
            Check_Age();
            if (DateTime.Now.Year - year > 14 )
            {
                Console.WriteLine("Благодарим за регистрацию в нашем банке.");
                Console.WriteLine($"Баланс счета составляет: {_balans}");
                Console.WriteLine();
            }
            else
            {

                Console.WriteLine("Ошибка. Регистрация не пройдена.");
                CreateAccount();
            }  
        }
        private static void Depozit()
        {
            while (true)
            {
                Console.WriteLine("Введите сумму которую хотите внести ");
                int s = int.Parse(Console.ReadLine());
                if (s > 10000 || s < 200000)
                {
                    if (_balans < s && _balans != 0)
                    {
                        Console.WriteLine("На вашем счету недостаточно средств");
                    }
                    
                    Console.Write("Через сколько лет вы хотите узнать свой баланс: ");
                    double a = double.Parse(Console.ReadLine());
                    double b = s;
                    for (int i = 0; i < a; i++)
                    {
                        b = _balans + _balans * _percent * i;
                    }
                    Console.WriteLine($"Ваш баланс через {a} лет, будет равен {b}.");
                    Console.WriteLine();
                }
            }
        }
        private static void Balance()
        {
            Console.WriteLine($"Баланс вашего счета равен: {_balans}");
            Console.WriteLine();
        }
        private static void Purchase()
        {
            popolnenie_cashback();
            Console.WriteLine("Выберите");
            Console.WriteLine($"1. Покупка у партнеров ({cashback_partner_percent} %)");
            Console.WriteLine($"2. Обычная покупка ({cashback_percent} %)");
            int cashback_s = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму покупки: ");
            int a = int.Parse(Console.ReadLine());
            if (a > _balans)
            {
                Console.WriteLine("Не удалось совершить покупку так как недостаточно средств");
            }
            else
            {
                if (cashback_s == 1)
                    cashback += a * cashback_partner_percent;
                else
                    cashback += a * cashback_percent;
                _balans -= a;
                Console.WriteLine($"Совершена покупка на {a} рублей");
            }

            popolnenie_cashback();
        }
        private static void Interestbalancec()
        {
            int second = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            int secondOpen = _accounOpenDate.Hour * 3600 + _accounOpenDate.Minute * 60 + _accounOpenDate.Second;
            int TimeBi = second - secondOpen;
            int period = 10;
            period = TimeBi / period;
            for (int i = 0; i < period; i++)
            {
                _balans = Math.Round(_balans + _balans * _percent, 2);
            }
            Console.WriteLine(_balans);
        }
        public static void Program()
        { 
        
            CreateAccount();
            //Bank1 human = new Bank1(_name, _phone, _birthday);
            {
                while (true)
                {
                    Console.WriteLine("1. Проверка баланса счета. ");
                    Console.WriteLine("2. Снять деньги со счета. ");
                    Console.WriteLine("3. Пополнить счет. ");
                    Console.WriteLine("4. Узнать баланс счета через определенный период ");
                    Console.WriteLine("5. Совершить покупку.");
                    Console.WriteLine("6. Процентная ставка.");
                    Console.WriteLine();
                    Console.WriteLine("Выберите последующие действия.");
                    int action = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (action)
                    {
                        case 1: Balance(); break;
                        case 2: Cash_out(); break;
                        case 3: Refill(); break;
                        case 4: Depozit(); break;
                        case 5: Purchase(); break;
                        case 6: Interestbalancec(); break;
                    }    
                }
            }
        }
    }
}
