using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Hasanov.Bank
{
    class bank
    {
        private static string name;
        private static string surname;
        private static int minideposit = 10000;
        private static int maxdeposit = 200000;
        private static int bankaccount = 0;
        private static int age;
        private static int year;
        private static int day;
        private static int month;
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
            Console.WriteLine("Введите свою дату рождения (Например 15.07.2003)");
            string birthday = Console.ReadLine();
            string[] array = birthday.Split(new char[] { '.' });
            day = int.Parse(array[0]);
            month = int.Parse(array[1]);
            year = int.Parse(array[2]);
            age = DateTime.Now.Year - year;
            if (age >= 14 & month == DateTime.Now.Month & day == DateTime.Now.Day)
            {
                Console.WriteLine("Поздравляем с вашем днем рождением");
                bank.BankRegistration();
            }
            if (age <= 14 & month >= DateTime.Now.Month)
            {
                Console.WriteLine("К сожалению регистрация в нашем банке возможна с 14 лет, мы вынуждены прервать регистрацию! Всего доброго:)");
                return;
            }
            else bank.BankRegistration();

        }
        public static void BankRegistration()
        {
            Console.WriteLine("Здрасьте, приветствуем вас в банке ХАСУСГОССТРАХБАНК. Для возможности проведения денежных операций необходима регистрация счета");
            bank.Regist();


        }
        private static void OperationB(string BOA)
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



