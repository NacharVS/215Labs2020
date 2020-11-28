using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Nurtdinova.Bank
{
    class user : Bank
    {
        private static double vklad = 0;
        private static double procent = 0.1;

        public delegate void Messege();
        public static event Messege EV1;

        public delegate void Messege2();
        public static event Messege2 EV2;

        public delegate void Messege3();
        public static event Messege3 EV3;
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
            Console.WriteLine("Здравствуйте, для вложения средств в наш банк необходимо зарегистрироваться.");
            Console.WriteLine("Введите ваше имя");
            Bank.Name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            Bank.Surname = Console.ReadLine();
            EV1 += () => Console.WriteLine($"{Bank.Name} {Bank.Surname}, Регистрация прошла успешно");
            if (Bank.Name != null)
            {
                EV1?.Invoke();
            }
        }
        private void Operation()
        {
            try
            {
                Console.WriteLine("Введите сумму депозита");
                int money = int.Parse(Console.ReadLine());
                if (money >= 10000 && money <= 200000) user.vklad = money;
                EV2 += () => Console.WriteLine($"Пополнение счета: {user.vklad}");
                EV2.Invoke();
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
            EV3 += () => Console.WriteLine($"Расчет готов!");
            EV3.Invoke();
            Console.WriteLine($"{Bank.Name} {Bank.Surname}, cпасибо за оказанное вами довериe к банку.");
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
                Console.WriteLine($"Здравствуйте {Employee.Rabname} {Employee.Rabsurname}, ваша зарплата на данный момент составляет: {Employee.Zarplata}");
        }
    }
}
