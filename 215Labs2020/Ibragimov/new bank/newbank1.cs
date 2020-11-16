using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.new_bank
{
    class NewBank1
    {
        private static string _FIO;
        private static string _phoneNumber;
        private static int _age;
        private static double _id;
        private static DateTime _accountOpen;
        private static double vklad;
        private static double procent = 0.06;
        
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
        }
        public  void Operation()
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
        }
        public void proverit()
        {
            NewBank1 bank1 = new NewBank1();
             int a =(  _accountOpen.Second - DateTime.Now.Second);
            Console.WriteLine($"с момента вашей регистрации прошло {a} секунд");
        }
        public static void prover()
        {
        NewBank1 bank1 = new NewBank1();
                 bank1.Regs();
                 bank1.Operation();
                 bank1.prognoz();
            bank1.proverit();



        }



















    }

}
