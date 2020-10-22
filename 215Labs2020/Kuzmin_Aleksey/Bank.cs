using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class Bank
    {
        private static double score = 0;
        private static double persent = 0.006;
        private string name;
        private static bool registration=false;
        private string year;
        private static double donation=0;
        private string phone;
        private static string line="*************************************************************";
        
        
        private static double Proverka
        {
            get { return score; }
            set
            {
                if (value < 10000 | value > 200000)
                {
                    Console.WriteLine(Bank.line);
                    Console.WriteLine("Ошибка. Сумма взноса должна быть больше 10 000р и меньше 200 000р.");
                }
                else
                {
                    Bank.score += value;
                    Console.WriteLine(Bank.line);
                    Console.WriteLine($"Баланс счета составляет: {Bank.score}");
                    Console.WriteLine(Bank.line);
                    Console.WriteLine();
                }
            }
        }
        private static void CreateAccount()
        {
            Bank person = new Bank();
            Console.WriteLine(Bank.line);
            Console.Write("Введите свою фамилию, имя, отчество: ");
            person.name = Console.ReadLine();
            Console.Write("Введите дату своего рождения: ");
            person.year = Console.ReadLine();
            Console.Write("Введите свой номер телефона:  ");
            person.phone = Console.ReadLine();
            Console.Write("Введите сумму первого взноса: ");
            Bank.donation = double.Parse(Console.ReadLine());
            Bank.Proverka = double.Parse(Console.ReadLine());
            Console.WriteLine(Bank.line);
            Console.WriteLine();
        }
        private static void Refill()
        {
            Console.WriteLine(Bank.line);
            Console.Write("Введите сумму, на которую вы хотите пополнить баланс: ");
            Bank.donation = double.Parse(Console.ReadLine());
            if (Bank.donation < 10000 | Bank.donation > 200000) 
            {
                Console.WriteLine(Bank.line);
                Console.WriteLine("Ошибка. Сумма взноса должна быть больше 10 000р и меньше 200 000р.");
                Console.WriteLine(Bank.line);
            }
            else
            {
                Bank.score += Bank.donation;
                Console.WriteLine(Bank.line);
                Console.WriteLine($"Баланс счета составляет: {Bank.score}");
                Console.WriteLine(Bank.line);
                Console.WriteLine();
            }
        }
        private static void In_year()
        {
            Console.WriteLine(Bank.line);
            Console.Write("Через сколько лет вы хотите узнать свой баланс: ");
            double a = double.Parse(Console.ReadLine());
            double b = 0;
            for (int i = 0; i < a; i++)
            {
                b = Bank.score + Bank.score * persent * i;
            }
            Console.WriteLine($"Ваш баланс через {a} лет, будет равен {b}.");
            Console.WriteLine(Bank.line);
            Console.WriteLine();
        }
        private static void Balance()
        {
            Console.WriteLine(Bank.line);
            Console.WriteLine($"Баланс вашего счета равен: {Bank.score}");
            Console.WriteLine(Bank.line);
            Console.WriteLine();
        }
        private static void Cash_out()
        {
            Console.Write("Введите сумму для снятия с счета: ");
            Bank.donation = double.Parse(Console.ReadLine());
            if (Bank.donation < 10000 | Bank.donation > 200000)
            {
                Console.WriteLine(Bank.line);
                Console.WriteLine("Ошибка. Сумма снятия должна быть больше 10 000р и меньше 200 000р.");
                Console.WriteLine(Bank.line);
            }
            else 
            {
                Bank.score -= Bank.donation;
                Console.WriteLine($"Баланс счета составляет: {Bank.score}");
                Console.WriteLine(Bank.line);
                Console.WriteLine();
            }
        }
        public static void Program()
        {
            while (true)
            {
                Console.WriteLine("Доступные действия над банковским счетам:");
                Console.WriteLine("Проверить баланс счета: ( 1 ) ");
                Console.WriteLine("Снять деньги со счета: ( 2 ) ");
                Console.WriteLine("Пополнить счет: ( 3 ) ");
                Console.WriteLine("Узнать баланс счета через определенный период: ( 4 ) ");
                Console.WriteLine("Регистрация: ( 5 )");
                Console.Write("Введите действие над счетом: ");
                int action = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (registration || action == 5)
                {
                    switch (action)
                    {
                        case 1: Balance(); break;
                        case 2: Cash_out(); break;
                        case 3: Refill(); break;
                        case 4: In_year(); break;
                        case 5: CreateAccount(); break;
                    }
                }
                else
                {
                    Console.WriteLine(Bank.line);
                    Console.WriteLine("Ошибка. Для продолжения работы нужно пройти регистрацию.");
                    Console.WriteLine(Bank.line);
                    Console.WriteLine();
                }
            }
        }
    }

}
