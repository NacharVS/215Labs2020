using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov
{
    class Bank
    {
        private static string name;
        private static string surname;
        private static int minideposit = 10000;
        private static int maxdeposit = 200000;
        private static int bankaccount = 0;
        private static void Deposit(int deposit)
        {
            
                
            if (deposit >= minideposit & deposit <= maxdeposit) Console.WriteLine($"Спасибо за использование нашего банка, на вашем счету {bankaccount = +deposit}");
            else Console.WriteLine("Депозитная сумма должна быть не меньше 10000 и не меньша 200000");
            
           
           


        }
        public static void Regist()
        {
            Console.WriteLine("Введите свое имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            surname = Console.ReadLine();
            Console.WriteLine("Введите cумму которую хотите зачислить");
            int deposit = int.Parse(Console.ReadLine());
            Bank.Deposit(deposit);
        }
    }
}
























