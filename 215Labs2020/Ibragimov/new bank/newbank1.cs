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
        private static  double _id;
        private static DateTime _accountOpen;
        private static double vklad;
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
                    _age = value;
                else
                    Console.WriteLine("Ваш возраст не соответствует требуемому");
                
            }
        }

       
        public static void Regs ()
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

            Console.WriteLine("Напишите ваше фио");
            _FIO = Console.ReadLine();
            Console.WriteLine("Введите телефонный номер");
            _phoneNumber = Console.ReadLine();
            Console.WriteLine("Придумайте  ид ");
             _id = int.Parse(Console.ReadLine());
 
            _accountOpen = DateTime.Now;
            Console.WriteLine($"Дата регистрации {_accountOpen}") ;
        }
        private void Operation()
        {
            try
            {
                NewBank1 bank1 = new NewBank1();
                Console.WriteLine("Введите сумму депозита");
                int money = int.Parse(Console.ReadLine());
                if (money >= 10000 && money <= 200000) NewBank1.vklad = money;
            }
            catch
            {
                Console.WriteLine("Вышла ошибка, перезайдите в программу");
            }
        }




























    }

}
