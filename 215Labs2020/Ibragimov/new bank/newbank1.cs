using _215Labs2020.Ibragimov.BankKlas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _215Labs2020.Ibragimov.new_bank
{
    class NewBank1
    {
        public delegate void BankAccount(string phoneNumber, string kakoetosoobchenie);
        public event BankAccount Notify;

        private  string _FIO;
        private  string _phoneNumber;
        private static int _age;
        private  double _id;
        private  DateTime _accountOpen;
        private static double vklad;
        private  static double procent = 0.06;
        private  int period = 10;
        private static double CashBack = 0;
        private static DateTime VkladDay;
        public string FIO
        {
            get { return _FIO; }
            private set
            {
                _FIO = FIO;
            }
        }
        public string phoneNumber
        {
            get { return _phoneNumber; }
            private set
            {
                _phoneNumber = phoneNumber;
            }
        }
        public int age
        {
            get { return _age; }
            private set
            {
                _age = age;
            }
        }
        public double id
        {
            get { return _id; }
            private set
            {
                _id = id;
            }
        }
        public static int Age
        {
            get { return _age; }
            private set
            {
                if (value >= 14)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Ваш возраст не соответствует требуемому");
                    System.Environment.Exit(0);
                }
            }
        }


        public  void Regs()
        {
            NewBank1 bank1 = new NewBank1();
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

            Console.WriteLine("Напишите ваше фио");
            _FIO = Console.ReadLine();
            Console.WriteLine("Введите телефонный номер");
            _phoneNumber = Console.ReadLine();
            Console.WriteLine("Придумайте  ид ");
            _id = int.Parse(Console.ReadLine());

            _accountOpen = DateTime.Now;
            Console.WriteLine($"Дата регистрации {_accountOpen}");
            Notify?.Invoke(_phoneNumber, "поздравляем вы зарегались");
        }
          private void Operation() // проверка вклада через год
        {

            NewBank1 bank1 = new NewBank1();
            Console.WriteLine("Введите сумму депозита не менее 10 00 и не более 200 000");
            int money = int.Parse(Console.ReadLine());
            if (money >= 10000 && money <= 200000)
            {
                NewBank1.vklad = money;

            }
            else
            {
                Console.WriteLine("Вышла ошибка, перезайдите в программу");
                System.Environment.Exit(0);
            }
        }

        private void prognoz()
        {
            NewBank1 bank1 = new NewBank1();
            Console.WriteLine("На сколько лет вы планируете вложение?");
            int c = int.Parse(Console.ReadLine());
            for (int i = 1; i < c; i++)
            {
                NewBank1.vklad += NewBank1.procent * NewBank1.vklad;
            }
            Console.WriteLine($"Через указанный вами срок, ваш вклад составит {NewBank1.vklad} рублей.");
            Notify?.Invoke(_phoneNumber, "Поздравляем с вложением");
        }
        private void Datregist()
        {
            NewBank1 bank1 = new NewBank1();
            int c1 = (DateTime.Now.Hour - _accountOpen.Hour);
            int b = (DateTime.Now.Minute - _accountOpen.Minute);
            int a =(DateTime.Now.Second -  _accountOpen.Second );
            Console.WriteLine($"с момента вашей регистрации прошло {c1} часов {b} минут {a} секунд ");
            Notify?.Invoke(_phoneNumber, $"с момента вашей регистрации прошло {c1} часов {b} минут {a} секунд ");
        }


        private  void Banktime () // проверка вклада через секунды
        {
            
            NewBank1 bank1 = new NewBank1();
            Console.WriteLine("Введите сумму депозита не менее 10 00 и не более 200 000");
            int money = int.Parse(Console.ReadLine());
            NewBank1.vklad += money;
            VkladDay = DateTime.Now;


            Thread.Sleep(period * 1010);
            int c = DateTime.Now.Second;
            int e = c - VkladDay.Second;
            e = e / period;

            for (int i = 0; i < e; i++)
            {

                NewBank1.vklad += i * NewBank1.vklad;

            }
            Console.WriteLine(NewBank1.vklad);
            
        }

        private void pokupka()
        {
            NewBank1 bank1 = new NewBank1();
            Console.WriteLine("за сколько рублей купили вещь");
            double money = double.Parse(Console.ReadLine());
            NewBank1.vklad -= money;
            Console.WriteLine("в каком магазине купили вещь");
            string magaz = Console.ReadLine();

            if (magaz == "ali") 
            {
                NewBank1.CashBack = money * 0.05;
            }
            else
            {
                NewBank1.CashBack = money * 0.03;
            }
            Console.WriteLine(CashBack);
            Notify?.Invoke(_phoneNumber, $"Вы совершили покупку теперь ваш кэшбек {CashBack}");

        }
        public static void prover()
        {
                 NewBank1 bank1 = new NewBank1();
                 bank1.Regs();
                 bank1.Operation();
                 bank1.pokupka();
                 bank1.prognoz();
                 bank1.Datregist();
                 bank1.Banktime();
                 
        }      
        


















    }

}
