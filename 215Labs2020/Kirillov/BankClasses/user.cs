using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kirillov.BankClasses
{
    class user : Bank
    {
        private static double vklad = 0;
        private static double procent = 0.1;
        private void Daa()
        {
            user us = new user();
            Console.WriteLine("Введите дату вашего рождения через точку)");
            string h = Console.ReadLine();
            string[] dt = h.Split(new char[] { '.' });
            Bank.Dt = int.Parse(dt[0]);
            Bank.Mm = int.Parse(dt[1]);
            Bank.Yy = int.Parse(dt[2]);
            Bank.Age = DateTime.Now.Year - Bank.Yy;
        }
        private void Registration()
        {
            user us = new user();
            Console.WriteLine("Здравствуйте,для вложения средств в наш банк необходимо зарегистрироваться.");
            Console.WriteLine("Введите ваше имя");
            Bank.Name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            Bank.Surname = Console.ReadLine();
        }
        private void Operation()
        {
            try
            {
                Console.WriteLine("Введите сумму депозита");
                int money = int.Parse(Console.ReadLine());
                if (money >= 10000 && money <= 200000) user.vklad = money;
            }
            catch
            {
                Console.WriteLine("Вышла ошибка, перезайдите в программу");
            }
            finally
            {

            }
        }
        private void prognoz()
        {
            Console.WriteLine("На сколько лет вы планируете вложение?");
            int coat = int.Parse(Console.ReadLine());
            for (int i = 0; i < coat; i++)
            {
                user.vklad += user.procent * user.vklad;
            }
        }
        private void end()
        {
            Console.WriteLine($"Через указанный вами срок, ваш вклад составит {user.vklad} рублей.");
            Console.WriteLine($"{Bank.Name} {Bank.Surname}, спасибо за оказанное вами доверие банку 'Нанпромтайн'.");
        }
        public static void method()
        {
            user bank = new user();
            Console.WriteLine("Введите ваш id");
            int id = int.Parse(Console.ReadLine());
            bank.Registration();
            if (id != Employee.Id)
            {
                bank.Registration();
                bank.Daa();
                if (Bank.Age >= 14)
                {
                    bank.Operation();
                    if (user.vklad != 0)
                    {
                        bank.prognoz();
                        bank.end();
                    }
                }
                else
                    Console.WriteLine("Вы не можете положить деньги под депозит в нашем банке, так как вам недостаточно лет(");
            }
            else
                Console.WriteLine($"Здравствуйте {Employee.Rabname} {Employee.Rabsurname}, ваша зарпалата на данный момент составляет: {Employee.Zarplata}");
        }

    }
}
