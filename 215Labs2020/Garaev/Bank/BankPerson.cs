using _Bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Garaev.Bank
{
    class BankPerson
    {
        protected string name;
        protected string surname;
        protected string otchestvo;
        Client client = new Client();
        Sotrudnik sotrudnik = new Sotrudnik();
        public static void Bank_deysviya()
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1) Зарегистрироваться как клиент");
            Console.WriteLine("2) Зарегистрироваться как сотрудник");
            Console.WriteLine("3) Выйти");
            int a1 = int.Parse(Console.ReadLine());
            switch (a1)
            {
                case 1: Client.vibor_deistviy(); break;
                case 2: Sotrudnik.vibor_deistviy(); break;
            }
        }
    }
}
