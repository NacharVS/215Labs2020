using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MongoDB.Bson.Serialization.Attributes;


namespace ConsoleApp7
{
    public delegate void AccountHandler();
    class Bank
    {
        private static string _name;
        private static string _surname;
        private static int _age;
        private static int _minideposit = 10000;
        private static int _maxdeposit = 200000;
        private static double _bankaccount = 0;
        private static int _day;
        private static int _year;
        private static int _month;
        private static double _summ;
        private static DateTime _openDate;
        private static double _cashbackpersent = 0.03;
        private static double _cashbackpersentreferal = 0.05;
        private static double _depositpersent = 1.025;
        public static event AccountHandler Notify;


        private static void Put1(double sum)
        {

            int r;
            while (true)
            {
                r = 0;
                if (sum >= _minideposit & sum <= _maxdeposit)
                {
                    BankAccount += sum;
                    Notify += () => Console.WriteLine($"На счет поступило: {sum}");
                    Notify += () => Console.WriteLine($"На счету: {BankAccount}");
                    Notify.Invoke();
                    //Notify?.Invoke($"На счет поступило: {sum}");
                    //Notify?.Invoke($"На счетe : {BankAccount}");
                    r += 1;
                }
                else Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                if (r != 0) break;
            }

        }

        private static void Take1(double sum)
        {
            int r;
            while (true)
            {
                r = 0;
                if (BankAccount >= sum & sum >= _minideposit & sum <= _maxdeposit)
                {

                    BankAccount -= sum;
                    Notify += () => Console.WriteLine($"Со счета снято : {sum}");
                    Notify += () => Console.WriteLine($"На счету: {BankAccount}");
                    Notify.Invoke();
                    //Notify?.Invoke($"Со счета выведено: {sum}");
                    //Notify?.Invoke($"На счетe : {BankAccount}");
                    r += 1;
                }
                if (sum < _minideposit || sum > _maxdeposit) Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                if (r != 0) break;
            }
        }
        private static void CashBack1(double sum)
        {
            Console.WriteLine("У вас есть рефиральный код?");
            string referal = Console.ReadLine();
            if (referal == "Да")
            {
                Console.WriteLine("Введите его");
                Console.ReadLine();
                BankAccount += (sum * _cashbackpersentreferal);
                Notify += () => Console.WriteLine($"Кэшбэк : {sum}");
                Notify += () => Console.WriteLine($"На счету : {BankAccount}");
                Notify.Invoke();
                //Notify?.Invoke($"Кэшбэк : {sum}");
                //Notify?.Invoke($"На счетe : {BankAccount}");
            }
            else
            {
                BankAccount += (sum * _cashbackpersent);
                Notify += () => Console.WriteLine($"Кэшбэк : {sum}");
                Notify += () => Console.WriteLine($"На счету : {BankAccount}");
                Notify.Invoke();
                //Notify?.Invoke($"Кэшбэк : {sum}");
            }
        }
        public static double Summ
        {
            get
            {
                return _summ;

            }
            set
            {
                _summ = value;
            }

        }

