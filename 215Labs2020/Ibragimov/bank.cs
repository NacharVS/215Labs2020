using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov
{
    class bank
    {
        private static string FIO;
        private static double vklad = 0;
        private static double procent = 0.6;
        private void Regist()
        {
            Console.WriteLine("Введите фио");
            bank bank1 = new bank();
            bank.FIO = Console.ReadLine();

        }
        private void Operation()
        {
            bank bank1 = new bank();
            Console.WriteLine("Введите сумму депозита");
            double money = int.Parse(Console.ReadLine());
            if (money >= 10000 || money <= 200000) bank.vklad = money;
        }

        private void prognoz()
        {
            bank bank1 = new bank();
            Console.WriteLine("На сколько лет вы планируете вложение?");
            int coat = int.Parse(Console.ReadLine());
            for (int i = 1; i < coat; i++)
            {
                bank.vklad += bank.procent * bank.vklad;
            }
        }
        private void end()
        {
            bank bank1 = new bank();
            Console.WriteLine($"Через указанный вами срок, ваш вклад составит {bank.vklad} рублей.");
        }

        public static void program()
        {
            bank bank1 = new bank();
            bank1.Regist();
            bank1.Operation();
            bank1.prognoz();
            bank1.end();
        }
    }
    
}








