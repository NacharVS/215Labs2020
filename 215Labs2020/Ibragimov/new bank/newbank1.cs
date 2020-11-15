using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.new_bank
{
    class NewBank1
    {
        private string _FIO;
        private string _phoneNumber;
        private int _age;
        private int _id;

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
        public int id
        {
            get { return _id; }
            private set
            {
                _id = id;
            }
        }

        public static void GetAge()
        {
            Console.WriteLine("Введите дату рождения в формате (00.00.00)");
            string[] date = new string[3];
            date = Console.ReadLine().Split(".");
            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = DateTime.Now.Year - int.Parse(date[2]) - 1;
            Console.WriteLine(date);
        }





























    }

}
