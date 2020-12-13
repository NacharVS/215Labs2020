using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Mihaylov.Bank_class
{
    class Bank
    {
        public static void Program()
        {
            while (true)
            {
                Console.WriteLine("Клиент: ( 1 )");
                Console.WriteLine("Сотрудник: ( 2 )");
                int s = int.Parse(Console.ReadLine());
                switch (s)
                {
                    case 1: Bank_Client.Program(); break;
                    case 2: Bank_Worker.Program(); break;
                }
            }
        }
    }
}
