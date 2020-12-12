using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _215Labs2020.Sabirov.User
{
    class User : Bank
    {
        public string Name => name;
        public User(string Name, string Surname, int Day, int Month, int Year, string Email)
        {
            User.name = Name;
            User.Surname = Surname;
            User.Day = Day;
            User.Month = Month;
            User.Age = Year;
            User.Email = Email;
        }
        
        private static double money = 0;
        private static double deposit = 1.1;
        public delegate void Handler(string mes);
        public static event Handler Notify;
        private static DateTime Regis;

        private static void DisplayMes(string mes)
        {
            Console.WriteLine(mes);
        }
        public User(int sum, DateTime res)
        {
            money = sum;
            Regis = res;
        }
        public static void Check(List<User>a)
        {
            Console.WriteLine($"Login as Employee or User?");
            Console.WriteLine($"Enter 1 to login as Employee or enter 2 to login as User");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    Employee.Login();
                    break;
                case "2":
                    User.Login(a);
                    break;
            }

        }

 



        private static void Withdraw()
        {
            Console.WriteLine("How many do you want to withdraw?");
            int x = int.Parse(Console.ReadLine());
            string mess = "You don't have enough money";
            string mess1 = "success!";
            Notify += (string x) => Console.WriteLine();
            if (x > money | x < 0)
            {

                Notify?.Invoke(mess);
            }
            else
            {
                User.money -= x;
                Notify?.Invoke(mess1);
            }
        }
        private static void Desposit()
        {
           
            Console.WriteLine("How much do you want to deposit?");
            int y;
            string input = Console.ReadLine();
            string mess = "Error";
            string mess1 = "Success";
           
            if (Int32.TryParse(input, out y))
            {
                if (y < 10000 & y < 200000)
                {
                    Notify?.Invoke(mess);
                }
                else
                {
                    User.money += y;

                    Notify?.Invoke(mess1);
                }
            }
            else
            {
                Notify?.Invoke("Incorrect");
            }

        }

        private static void User_Notify(string mes)
        {
            throw new NotImplementedException();
        }

        public static void signIn()
        {
            
            User person = new User(0, DateTime.Now);
            Console.WriteLine(User.Regis);
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
           
            
            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();
           
            Console.WriteLine("Enter your BirthDay");
            Bank.Day = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your BirthYear");
            Bank.Age = int.Parse(Console.ReadLine());
           
            
            User.Birth(Month, Age, Day);
            User.EmailCheck();
            User.UserName(name);
            User.UserName(surname);
            User.MonthCheck();
          


        }
        private static void UserName(string Newname)
        {

            Newname = Newname.Trim();
            var first = Newname[0];
            if (first.ToString() != first.ToString().ToUpper())
            {
                var other = Newname.Remove(0, 1);
                Newname = first.ToString().ToUpper() + other;
                Notify?.Invoke($"Your name with a capital letter: {Newname}");
               
            }

        }
        private static void Birth(int a, int b, int c)
        {
            if (b > 1900 & b < DateTime.Now.Year & c > 0 & c <= 31 & a > 0 & a <= 12)
            {
                if (DateTime.Now.Year - b < 18)
                {
                    Notify?.Invoke("You are underage :(");

                }
                else if (c == DateTime.Now.Day & a == DateTime.Now.Month)
                {
                    User.money += 100;

                    Notify?.Invoke($"it's your birthday!!! You are now {DateTime.Now.Year - b} year old.");
                    Notify?.Invoke($"{User.money}");
                    
                }

            }


        }
        private static void percnt(int period)
        {
           
            Thread.Sleep(period * 1010);
            int curr = DateTime.Now.Second;
            int v = curr - User.Regis.Second;
            v = v / period;
            
            for (int i = 0; i < v; i++)
            {
                User.money *= User.deposit;
                
                
            }
            Console.WriteLine(User.money);
        }
        private static void EmailCheck()
        {
            int a = 1;
            while (a == 1)
            {
                Console.WriteLine("Enter your E-mail");
                string em = Console.ReadLine();
                bool c = em.Contains('@');
                if (c == true)
                {
                    a = 0;
                    User.Email = em;
                }
                else
                {
                    Notify?.Invoke("Incorrect\nTry again");
                   
                }
            }
        }
        private static void MonthCheck()
        {
            Notify += DisplayMes;
            int g = 1;
            while (g == 1)
            {
                Console.WriteLine("Enter your Month");
                int mn = int.Parse(Console.ReadLine());
                
                if (mn <= 12)
                {
                    g = 0;
                    User.Month = mn;
                }
                else
                {
                    Notify?.Invoke("Incorrect\nTry again");

                }
            }
        }
        private static void CashBack(string shop, double price)
        {
            if (shop == "steam")
            {
                User.money -= price;
                User.money += price * 0.50;
                Console.WriteLine($"Because you bought your product from {shop} your cashback is 50%\nYour money {User.money}");
            }
            else
            {
                User.money -= price;
                User.money += price * 0.1;
                Console.WriteLine($"Your CashBack is 10%\nYour money {User.money}");
            }
        }

        public static void Login(List<User>a)
        {
            //User.signIn();
            
            Random bank123 = new Random();
            Bank.Id = bank123.Next(1000000, 1999999);
            Console.WriteLine($"Your id: {Bank.Id}");
            
           

            int yes = 1;
            while (yes == 1)
            {
                Console.WriteLine("What do you want to do (deposit money, withdraw money, Find out the amount of funds after replenishment of the deposit)");
                Console.WriteLine("Press 1 to deposit money\nPress 2 to withdraw money\nPress 3 to find out the amount of funds after replenishment of the deposit\n Press 4 to find out about your Cashback\n Press 5 to change personal data");
                string enter = Console.ReadLine();
                switch (enter)
                {
                    case "1":
                        
                        User.Desposit();
                       
                        Console.WriteLine("Do you want to continue?\n y/n");
                        string cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                    case "2":
                        //Notify += DisplayMes;
                        User.Withdraw();
                        Console.WriteLine("Do you want to continue?\n y/n");
                        cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                    case "3":
                        Notify += DisplayMes;
                        int per = int.Parse(Console.ReadLine());
                        Console.WriteLine("For what period do you want to deposit money?");
                        User.percnt(per);
                        Console.WriteLine("Do you want to continue?\n y/n");
                        cont = Console.ReadLine();
                        if (cont == "n") yes = 0;
                        break;
                    case "4":
                        Notify += DisplayMes;
                        Console.WriteLine("Where did you bought it?");
                        string shop = Console.ReadLine();
                        Console.WriteLine("How much?:");
                        double price = double.Parse(Console.ReadLine());
                        User.CashBack(shop, price);
                        break;
                    case "5":
                        Console.WriteLine("Enter your ID");
                        int i = int.Parse(Console.ReadLine());
                        break;
                    case "6":

            
                        break;
                   
                }
            }
        }
    }
}
