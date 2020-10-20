using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Galyautdinov
{
    class Bank
    {
        private static int bank_balans = 0;
        public static void FullName()
        {
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string middlename = Console.ReadLine();
        }
        public static void BankAccount()
        {
            Console.WriteLine();
            Console.Write("Введиет свой счет: ");
            int bank_account = int.Parse(Console.ReadLine());
            //bank_balans = 0;
            Console.WriteLine($"Ваш баланс: {bank_balans}");
        }
        public static void Replenishment()
        {
            Console.WriteLine("Будете ли вы пополнять счет? ДА/НЕТ");
            string operation = Console.ReadLine();
            if (operation == "ДА")
            {
                Console.Write("Введите сумму пополнения: ");
                int a = int.Parse(Console.ReadLine());
                if (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма пополнения 10 000 рублей.");
                }
                else
                {
                    
                }
            }
            else if (operation == "НЕТ")
            {

            }
        }

    }
}
