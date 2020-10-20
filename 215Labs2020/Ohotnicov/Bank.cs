using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Ohotnicov
{
    class Bank
    {
        private string name;
        private string surname;
        private static int card = 0;
        int a;
        private static int Invest
        {
            get
            {
                card += a;
                return card;
            }
            set
            {
                if (value < 10000)
                {
                    Console.WriteLine("Минимальная сумма вклада 10.000 р.");
                }
                if (value > 200000)
                {
                    Console.WriteLine("Максимальная сумма вклада 200.000 р.");
                }
            }
        }
        private static int Withdraw
        {
            get
            {
                card += a;
                return card;
            }
            set
            {
                if (a > card)
                {
                    Console.WriteLine("Сумма списаний не может быть больше остатка на счету");
                }
            }
        }
        private static void GO();
        Bank Name = new Bank();



    }
}
