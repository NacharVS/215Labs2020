using System;
using _215Labs2020.Kuzmin_Aleksey;


namespace _215Labs2020
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
                Console.WriteLine("Доступные действия над банковским счетам:");
                Console.WriteLine("Проверить баланс счета: ( 1 ) ");
                Console.WriteLine("Пополнить счет: ( 2 ) ");
                Console.WriteLine("Узнать баланс счета через определенный период: ( 3 ) ");
                Console.WriteLine("Регистрация: ( 4 )");
                Console.Write("Введите действие над счетом: ");
                int action = int.Parse(Console.ReadLine()); 
                Console.WriteLine();
                if (Bank.registration || action==4)
                {
                    switch(action)
                    {
                        case 1: Bank.balance(); break;
                        case 2: Bank.Refill(); break;
                        case 3: Bank.In_year(); break;
                        case 4: Bank.CreateAccount(); break;
                    }
                }
                else 
                {
                    Console.WriteLine("*************************************************************");
                    Console.WriteLine("Ошибка. Для продолжения работы нужно пройти регистрацию.");
                    Console.WriteLine("*************************************************************");
                    Console.WriteLine();
                }
            }
        }
    }
}
