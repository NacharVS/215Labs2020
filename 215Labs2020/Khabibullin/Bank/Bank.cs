using System;


namespace _215Labs2020.Khabibullin
{
    class Bank:User
    {  
        private static double deposit = 0;
        private static double procents = 0.05;
        private static void Registration()
        {
            Console.WriteLine("Приветствую, вам необходимо зарегистрироваться, чтобы внести свои деньги в наш банк");
            Bank InfoBase = new Bank();
            Console.WriteLine("Введите имя");
            User.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.surname = Console.ReadLine();
        }
        private static void DateInfo()
        {
            Console.WriteLine("Введите информацию о вашем дне рождения");
            string a = Console.ReadLine();
            string[] date = a.Split(new char[] { '.' });
            User.date = int.Parse(date[0]);
            User.month = int.Parse(date[1]);
            User.year = int.Parse(date[2]);
            User.age = DateTime.Now.Year - User.year;
        }
        private static void Operations()
        {
            int i = 0;
            while (i <= 0)
            {
                try
                {
                    Bank InfoBase = new Bank();
                    Console.WriteLine("Введите сумму депозита");
                    double money = int.Parse(Console.ReadLine());
                    if (money >= 10000 || money <= 20000) Bank.deposit = money;
                    {
                        i = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! Депозит не может содержать слов!");
                }
            }
        }
        private static void Procents()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine("Введите срок кредита");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Bank.deposit += Bank.procents * Bank.deposit;
            }
        }
        private static void Finish()
        {
            Bank InfoBase = new Bank();
            Console.WriteLine($"После закрытия кредита ваш депозит будет:| {Bank.deposit} rubles");
            Console.WriteLine($"{Bank.name} {Bank.surname},спасибо, что пользуетесь нашим банком!");
        }
        public static void Method()
        {
            Bank InfoBase = new Bank();
            Bank.Registration();
            if ((User.name != User.EmployeeN || User.Surname != User.EmployeeS))
            {
                Bank.DateInfo();
                if (User.age >= 14)
                {
                    Bank.Operations();
                    {
                        Bank.Operations();
                        {
                            Bank.Procents();
                            Bank.Finish();
                        }
                    }
                }
                else
                    Console.WriteLine("Извините, но вы не можете пользоваться нашим банком несовершеннолетним");
            }
            else
                Console.WriteLine($"Привет,{User.EmployeeN} {User.EmployeeS}. Ваш оклад:{User.Pay}");
        }   
    }
}
