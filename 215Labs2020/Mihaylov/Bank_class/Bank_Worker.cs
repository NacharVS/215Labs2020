using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.Bank_class
{
    class Bank_Worker : Person
    {
        private static double salary = 50000;
        public static void bank_salary()
        {
            Console.WriteLine("За сколько месяцев вы хотите получить зарплату?");
            month = int.Parse(Console.ReadLine());
            balans+= month * salary;
            Console.WriteLine("Вы получили зарплату");
        }
        public static void bank_vacation()
        {
            Console.WriteLine("Вы хотите уехать в отпуск?");
            Console.WriteLine("Да/Нет");
            name = Console.ReadLine();
            switch (name)
            {
                case "Да":
                    balans += salary/2;
                    Console.WriteLine("Вы получили отпускную в размере пол зарплаты");
                    break;
                case "Нет":
                    Console.WriteLine("Приятной работы");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    goto case "Да";
            }
            
        }
        public static void bank_balans()
        {
            Console.WriteLine($"Ваш баланс составляет: {balans} р.");
        }
        public static void Program()
        {
            while (true)
            {
                Console.WriteLine("Получить зарплату: ( 1 )");
                Console.WriteLine("Уехать в отпуск: ( 2 )");
                Console.WriteLine("Узнать баланс: ( 3 )");
                int s = int.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1: bank_salary(); break;
                    case 2: bank_vacation(); break;
                    case 3: bank_balans(); break;
                }
            }
        }
    }
}

