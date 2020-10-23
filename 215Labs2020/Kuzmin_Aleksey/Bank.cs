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
        private static bool take = false;
        private static bool take2 = false;
        private static double donation;
        private string year;        
        private string phone;
        private static string line="*************************************************************";       
        
        private static void Check1(double donation)
        {
            if (donation < 10000 | donation > 200000 & take2)
            {
                Console.WriteLine(Bank.line);
                Console.WriteLine("Ошибка. Сумма взноса должна быть больше 10 000р и меньше 200 000р.");
                Console.WriteLine(Bank.line);
                take = false;
                take2 = false;
            }
            else if (Bank.score - donation < 0 & take & take2)
            {
                Console.WriteLine(Bank.line);
                Console.WriteLine("Ошибка. Не достаточно средств для снятия со сочета на балансе счета.");
                Console.WriteLine(Bank.line);
                take = false;
                take2 = false;
            }
            else if(take2)
            {
                if (take) { Bank.score -= donation; }
                else { Bank.score += donation; }
                Console.WriteLine(Bank.line);
                Console.WriteLine($"Баланс счета составляет: {Bank.score}");
                Console.WriteLine(Bank.line);
                Console.WriteLine();
                take = false;
                take2 = false;
            }
        }
        private static void Check2(string donation)
        {
            try 
            { 
                double a = double.Parse(donation);
                Bank.donation = a;
                Bank.take2 = true;
            }
            catch 
            {
                Console.WriteLine(Bank.line);
                Console.WriteLine("Ошибка. Введенные символы не допустимы.");
                Console.WriteLine(Bank.line);
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
            Bank.Check2(Console.ReadLine());
            
            if (donation < 10000 | donation > 200000 & take2)
            {
                Console.WriteLine(Bank.line);
                Console.WriteLine("Ошибка. Сумма первого взноса должна быть больше 10 000р и меньше 200 000р.");
                Console.WriteLine(Bank.line);
                take2 = false;
            }
            else if (take2)
            {
                Bank.score += donation;
                Console.WriteLine(Bank.line);
                Console.WriteLine("Благодарим за регистрацию в нашем банке.");
                Console.WriteLine($"Баланс счета составляет: {Bank.score}");
                Console.WriteLine(Bank.line);
                Console.WriteLine();
                registration = true;
                take2 = false;
            }

        }
        private static void Refill()
        {
            Console.WriteLine(Bank.line);
            Console.Write("Введите сумму, на которую вы хотите пополнить баланс: ");
            Bank.Check2(Console.ReadLine());
            Bank.Check1(donation);
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
            take = true;
            Bank.Check2(Console.ReadLine());
            Bank.Check1(donation);
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
                if (registration == false) { Console.WriteLine("Регистрация: ( 5 )"); }               
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
