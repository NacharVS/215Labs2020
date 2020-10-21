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
        private static bool registration=false;
        private string year;
        private double donation;
        private string phone;
        private string line = "*************************************************************";
        private static Bank person = new Bank();
        
        private static void CreateAccount()
        {
            Console.WriteLine(person.line);
            Console.Write("Введите свою фамилию, имя, отчество: ");
            person.name = Console.ReadLine();
            Console.Write("Введите дату своего рождения: ");
            person.year = Console.ReadLine();
            Console.Write("Введите свой номер телефона:  ");
            person.phone = Console.ReadLine();
            Console.Write("Введите сумму первого взноса: ");
            person.donation = double.Parse(Console.ReadLine());
            if (person.donation < 10000 | person.donation>200000) 
            {
                Console.WriteLine(person.line);
                Console.WriteLine("Ошибка. Сумма взноса должна быть больше 10 000р и меньше 200 000р."); 
            }
            else { person.score += person.donation; registration = true; }
            Console.WriteLine(person.line);
            Console.WriteLine();
        }
        private static void Refill()
        {
            Console.WriteLine(person.line);
            Console.Write("Введите сумму, на которую вы хотите пополнить баланс: ");
            person.donation = double.Parse(Console.ReadLine());
            if (person.donation < 10000 | person.donation > 200000) 
            {
                Console.WriteLine(person.line);
                Console.WriteLine("Ошибка. Сумма взноса должна быть больше 10 000р и меньше 200 000р.");
                Console.WriteLine(person.line);
            }
            else
            {
                person.score += person.donation;
                Console.WriteLine(person.line);
                Console.WriteLine($"Баланс счета составляет: {person.score}");
                Console.WriteLine(person.line);
                Console.WriteLine();
            }
        }
        private static void In_year()
        {
            Console.WriteLine(person.line);
            Console.Write("Через сколько лет вы хотите узнать свой баланс: ");
            double a = double.Parse(Console.ReadLine());
            double b = 0;
            for (int i = 0; i < a; i++)
            {
                b = person.score + person.score * persent * i;
            }
            Console.WriteLine($"Ваш баланс через {a} лет, будет равен {b}.");
            Console.WriteLine(person.line);
            Console.WriteLine();
        }
        private static void Balance()
        {
            Console.WriteLine(person.line);
            Console.WriteLine($"Баланс вашего счета равен: {person.score}");
            Console.WriteLine(person.line);
            Console.WriteLine();
        }
        private static void Cash_out()
        {
            Console.Write("Введите сумму для снятия с счета: ");
            person.donation = double.Parse(Console.ReadLine());
            if (person.donation < 10000 | person.donation > 200000)
            {
                Console.WriteLine(person.line);
                Console.WriteLine("Ошибка. Сумма снятия должна быть больше 10 000р и меньше 200 000р.");
                Console.WriteLine(person.line);
            }
            else 
            {
                person.score -= person.donation;
                Console.WriteLine($"Баланс счета составляет: {person.score}");
                Console.WriteLine(person.line);
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
                    Console.WriteLine(person.line);
                    Console.WriteLine("Ошибка. Для продолжения работы нужно пройти регистрацию.");
                    Console.WriteLine(person.line);
                    Console.WriteLine();
                }
            }
        }
    }

}
