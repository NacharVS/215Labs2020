using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov
{
    class Bank
    {
        private static long phoneNumber;
        private static double deposit = 0;
        private static double procents = 0.05;
        public delegate void AccountOperations(string message);
        public event AccountOperations Notify;
        private static void Registration()
        {
            Console.WriteLine("Здравствуйте, зарегестрируйтесь,чтобы внести первые деньги");
            Bank InfoBase = new Bank();
            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            surname = Console.ReadLine();
        }
        private static void DateInfo()
        {
            Console.WriteLine("Введите дату вашего дня рождения");
            string a = Console.ReadLine();
            string[] date = a.Split(new char[] { '.' });
            User.date = int.Parse(date[0]);
            month = int.Parse(date[1]);
            year = int.Parse(date[2]);
            age = DateTime.Now.Year - year;
        }

        private static void Operations()
        {
            int i = 0;
            while (i <= 0)
            {
                try
                {
                    Bank InfoBase = new Bank();
                    Console.WriteLine("Введите первоначальную сумму депозита");
                    double money = int.Parse(Console.ReadLine());
                    if (money >= 10000 || money <= 200000) Bank.deposit = money;
                    {
                        i = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! Депозит не содержит слов");
                }
            }
        }
        private static void Procents()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine("Срок кредите");
            int lenght = int.Parse(Console.ReadLine());
            for (int i = 1; i < lenght; i++)
            {
                deposit += procents * deposit;
            }
        }
        private static void Finish()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine($"После закрытия ваш депозит будет отправлен на осмотр");
            Console.WriteLine($"{name} {surname},Спасибо,что пользуетесь именно нашим банком!");
        }
        public static void Method()
        {
            Bank InfoBase = new Bank();
            Registration();
            if (name != EmployeeN || Surname != EmployeeS)
            {
                DateInfo();
                if (age >= 14)
                {
                    Operations();
                    {
                        Procents();
                        Finish();
                    }
                }
                else
                    Console.WriteLine("Извините, но пока вам не исполнилось 18+ лет вы не можете пользоваться нашим банком");
            }
            else
                Console.WriteLine($"Здравствуйте,{EmployeeS}. Ваш оклад:{User.Pay}");
        }
    }
}
    
