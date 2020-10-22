using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _215Labs2020.Hasanov
{
    class Bank
    {
        private static string name;
        private static string surname;
        private static int minideposit = 10000;
        private static int maxdeposit = 200000;
        private static int bankaccount = 0;

        private static void Regist()
        {
            Console.WriteLine("Введите свое имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            surname = Console.ReadLine();
            Bank.OperationB();
        }
        public static void BankRegistration()
        {
            Console.WriteLine("Здрасьте, приветствуем вас в банке ХАСУСГОССТРАХБАНК. Для возможности проведения денежных операций необходима регистрация счета");
            Bank.Regist();
            
            
        }
        private static void OperationB()
        {
            Console.WriteLine("Для активации счета необходимо его пополнить");
            Console.WriteLine("Введите cумму которую хотите зачислить");
            while (true)
            {
                int b = 0;
                int deposit = int.Parse(Console.ReadLine());
                if (deposit >= minideposit & deposit <= maxdeposit) Console.WriteLine($"Спасибо за использование нашего банка, на вашем счету {bankaccount = +deposit}");
                if (deposit >= minideposit & deposit <= maxdeposit) b = +1;
                else Console.WriteLine("Депозитная сумма должна быть не менее 10000 и не более 200000, введите сумму заново");
                if (b != 0) break;
            }
            
            while (true)
            { Console.WriteLine("Ваши возможные операции: Внести денежные средства, Снять денежные средства, Внести денежные средста на депозит (2.5%)");
              string BOA = Console.ReadLine();
               double k=1.025;
               int year;
               int b;
               int c = DateTime.Now.Year;
                switch (BOA)
                {
                    case "Внести денежные средства":
                        
                        
                            Console.WriteLine("Введите сумму которую хотите внести ");
                            b = int.Parse(Console.ReadLine());
                            if (b >= minideposit & b <= maxdeposit) Console.WriteLine($"На вашем счету {bankaccount = +b}");
                            else if (b < minideposit & b > maxdeposit) Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                            break;
                        
                    case "Снять денежные средства":
                        Console.WriteLine($"На вашем счету {bankaccount}");
                        Console.WriteLine("Введите сумму которую хотите снять ");
                        b = int.Parse(Console.ReadLine());
                        if (bankaccount >= b & b >= minideposit & b <= maxdeposit) Console.WriteLine($"На вашем счету {bankaccount = -b}");
                        else if (bankaccount < b) Console.WriteLine("На вашем счету недостаточно средств");
                        else if (b < minideposit & b > maxdeposit) Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                        break;
                    case "Внести денежные средста на депозит (2.5%)":
                        Console.WriteLine($"На вашем счету {bankaccount}");
                        Console.WriteLine("Введите сумму которую внести ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите на сколько лет хотите внести депозит");
                        year = int.Parse(Console.ReadLine());
                        if (bankaccount >= b & b >= minideposit & b <= maxdeposit) Console.WriteLine($"На вашем счету {bankaccount = -b}");
                        else if (bankaccount < b) Console.WriteLine("На вашем счету недостаточно средств");
                        else if (b < minideposit & b > maxdeposit) Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                        year=+c;
                        k = Math.Pow(k, year);
                        Console.WriteLine($"Ваш депозит в {year} году будет составлять {b * k} ");
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
























