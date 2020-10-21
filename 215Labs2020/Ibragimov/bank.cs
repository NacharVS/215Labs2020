using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Ibragimov
{
    class bank
    {
        public string Fio;
        public static double money = 0;
        public static void vklad(int a)
        {
            if (a < 10000)
            {
                Console.WriteLine("внесите суммму больше 10000");
            }
            else
            {
                bank.money += a;
                Console.WriteLine($"Счет пополнен\n{bank.money}");



            }

        }
    }
}


