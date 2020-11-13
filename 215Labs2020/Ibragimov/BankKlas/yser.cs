using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov.BankKlas
{
    class bank : bank2

    {
        private DateTime _AccountOpendate;
        private static double vklad = 0;
        private static double procent = 0.06;
        private static int year = 0;
        private void Regist()
        {

            Console.WriteLine("Введите год рождения ");
            bank.year = int.Parse(Console.ReadLine());
            Year = DateTime.Now.Year - bank.year;

            if (Year > 14)
            {
                Console.WriteLine($"Можете зарегистрироваться, так как вам {Year} лет");
            }
            else
            {
                Console.WriteLine($"Вы не можете зарегистрироваться, так как вам {Year} лет , можно регистрироваться только с 14 лет ");
                System.Environment.Exit(0);
            }
            Console.WriteLine("Введите месяц вашего рождения");
            bank.mec = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день вашего рождения");
            bank.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите фио");
            bank bank1 = new bank();
            bank.FIO = Console.ReadLine();

        }
        

        private void Operation()
        {
            try
            {
                bank bank1 = new bank();
                Console.WriteLine("Введите сумму депозита");
                int money = int.Parse(Console.ReadLine());
                if (money >= 10000 && money <= 200000) bank.vklad = money; 
            }
            catch
            {
                Console.WriteLine("Вышла ошибка, перезайдите в программу");
            }
        }

        private void prognoz()
        {
            bank bank1 = new bank();
            Console.WriteLine("На сколько лет вы планируете вложение?");
            int c = int.Parse(Console.ReadLine());
            for (int i = 1; i < c; i++)
            {
                bank.vklad += bank.procent * bank.vklad;
            }
        }
        private void end()
        {
            bank bank1 = new bank();
            Console.WriteLine($"Через указанный вами срок, ваш вклад составит {bank.vklad} рублей.");
        }

        public static void baank()
        {

            bank bank1 = new bank();
            Console.WriteLine("Введите ваш id");
            int id = int.Parse(Console.ReadLine());
            if (id == rabotnikk.Id)
            {

                Console.WriteLine($"Здравствуйте {rabotnikk.FIO} , ваша зарплата на данный момент составляет: {rabotnikk.Zarplata}");
            }
            else
            {

                bank1.Regist();
                bank1.Operation();
                bank1.prognoz();
                bank1.end();

            }
        }
    }
} 
