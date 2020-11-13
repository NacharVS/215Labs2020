using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Imamiev
{
    class Bank
    {
        private static string name;
        private static string surname;
        private static double deposit = 0;
        private static double procents = 0.05;
        private static int age;
        private static int date;
        private static int month;
        private static int year;
        private void Registration()
        {
            Console.WriteLine("Приветствую, вам необходимо зарегистрироваться, чтобы внести свои деньги в наш банк");
            Bank InfoBase = new Bank();
            Console.WriteLine("Введите имя");
            Bank.name = Console.ReadLine();
            Console.WriteLine("Введите  фамилию");
            Bank.surname = Console.ReadLine()
        }
        private void DateInfo()
        {
            Console.WriteLine("Введите информацию о вашем дне рождения");
            string a = Console.ReadLine();
            string[] date = a.Split(new char[] { '.'});
            Bank.date = int.Parse(date[0]);
            Bank.month = int.Parse(date[1]);
            Bank.year = int.Parse(date[2]);
            Bank.age = DateTime.Now.Year - Bank.year;
        }
        private void Operations()
        {
            int i = 0;
            while (i <= 0)
            {
                try
                {
                    Bank InfoBase = new Bank();
                    Console.WriteLine("Введите сумму депозита");
                    double money = int.Parse(Console.ReadLine());
                    if (money >= 10000 || money <= 20000) Bank.deposit = money;
                    {
                        i = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! Депозит не может содержать слов!");
                }
            }
        }
        private void Procent()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine("Введите срок кредита");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Bank.deposit += Bank.procents * Bank.deposit;
            }
        }
        private void Finish()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine($"После закрытия кредита ваш депозит будет:|{Bank.deposit} рублей");
            Console.WriteLine($"{Bank.name} {Bank.surname},спасибо, что пользуетесь нашим банком!");
        }
        public static void Method()
        {
            Bank InfoBase = new Bank();
            InfoBase.Registration();
            InfoBase.DateInfo();
            if(Bank.age >= 14)
            {
                InfoBase.Operations();
                InfoBase.Procent();
                InfoBase.Finish();
            }
            else
            {
                Console.WriteLine("Извините, но вы не можете воспользоваться нашим банком");
            }
        }
    }
}
