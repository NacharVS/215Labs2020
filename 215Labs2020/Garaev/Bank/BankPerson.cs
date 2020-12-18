using _Bank;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _215Labs2020.Garaev.Bank
{
    class BankPerson
    {
        private string surname;
        private string name;
        private string otchestvo;
        public int _day { get; set; }
        public int _month { get; set; }
        public int _year { get; set; }
        public  string _name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public  string _surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string _otchestvo
        {
            get
            {
                return otchestvo;
            }
            set
            {
                otchestvo = value;
            }
        }
        public static void Bank_deysviya()
        {
            Console.Clear();
            string text1 = "1) Зарегистрироваться как клиент";
            string text2 = "2) Зарегистрироваться как сотрудник";
            string text3 = "3) Выйти";
            string c = "<_______________БАНК_______________>";
            int n = 30;
            int dlina = 2;
            for (int i = c.Length / 2; i > 1; i--)
            {
                for (int l = 0; l < i; l++)
                {
                    Console.Write(" ");

                }
                c = c.Remove(0, i - 1);
                c = c.Remove(dlina);
                Console.Write(c);
                for (int l = 0; l < i; l++)
                {
                    Console.Write(" ");

                }
                Thread.Sleep(n);
                Console.SetCursorPosition(0, 0);
                c = "<_______________БАНК_______________>";
                dlina += 2;
            }
            Console.WriteLine(c);
            Console.WriteLine("         Выберите действие");
            for (int i = 1; i < text1.Length; i++)
            {
                Console.WriteLine(text1.Remove(i));
                Thread.Sleep(n);
                Console.SetCursorPosition(0, 2);
            }
            Console.WriteLine(text1);
            for (int i = 1; i < text2.Length; i++)
            {
                Console.WriteLine(text2.Remove(i));
                Thread.Sleep(n);
                Console.SetCursorPosition(0, 3);
            }
            Console.WriteLine(text2);
            for (int i = 1; i < text3.Length; i++)
            {
                Console.WriteLine(text3.Remove(i));
                Thread.Sleep(n);
                Console.SetCursorPosition(0, 4);
            }
            Console.WriteLine(text3);
            int a1 = int.Parse(Console.ReadLine());
            switch (a1)
            {
                case 1: Client.vibor_deistviy(); break;
                case 2: Sotrudnik.vibor_deistviy(); break;
            }
        }
    }
}
