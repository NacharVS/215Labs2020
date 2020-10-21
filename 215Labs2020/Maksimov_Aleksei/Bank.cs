using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Maksimov_Aleksei
{
    class Bank
    {
        private string name;
        private string surname;
        private double vklad = 0;
        private static double procent = 0.1;
        private void Registration()
        {
            Console.WriteLine("Здравствуйте, для вложения средств в наш банк необходимо зарегистрироваться.");
            Bank bank = new Bank();
            Console.WriteLine("Введите ваше имя");
            bank.name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            bank.surname = Console.ReadLine();
        }
        private void Operation()
        {
            Bank bank = new Bank();
            Console.WriteLine("Введите сумму депозита");
            double money = int.Parse(Console.ReadLine());
            if (money >= 10000 || money <= 200000) bank.vklad = money;
        }
        private void prognoz()
        {
            Bank bank = new Bank();
            Console.WriteLine("На сколько лет вы планируете ");
            int coat = int.Parse(Console.ReadLine());
            for (int i = 0; i < coat; i++)
            {
                bank.vklad *= Bank.procent;
            }
            Console.WriteLine($"Через {coat} лет ваш процент составит {bank.vklad} рублей.");
            Console.WriteLine("Спасибо за оказанное вами доверия к банку МаксимовСтройГазНефтьАлмазИнвест.");
        }
        public static void method()
        {
            Bank bank = new Bank();
            bank.Registration();
            bank.Operation();
            bank.prognoz();
        }
    }
}