﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov
{
    class bank
    {
        private static string name;
        private static string surname;
        private static int minideposit = 10000;
        private static int maxdeposit = 200000;
        private static int bankaccount = 0;
        private static void Deposit(int deposit)
        {
            if (deposit >= minideposit & deposit <= maxdeposit) Console.WriteLine($"Спасибо за использование нашего банка, на вашем счету {bankaccount = +deposit}");
            else Console.WriteLine("Депозитная сумма должна быть не менее 10000 и не более 200000");
        }
        private static void Regist()
        {
            Console.WriteLine("Введите свое имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            surname = Console.ReadLine();
            try
            {
                Console.WriteLine("Для активации счета необходимо его пополнить");
                Console.WriteLine("Введите cумму которую хотите зачислить");
                int deposit = int.Parse(Console.ReadLine());
                bank.Deposit(deposit);
            }
            catch
            {
                Console.WriteLine("Вышла ошибка.");
            }
            finally
            {

            }
        }
        public static void BankRegistration()
        {
            Console.WriteLine("Здрасьте, приветствуем вас в банке ХАСУСГОССТРАХБАНК. Для возможности проведения денежных операций необходима регистрация счета");
            bank.Regist();
            Console.WriteLine("Ваши возможные операции: Внести денежные средства, Снять денежные средства, Внести денежные средста на депозит (5%)");
            string BOA = Console.ReadLine();
            bank.OperationB(BOA);
        }
        private static void OperationB (string BOA)
        {
            while (true)
            {
                int b;
                string f;
                double r = 1.05;

                switch (BOA)
                {
                    case "Внести денежные средства":
                        Console.WriteLine("Введите сумму которую хотите внести ");
                        b = int.Parse(Console.ReadLine());
                        if (b >= minideposit & b <= maxdeposit) Console.WriteLine($"На вашем счету {bankaccount += b}");
                        else Console.WriteLine("Депозитная сумма должна быть не менее 10000 и не более 200000");
                        break;
                    case "Снять денежные средства":
                        Console.WriteLine($"На вашем счету {bankaccount}");
                        Console.WriteLine("Введите сумму которую хотите снять ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"На вашем счету {bankaccount -= b}");
                        break;
                    case "Внести денежные средста на депозит":
                        Console.WriteLine($"На вашем счету {bankaccount}");
                        Console.WriteLine("Введите сумму которую вы хотите внести под депозит ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Вы успешно внесли деньги под депозит. Хотите узнать сколько будет на вашем счету денег через 5 лет.");
                        f = Console.ReadLine();
                        r = Math.Pow(r, 5);
                        if (f == "Да") Console.WriteLine(r * b);
                        else Console.WriteLine("Спасибо за использование нашего банка.Вего хорошего");
                        break;

                }
                Console.WriteLine("Вы хотите продолжить?(Да/Нет)");
                string flag = Console.ReadLine();
                if (flag != "Да") break;
            }
            Console.WriteLine("Спасибо за использование ХАСУСГОССТРАХБАНКа! Всего доброго");
        }

        
        
          
        
    }

}