        public static string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

            }

        }
        public static string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }

        }


        static public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                if (Age >= 14 & _month == DateTime.Now.Month & _day == DateTime.Now.Day)
                {
                    Console.WriteLine("Поздравляем с вашем днем рождением");
                    Bank.OperationInBank();
                }
                if (Age <= 14 & _month >= DateTime.Now.Month)
                {
                    Console.WriteLine("К сожалению регистрация в нашем банке возможна с 14 лет, мы вынуждены прервать регистрацию! Всего доброго:)");
                    return;
                }
                else
                {

                    Bank.OperationInBank();
                }
            }

        }
        public static double BankAccount
        {
            get
            {
                return _bankaccount;

            }
            private set
            {
                _bankaccount = value;

            }
        }
        public static void LaunchBank()
        {

            Bank.RegistrationBank();
        }
        static private void RegistrationBank()
        {
            Console.WriteLine("Здравствуйте, пожалуйста зарегистрируйтесь");
            Console.WriteLine("Введите свое имя");
            Name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            Surname = Console.ReadLine();
            Console.WriteLine("Введите свою дату рождения (Например 15.07.2003)");
            string birthday = Console.ReadLine();
            string[] array = birthday.Split(new char[] { '.' });
            _day = int.Parse(array[0]);
            _month = int.Parse(array[1]);
            _year = int.Parse(array[2]);
            _openDate = DateTime.Now;
            Age = DateTime.Now.Year - _year;




        }
        private static void Depositsonthebalance()
        {
            int second = DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            int secondOpen = _openDate.Hour * 3600 + _openDate.Minute * 60 + _openDate.Second;
            int deltaTime = second - secondOpen;
            int period = 10;
            period = deltaTime / period;
            for (int i = 0; i < period; i++)
            {
                BankAccount = Math.Round(BankAccount, 2);
            }
            Console.WriteLine(BankAccount);

        }
        private static void CashBack()
        {

            Console.WriteLine("Введите сумму на которую совершали покупку");
            Summ = double.Parse(Console.ReadLine());
            //acc.Notify += DisplayMessage;
            Bank.CashBack1(Summ);


        }
        private static void Deposit()
        {

            int year;
            int b;
            int c = DateTime.Now.Year;
            int r;
            Console.WriteLine($"На вашем счету {BankAccount}");
            while (true)
            {
                r = 0;
                Console.WriteLine("Введите сумму которую хотите внести ");
                b = int.Parse(Console.ReadLine());
                if (b < _minideposit || b > _maxdeposit)
                {
                    Console.WriteLine("Сумма должна быть не менее 10000 и не более 200000");
                    r += 1;


                }

                if (BankAccount < b && BankAccount != 0)
                {
                    Console.WriteLine("На вашем счету недостаточно средств");

                }
                if (r != 1) break;
            }
            Console.WriteLine("Введите на сколько лет хотите внести депозит");
            year = int.Parse(Console.ReadLine());
            if (BankAccount >= b & b >= _minideposit & b <= _maxdeposit) Console.WriteLine($"На вашем счету {BankAccount -= b}");
            _depositpersent = Math.Pow(_depositpersent, year);
            year += c;
            Console.WriteLine($"Ваш депозит в {year} году будет составлять {b * _depositpersent} ");

        }
        private static void Take()
        {




            Console.WriteLine("Введите сумму которую хотите снять ");
            Summ = int.Parse(Console.ReadLine());
            //acc.Notify += DisplayMessage;
            Bank.Take1(Summ);



        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static void Put()
        {

            Console.WriteLine("Введите сумму которую хотите внести ");
            Summ = int.Parse(Console.ReadLine());
            //acc.Notify += DisplayMessage;
            Bank.Put1(Summ);
        }
        public static void SetName(string newName)
        {
            _name = newName;
        }
        public static void SetSurName(string newSurName)
        {
            _surname = newSurName;
        }
        private static void Clients()
        {

            Dictionary<int, Bank> account = new Dictionary<int, Bank>();
            account.Add(1, new Bank("Vasuy", "Yan", 22));
            account.Add(2, new Bank("Masha", "Dobraya", 15));
            account.Add(3, new Bank("German", "Popov", 28));
            account.Add(4, new Bank("Igor", "Izerskii", 30));
            account.Add(5, new Bank("Petr", "Pervii", 38));
            Console.WriteLine("Для изменения необходим ваш id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Что вы хотите изменить?");
            string izmeneniya = Console.ReadLine();
            switch (izmeneniya)
            {
                case "Фамилия":
                    foreach (var item in account)
                    {
                        if (item.Key == id)
                        {

                            //item.Value.SetSurName();
                        }
                    }
                    break;
                case "Имя":
                    foreach (var item in account)
                    {
                        if (item.Key == id)
                        {

                            //item.Value.SetName(newName);
                        }
                    }
                    break;
            }

        }
        public Bank(string name, string surname, int age)
        {
            _name = name;
            _age = age;
            _surname = surname;
        }
        static async Task MongoInsert()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var datebase = client.GetDatabase("bank");
            var collection = datebase.GetCollection<Student>();
        }


        public static void OperationInBank()
        {
            while (true)
            {

                Console.WriteLine("Ваши возможные операции: внести денежные средства, снять денежные средства, внести денежные средста на депозит (2.5%)");
                string operations = Console.ReadLine();
                switch (operations)
                {
                    case "Внести денежные средства":
                        Put();
                        break;
                    case "Снять денежные средства":
                        Take();
                        break;
                    case "Внести денежные средста на депозит":
                        Deposit();
                        break;
                    case "Совершить покупку":
                        CashBack();
                        break;
                    case "Накрутить деньги":
                        Depositsonthebalance();
                        break;
                    case "1":
                        Clients();
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
