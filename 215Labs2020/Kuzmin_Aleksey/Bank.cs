using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Kuzmin_Aleksey
{
    class Bank
    {
        private double score = 0;
        private static double persent = 0.006;
        private string name;
        public static bool registration=false;
        private string year;
        private double donation;
        private string phone;
        public static Bank person = new Bank();
        public static void CreateAccount()
        {
            Console.WriteLine("*************************************************************");
            
            Console.Write("Введите свою фамилию, имя, отчество: ");
            person.name = Console.ReadLine();
            Console.Write("Введите дату своего рождения: ");
            person.year = Console.ReadLine();
            Console.Write("Введите свой номер телефона:  ");
            person.phone = Console.ReadLine();
            Console.Write("Введите сумму первого взноса: ");
            person.donation = double.Parse(Console.ReadLine());
            if (person.donation <= 10000) { Console.WriteLine("Ошибка. Сумма взноса меньше 10 000р."); }
            else { person.score += person.donation; }
            Bank.registration = true;
            Console.WriteLine("*************************************************************");
            Console.WriteLine();
        }
        public static void Refill()
        {
            Console.WriteLine("*************************************************************");
            Console.Write("Введите сумму, на которую вы хотите пополнить баланс: ");
            person.score +=  double.Parse(Console.ReadLine());
            Console.WriteLine("*************************************************************");
            Console.WriteLine($"Баланс счета составляет: {person.score}");
            Console.WriteLine("*************************************************************");
            Console.WriteLine();
        }
        public static void In_year()
        {
            Console.WriteLine("*************************************************************");
            Console.Write("Череез сколько лет вы хотите узнать свой баланс: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ваш баланс через {a} лет, будет равен {person.score+ person.score*Bank.persent*a}.");
            Console.WriteLine("*************************************************************");
            Console.WriteLine();
        }
        public static void balance()
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine($"Баланс вашего счета равен: {person.score}");
            Console.WriteLine("*************************************************************");
            Console.WriteLine();
        }

    }

}
