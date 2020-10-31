using System;

namespace _215Labs2020.Imamov
{
    class Bank : User 
    {
       
        private static double deposit = 0;
        private static double procents = 0.05;
        private static void Registration()
        {
            Console.WriteLine("Greetings, you need sign in in our bank");
            Bank InfoBase = new Bank();
            Console.WriteLine("Enter your name");
            User.name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            User.surname = Console.ReadLine();
        }
        private static void DateInfo()
        {
            Console.WriteLine("Enter your date of your birthday");
            string a = Console.ReadLine();
            string[] date = a.Split(new char[] {'.'});
            User.date = int.Parse(date[0]);
            User.month = int.Parse(date[1]);
            User.year = int.Parse(date[2]);
            User.age = DateTime.Now.Year - User.year;
        }

        private static void Operations()
        {
            int i = 0;
            while (i <=0)
            {
                try
                {
                    Bank InfoBase = new Bank();
                    Console.WriteLine("Enter the amount of deposit");
                    double money = int.Parse(Console.ReadLine());
                    if (money >= 10000 || money <= 200000) Bank.deposit = money;
                    {
                        i = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Error! Deposit can't have any words in it!");
                }
            }
        }
        private static void Procents()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine("Enter the loan length");
            int lenght = int.Parse(Console.ReadLine());
            for (int i = 1; i < lenght; i++)
            {
                Bank.deposit += Bank.procents * Bank.deposit;
            }
        }
        private static void Finish()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine($"After the loan, that you chose, your deposit will be: {Bank.deposit} rubles");
            Console.WriteLine($"{User.name} {User.surname},thank you for using our bank!");
        }
        public static void Method()
        {
            Bank InfoBase = new Bank();
            Bank.Registration();
            if (User.name != User.EmployeeN || User.Surname != User.EmployeeS)
            {
                Bank.DateInfo();
                if (User.age >= 14)
                {
                    Bank.Operations();
                    {
                        Bank.Procents();
                        Bank.Finish();
                    }
                }
                else
                    Console.WriteLine("Sorry, but you can't use our bank underage");
            }
            else
                Console.WriteLine($"Greetings, {User.EmployeeN} {User.EmployeeS}. Your salary: {User.Pay}");
        }
    }
}
